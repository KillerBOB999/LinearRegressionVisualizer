// INFORMATION----------------------------------------------------------------------------
// DEVELOPER:        Anthony Harris
// GITHUB:           https://github.com/KillerBOB999/LinearRegressionVisualizer
// DATE:             02 February 2020
// PURPOSE:          Linear Regression Visualizer tool in C# for CSC736: Machine Learning.
//----------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LinearRegressionVisualizer
{
    public partial class Form1 : Form
    {
        // INITIALIZE THE FORM

        public Form1()
        {
            InitializeComponent();
        }

        //----------------------------------------------------------------

        // EVENT LISTENERS

        // Start the main application when the run button is clicked
        private void button_Run_Click(object sender, EventArgs e)
        {
            button_Run.Enabled = false;
            button_PlayPause.Enabled = true;
            button_Reset.Enabled = true;
            ChangeInputStates();
            StartSimulation();
        }

        // Reset the main application when the reset button is clicked
        private void button_Reset_Click(object sender, EventArgs e)
        {
            if (timer != null)
            {
                timer.Dispose();
                timer.Stop();
            }
            if (bitmap != null)
            {
                bitmap.Dispose();
            }
            points.Clear();
            button_Reset.Enabled = false;
            using (Graphics graphics = splitContainer1.Panel2.CreateGraphics())
            {
                graphics.Clear(Color.Silver);
            }
            ChangeInputStates();
            button_PlayPause.Enabled = false;
            button_PlayPause.Text = "Pause Simulation";
            output_BiasError.Text = output_Epoch.Text = output_MSE.Text = output_NewCalculatedLine.Text = output_OldCalculatedLine.Text = output_WeightError.Text = "N/A";
            button_Run.Enabled = true;
        }

        // Automatically update and render the graph
        private void Timer_Tick(object sender, EventArgs e)
        {
            try
            {
                Update();
                Render();
            }
            catch
            {
                // Handle unknown errors gracefully
                timer.Enabled = false;
                MessageBox.Show("Oops, something went wrong!", "ERROR");
                button_Reset.PerformClick();
            }
        }

        // Validate input on input
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            // CHECK FOR EMPTY INPUT
            if ((sender as TextBox).Text.Count() == 0) return;

            // CHECK FOR TOO MUCH INPUT
            else if ((sender as TextBox).Text.Length >= 12)
            {
                MessageBox.Show("Maximum input characters reached!", "MAX CHARACTERS");
                (sender as TextBox).Text = (sender as TextBox).Text.Remove((sender as TextBox).Text.Count() - 1);
            }
        }

        // Validate input upon completion
        private void textBoxDoubleCheck(object sender, EventArgs e)
        {
            double result;
            string name = (sender as TextBox).Name;

            // CHECK FOR INVALID INPUT
            if (!double.TryParse((sender as TextBox).Text, out result))
            {
                if ((sender as TextBox).Text == "")
                {
                    MessageBox.Show("No entry detected!\n\nPlease enter a valid number.",
                    "NO ENTRY");
                }
                else
                {
                    MessageBox.Show("\"" + (sender as TextBox).Text + "\" is not a valid entry.\nPlease enter a valid number.",
                    "INVALID ENTRY");
                    (sender as TextBox).Text = (sender as TextBox).Text.Remove(0);
                }
                (sender as TextBox).Focus();
            }

            // DO UNIQUE ACTIONS FOR OUT OF BOUNDS EVENTS
            else if (name == "input_r" || name == "input_n" || name == "input_p" || name == "input_e")
            {
                if ((name == "input_r") && (result > 0.001 || result < 0.0000000001))
                {
                    MessageBox.Show("Input out of bounds!\n\n" +
                        "The learning rate must be between 0.0000000001 and 0.001.",
                        "INPUT OUT OF BOUNDS");
                    (sender as TextBox).Text = (sender as TextBox).Text.Remove(0);
                    (sender as TextBox).Focus();
                }
                else if ((name == "input_n") && (result > 0.3 || result < 0))
                {
                    MessageBox.Show("Input out of bounds!\n\n" +
                        "The noise level must be between 0 and 0.3.",
                        "INPUT OUT OF BOUNDS");
                    (sender as TextBox).Text = (sender as TextBox).Text.Remove(0);
                    (sender as TextBox).Focus();
                }
                else if (name == "input_e" || name == "input_p")
                {
                    (sender as TextBox).Text = ((int)Convert.ToDouble((sender as TextBox).Text)).ToString();
                    if (Convert.ToInt32((sender as TextBox).Text) > 250 || Convert.ToInt32((sender as TextBox).Text) <= 0)
                    {
                        MessageBox.Show("Input out of bounds!\n\n" +
                        "The number of generated points and points per epoch must be between 1 and 250.",
                        "INPUT OUT OF BOUNDS");
                        (sender as TextBox).Text = (sender as TextBox).Text.Remove(0);
                        (sender as TextBox).Focus();
                    }
                    else  if (name == "input_e" && result > Convert.ToDouble(input_p.Text))
                    {
                        MessageBox.Show("Points per epoch must be less than or equal to generated points!\n\n",
                            "PPE <= GP");
                        (sender as TextBox).Text = (sender as TextBox).Text.Remove(0);
                        (sender as TextBox).Focus();
                    }
                    else if (name == "input_p" && Convert.ToDouble((sender as TextBox).Text) < Convert.ToDouble(input_e.Text))
                    {
                        input_e.Text = (sender as TextBox).Text;
                    }
                }
            }

            // CHECK FOR OUT OF BOUNDS
            else if ((name == "input_w" || name == "input_b") && (result > 25 || result < -25))
            {
                MessageBox.Show("Input out of bounds!\n\n" +
                    "The slope and y-intercept must each be between -25 and 25.",
                    "INPUT OUT OF BOUNDS");
                (sender as TextBox).Text = (sender as TextBox).Text.Remove(0);
                (sender as TextBox).Focus();
            }
        }

        // Start/stop the simulation when the pause/resume button is clicked
        private void button_PlayPause_Click(object sender, EventArgs e)
        {
            if (timer.Enabled) button_PlayPause.Text = "Resume Simulation";
            else button_PlayPause.Text = "Pause Simulation";
            timer.Enabled = !timer.Enabled;
        }

        //----------------------------------------------------------------

        // GLOBALS

        public double w = 0;    // SLope of the line (weight)
        public double b = 0;    // Y-intercept of the line (bias)
        public double wCalc = 0;// Calculated w
        public double bCalc = 0;// Calculated b
        public double r = 0;    // Leanrning rate
        public double n = 0;    // Noise level (affects calculated values)
        public int p = 0;       // Number of points generated
        public int e = 0;       // Number of points to train on per epoch

        public int epoch;       // Simple counter
        public double bError;   // Accumulated bias error
        public double wError;   // Accumulated weight error
        public double MSE;      // Mean Squared Error

        // Generated points where y = (w * x + b) (+/-) n * (w * x + b)
        public List<Tuple<double, double>> points = new List<Tuple<double, double>>();

        public Timer timer;     // Used to auto update and render
        public Bitmap bitmap;   // Buffer for drawing to panel
        public const int roundTo = 5;   // Max precision


        //----------------------------------------------------------------

        // STARTING POINT OF THE MAIN APPLICATION

        public void StartSimulation()
        {
            try
            {
                CollectData();
                GeneratePoints();
                GenerateValues();
                bitmap = new Bitmap(splitContainer1.Panel2.Width, splitContainer1.Panel2.Height);
                epoch = 0;
                Render();
                SetUpTimer();
            }
            catch
            {
                MessageBox.Show("Oops, something went wrong!", "ERROR");
                button_Reset.PerformClick();
            }
        }

        //----------------------------------------------------------------

        // SET UP AND HELPER FUNCTIONS

        public void SetUpTimer()
        {
            timer = new Timer();
            timer.Tick += Timer_Tick;
            timer.Interval = 1; // Set interval to 0.5 seconds
            timer.Start();
        }

        public void CollectData()
        {
            w = Convert.ToDouble(input_w.Text);
            b = Convert.ToDouble(input_b.Text);
            n = Convert.ToDouble(input_n.Text);
            r = Convert.ToDouble(input_r.Text);
            p = Convert.ToInt32(input_p.Text);
            e = Convert.ToInt32(input_e.Text);
        }

        private void ChangeInputStates()
        {
            input_w.Enabled = !input_w.Enabled;
            input_b.Enabled = !input_b.Enabled;
            input_p.Enabled = !input_p.Enabled;
            input_r.Enabled = !input_r.Enabled;
            input_n.Enabled = !input_n.Enabled;
            input_e.Enabled = !input_e.Enabled;
        }

        //----------------------------------------------------------------

        // GENERATE THE NOISE

        public void GeneratePoints()
        {
            Random rng = new Random();
            double negativeModifier;
            for (int i = 0; i < p; ++i)
            {
                if (rng.NextDouble() > 0.5) negativeModifier = -1;
                else negativeModifier = 1;
                double x = (double)rng.Next(-CalcUpperLimit(), CalcUpperLimit());
                double y = CalcY(x, true);
                points.Add(new Tuple<double, double>(x, y + y * (negativeModifier * rng.NextDouble() * n)));
            }
        }

        public void GenerateValues()
        {
            Random rng = new Random();
            wCalc = rng.NextDouble();
            bCalc = rng.NextDouble();
        }

        //----------------------------------------------------------------

        // HELPER FUNCTIONS

        // Find max x value usable for display
        public int CalcUpperLimit() 
        {
            return Math.Min(
                Math.Abs((int)((splitContainer1.Panel2.Height / 2 - b) / w)), 
                splitContainer1.Panel2.Width / 2
            );
        }

        // Calculate the Y value from the function
        public double CalcY(double x, bool isGroundTruth)
        {
            if (isGroundTruth) return w * x + b;
            else return wCalc * x + bCalc;
        }

        // Select from training points to use in epoch
        public List<Tuple<double, double>> SelectPoints() 
        {
            List<Tuple<double, double>> epochPoints = new List<Tuple<double, double>>(points);
            Random rng = new Random();
            while (epochPoints.Count() > e) epochPoints.RemoveAt(rng.Next(0, epochPoints.Count() - 1));
            return epochPoints;
        }

        //----------------------------------------------------------------

        // UPDATE FUNCTIONS

        // Calculate the accumulated error of the calculated bias (bCalc)
        public double FindBiasError(ref List<Tuple<double, double>> epochPoints)
        {
            double error = 0;
            for (int i = 0; i < e; ++i)
            {
                error += epochPoints[i].Item2 - CalcY(epochPoints[i].Item1, false);
            }
            return error / e;
        }

        // Calculate the accumulated error of the calculated weight (wCalc)
        public double FindWeightError(ref List<Tuple<double, double>> epochPoints)
        {
            double error = 0;
            for (int i = 0; i < e; ++i)
            {
                error += (epochPoints[i].Item2 - CalcY(epochPoints[i].Item1, false)) * epochPoints[i].Item1;
            }
            return error / e;
        }

        // Calculate the Mean Square Error
        public double FindMSE(ref List<Tuple<double, double>> epochPoints)
        {
            double error = 0;
            for (int i = 0; i < e; ++i)
            {
                error += Math.Pow(epochPoints[i].Item2 - CalcY(epochPoints[i].Item1, false), 2);
            }
            return error / e;
        }

        //----------------------------------------------------------------

        // RENDER FUNCTIONS

        // Draw the x and y axis, as well as the labels
        public void DrawAxis(Graphics graphics)
        {
            int centerX = splitContainer1.Panel2.Width / 2;
            int centerY = splitContainer1.Panel1.Height / 2;
            int maxX = 2 * centerX;
            int maxY = 2 * centerY;
            Point [] xTri = new Point[] { // Arrow vertices for x axis
                new Point(maxX, centerY), 
                new Point(maxX - 10, centerY + 10),
                new Point(maxX - 10, centerY - 10),
            };
            Point[] yTri = new Point[] { // Arrow vertices for y axis
                new Point(centerX, 0),
                new Point(centerX - 10, 10),
                new Point(centerX + 10, 10),
            };
            Pen pen = new Pen(Color.Black);
            Font font = new Font("Arial", 16);
            SolidBrush brush = new SolidBrush(Color.Black);

            graphics.DrawLine(pen, centerX, 0, centerX, maxY); // x axis
            graphics.DrawLine(pen, 0, centerY, maxX, centerY); // y axis

            graphics.DrawString("X", font, brush, maxX - 10 - font.Size, centerY + 10); // x label
            graphics.DrawString("Y", font, brush, centerX + 10, 0); //  y label

            graphics.FillPolygon(brush, xTri); // x arrow
            graphics.FillPolygon(brush, yTri); // y arrow
        }

        // Draw the function to the panel
        public void DrawLine(Graphics graphics, bool isGroundTruth)
        {
            float x1 = 0;
            float x2 = splitContainer1.Panel2.Width;
            float lineWidth = 2;
            Pen pen;

            // Some helpers to transform graph to allow for all 4 quadrants
            float xConversion = splitContainer1.Panel2.Width / 2;
            float yConversion = splitContainer1.Panel2.Height / 2;

            // Which function are we trying to draw?
            if (isGroundTruth) pen = new Pen(Color.Lime, lineWidth);
            else pen = new Pen(Color.Yellow, lineWidth);

            graphics.DrawLine(pen, 
                x1, splitContainer1.Panel2.Height - (float)CalcY(x1 - xConversion, isGroundTruth) - yConversion, 
                x2, splitContainer1.Panel2.Height - (float)CalcY(x2 - xConversion, isGroundTruth) - yConversion);
        }

        // Draw the generated training points
        public void DrawPoints(Graphics graphics)
        {
            float radius = 3;

            // Some helpers to transform graph to allow for all 4 quadrants
            float xConversion = splitContainer1.Panel2.Width / 2;
            float yConversion = splitContainer1.Panel2.Height / 2;

            foreach (var point in points)
            {
                graphics.FillEllipse(new SolidBrush(Color.Black), 
                    (float)point.Item1 - radius + xConversion, // X-coord of center
                    splitContainer1.Panel2.Height - (float)point.Item2 - radius - yConversion, // Y-coord of center
                    radius * 2, // Width
                    radius * 2);// Height
            }
        }

        //----------------------------------------------------------------

        // UPDATE AND RENDER

        public void Update()
        {
            // Update base data
            ++epoch;
            List<Tuple<double, double>> epochPoints = SelectPoints();
            bError = FindBiasError(ref epochPoints);
            wError = FindWeightError(ref epochPoints);
            MSE = FindMSE(ref epochPoints);

            // Update output of base data
            output_Epoch.Text = epoch.ToString();
            output_OldCalculatedLine.Text = "y = " + Math.Round(wCalc, roundTo).ToString()
                + " * x + " + Math.Round(bCalc, roundTo).ToString();
            output_BiasError.Text = Math.Round(bError, roundTo).ToString();
            output_WeightError.Text = Math.Round(wError, roundTo).ToString();
            output_MSE.Text = Math.Round(MSE, roundTo).ToString();

            // Update calculated weight and bias
            bCalc = bCalc + r * bError;
            wCalc = wCalc + r * wError;

            // Update output of the calculated line
            output_NewCalculatedLine.Text = "y = " + Math.Round(wCalc, roundTo).ToString()
                + " * x + " + Math.Round(bCalc, roundTo).ToString();
        }

        public void Render()
        {
            // Draw the desired image to a bitmap that will then replace
            // with the existing image in the panel. Doing this in this
            // manner is necessary to prevent flickering because the
            // SplitContainer.Panel2 object cannot be double buffered.
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                // Draw the background
                graphics.FillRectangle(new System.Drawing.SolidBrush(Color.LightGray),
                    0, 0, splitContainer1.Panel2.Width, splitContainer1.Panel2.Height);

                DrawAxis(graphics);         // Draw the x and y axis
                DrawLine(graphics, true);   // Draw ground truth line
                DrawLine(graphics, false);  // Draw calculated line
                DrawPoints(graphics);       // Draw generated points
            }

            // Draw the newly created bitmap to the screen
            using (Graphics graphics = splitContainer1.Panel2.CreateGraphics())
            {
                graphics.DrawImage(bitmap, 0, 0);
            }
        }
    }
}

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
        private void button_Run_Click(object sender, EventArgs e)
        {
            button_Run.Enabled = false;
            ChangeInputStates();
            StartSimulation();
            button_Reset.Enabled = true;
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            button_Reset.Enabled = false;
            points.Clear();
            timer.Stop();
            bitmap.Dispose();
            using (Graphics graphics = splitContainer1.Panel2.CreateGraphics())
            {
                graphics.Clear(Color.Silver);
            }
            ChangeInputStates();
            button_Run.Enabled = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Update();
            Render();
        }

        //----------------------------------------------------------------

        // STARTING POINT OF THE PROGRAM
        public double w = 0;    // SLope of the line (weight)
        public double b = 0;    // Y-intercept of the line (bias)
        public double wCalc = 0;// Calculated w
        public double bCalc = 0;// Calculated b
        public double r = 0;    // Leanrning rate
        public double n = 0;    // Noise level (affects calculated values)
        public int p = 0;       // Number of points generated
        public int e = 0;       // Number of points to train on per epoch

        public int epoch;
        public double bError;
        public double wError;
        public double MSE;

        public List<Tuple<double, double>> points = new List<Tuple<double, double>>();

        public Timer timer = new Timer();
        public Bitmap bitmap;
        public const int roundTo = 5;

        public void StartSimulation()
        {
            CollectData();
            GeneratePoints();
            GenerateValues();
            bitmap = new Bitmap(splitContainer1.Panel2.Width, splitContainer1.Panel2.Height);
            epoch = 0;
            Update();
            Render();
            SetUpTimer();
        }

        public void SetUpTimer()
        {
            timer.Tick += Timer_Tick;
            timer.Interval = 500; // Set interval to 0.5 seconds
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

        public void GeneratePoints()
        {
            Random rng = new Random();
            double negativeModifier;
            for (int i = 0; i < p; ++i)
            {
                if (rng.NextDouble() > 0.5) negativeModifier = -1;
                else negativeModifier = 1;
                double x = (double)rng.Next(1, CalcUpperLimit());
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

        public int CalcUpperLimit()
        {
            return (int)((splitContainer1.Panel2.Height - b) / w);
        }

        public double CalcY(double x, bool isGroundTruth)
        {
            if (isGroundTruth) return w * x + b;
            else return wCalc * x + bCalc;
        }

        public void DrawLine(Graphics graphics, bool isGroundTruth)
        {
            float x1 = 0;
            float x2 = splitContainer1.Panel2.Width;
            float lineWidth = 3;
            Pen pen;

            if (isGroundTruth) pen = new Pen(Color.Lime, lineWidth);
            else pen = new Pen(Color.Yellow, lineWidth);

            graphics.DrawLine(pen, 
                x1, splitContainer1.Panel2.Height - (float)CalcY(x1, isGroundTruth), 
                x2, splitContainer1.Panel2.Height - (float)CalcY(x2, isGroundTruth));
        }

        public void DrawPoints(Graphics graphics)
        {
            float radius = 3;
            foreach (var point in points)
            {
                graphics.FillEllipse(new SolidBrush(Color.Black), 
                    (float)point.Item1 - radius, // X-coord of center
                    splitContainer1.Panel2.Height - (float)point.Item2 - radius, // Y-coord of center
                    radius * 2, // Width
                    radius * 2);// Height
            }
        }

        public void Update()
        {
            ++epoch;
            // List<tuple<double, double>> trainingPoints = FindTrainingPoints()
            // bError = FindBiasError();
            // wError = FindWeightError();
            // MSE = FindMSE();

            // bCalc += bCalc + r * bError;
            // wCalc += wCalc + r * wError;

            output_Epoch.Text = epoch.ToString();
            output_OldCalculatedLine.Text = "y = " + Math.Round(wCalc, roundTo).ToString()
                + " * x + " + Math.Round(bCalc, roundTo).ToString();
        }

        public void Render()
        {
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                DrawLine(graphics, true);   // Draw ground truth line
                DrawPoints(graphics);     // Draw generated points
                DrawLine(graphics, false);  // Draw calculated line
            }

            using (Graphics graphics = splitContainer1.Panel2.CreateGraphics())
            {
                graphics.DrawImage(bitmap, 0, 0);
            }
        }
    }
}

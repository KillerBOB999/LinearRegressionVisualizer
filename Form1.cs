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
        public Form1()
        {
            InitializeComponent();
            Focus();
        }

        private void button_Run_Click(object sender, EventArgs e)
        {
            StartSimulation();
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            // Reset Simulation
        }

        public void StartSimulation()
        {
            double w = Convert.ToDouble(input_w.Text);
            double b = Convert.ToDouble(input_b.Text);
            double n = Convert.ToDouble(input_n.Text);
            double p = Convert.ToDouble(input_p.Text);

            output_CalculatedLine.Text = "y = " + w.ToString() + " x + " + b.ToString();
        }

        public void Render()
        {

        }
    }
}

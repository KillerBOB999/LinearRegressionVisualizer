namespace LinearRegressionVisualizer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_GroundTruthLine = new System.Windows.Forms.Label();
            this.label_yEquals = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.input_w = new System.Windows.Forms.TextBox();
            this.label_TimesXPlus = new System.Windows.Forms.Label();
            this.input_b = new System.Windows.Forms.TextBox();
            this.label_LearningRate = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.input_r = new System.Windows.Forms.TextBox();
            this.label_rEquals = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.input_n = new System.Windows.Forms.TextBox();
            this.label_nEquals = new System.Windows.Forms.Label();
            this.label_NoiseLevel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.input_p = new System.Windows.Forms.TextBox();
            this.label_pEquals = new System.Windows.Forms.Label();
            this.label_GeneratedPoints = new System.Windows.Forms.Label();
            this.label_Epoch = new System.Windows.Forms.Label();
            this.container = new System.Windows.Forms.Panel();
            this.output_Epoch = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.output_CalculatedLine = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.output_BiasError = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.output_WeightError = new System.Windows.Forms.Label();
            this.label_CalculatedLine = new System.Windows.Forms.Label();
            this.label_BiasError = new System.Windows.Forms.Label();
            this.label_WeightError = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.output_MSE = new System.Windows.Forms.Label();
            this.label_MSE = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.container.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_GeneratedPoints);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.label_NoiseLevel);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.label_LearningRate);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label_GroundTruthLine);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 134);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hyper Parameters";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_MSE);
            this.groupBox2.Controls.Add(this.panel8);
            this.groupBox2.Controls.Add(this.label_WeightError);
            this.groupBox2.Controls.Add(this.label_BiasError);
            this.groupBox2.Controls.Add(this.label_CalculatedLine);
            this.groupBox2.Controls.Add(this.panel7);
            this.groupBox2.Controls.Add(this.panel6);
            this.groupBox2.Controls.Add(this.panel5);
            this.groupBox2.Controls.Add(this.container);
            this.groupBox2.Controls.Add(this.label_Epoch);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 164);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Run-TIme Data";
            // 
            // label_GroundTruthLine
            // 
            this.label_GroundTruthLine.AutoSize = true;
            this.label_GroundTruthLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_GroundTruthLine.Location = new System.Drawing.Point(6, 16);
            this.label_GroundTruthLine.Name = "label_GroundTruthLine";
            this.label_GroundTruthLine.Size = new System.Drawing.Size(99, 13);
            this.label_GroundTruthLine.TabIndex = 0;
            this.label_GroundTruthLine.Text = "Ground Truth Line: ";
            // 
            // label_yEquals
            // 
            this.label_yEquals.AutoSize = true;
            this.label_yEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_yEquals.Location = new System.Drawing.Point(3, 7);
            this.label_yEquals.Name = "label_yEquals";
            this.label_yEquals.Size = new System.Drawing.Size(21, 13);
            this.label_yEquals.TabIndex = 1;
            this.label_yEquals.Text = "y =";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.input_b);
            this.panel1.Controls.Add(this.label_TimesXPlus);
            this.panel1.Controls.Add(this.input_w);
            this.panel1.Controls.Add(this.label_yEquals);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(111, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(143, 30);
            this.panel1.TabIndex = 2;
            // 
            // input_w
            // 
            this.input_w.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_w.Location = new System.Drawing.Point(24, 5);
            this.input_w.Name = "input_w";
            this.input_w.Size = new System.Drawing.Size(39, 20);
            this.input_w.TabIndex = 2;
            this.input_w.Text = "2";
            this.input_w.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_TimesXPlus
            // 
            this.label_TimesXPlus.AutoSize = true;
            this.label_TimesXPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TimesXPlus.Location = new System.Drawing.Point(69, 7);
            this.label_TimesXPlus.Name = "label_TimesXPlus";
            this.label_TimesXPlus.Size = new System.Drawing.Size(28, 13);
            this.label_TimesXPlus.TabIndex = 3;
            this.label_TimesXPlus.Text = "* x +";
            // 
            // input_b
            // 
            this.input_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_b.Location = new System.Drawing.Point(103, 5);
            this.input_b.Name = "input_b";
            this.input_b.Size = new System.Drawing.Size(37, 20);
            this.input_b.TabIndex = 4;
            this.input_b.Text = "5";
            this.input_b.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_LearningRate
            // 
            this.label_LearningRate.AutoSize = true;
            this.label_LearningRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_LearningRate.Location = new System.Drawing.Point(6, 47);
            this.label_LearningRate.Name = "label_LearningRate";
            this.label_LearningRate.Size = new System.Drawing.Size(80, 13);
            this.label_LearningRate.TabIndex = 3;
            this.label_LearningRate.Text = "Learning Rate: ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.input_r);
            this.panel2.Controls.Add(this.label_rEquals);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(111, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(143, 30);
            this.panel2.TabIndex = 5;
            // 
            // input_r
            // 
            this.input_r.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_r.Location = new System.Drawing.Point(24, 5);
            this.input_r.Name = "input_r";
            this.input_r.Size = new System.Drawing.Size(116, 20);
            this.input_r.TabIndex = 2;
            this.input_r.Text = "0.000001";
            this.input_r.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_rEquals
            // 
            this.label_rEquals.AutoSize = true;
            this.label_rEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_rEquals.Location = new System.Drawing.Point(3, 7);
            this.label_rEquals.Name = "label_rEquals";
            this.label_rEquals.Size = new System.Drawing.Size(19, 13);
            this.label_rEquals.TabIndex = 1;
            this.label_rEquals.Text = "r =";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.input_n);
            this.panel3.Controls.Add(this.label_nEquals);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(111, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(143, 30);
            this.panel3.TabIndex = 6;
            // 
            // input_n
            // 
            this.input_n.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_n.Location = new System.Drawing.Point(24, 5);
            this.input_n.Name = "input_n";
            this.input_n.Size = new System.Drawing.Size(116, 20);
            this.input_n.TabIndex = 2;
            this.input_n.Text = "0.1";
            this.input_n.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_nEquals
            // 
            this.label_nEquals.AutoSize = true;
            this.label_nEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nEquals.Location = new System.Drawing.Point(3, 7);
            this.label_nEquals.Name = "label_nEquals";
            this.label_nEquals.Size = new System.Drawing.Size(22, 13);
            this.label_nEquals.TabIndex = 1;
            this.label_nEquals.Text = "n =";
            // 
            // label_NoiseLevel
            // 
            this.label_NoiseLevel.AutoSize = true;
            this.label_NoiseLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NoiseLevel.Location = new System.Drawing.Point(6, 78);
            this.label_NoiseLevel.Name = "label_NoiseLevel";
            this.label_NoiseLevel.Size = new System.Drawing.Size(66, 13);
            this.label_NoiseLevel.TabIndex = 7;
            this.label_NoiseLevel.Text = "Noise Level:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.input_p);
            this.panel4.Controls.Add(this.label_pEquals);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(111, 102);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(143, 30);
            this.panel4.TabIndex = 7;
            // 
            // input_p
            // 
            this.input_p.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_p.Location = new System.Drawing.Point(24, 5);
            this.input_p.Name = "input_p";
            this.input_p.Size = new System.Drawing.Size(116, 20);
            this.input_p.TabIndex = 2;
            this.input_p.Text = "20";
            this.input_p.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_pEquals
            // 
            this.label_pEquals.AutoSize = true;
            this.label_pEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pEquals.Location = new System.Drawing.Point(3, 7);
            this.label_pEquals.Name = "label_pEquals";
            this.label_pEquals.Size = new System.Drawing.Size(22, 13);
            this.label_pEquals.TabIndex = 1;
            this.label_pEquals.Text = "p =";
            // 
            // label_GeneratedPoints
            // 
            this.label_GeneratedPoints.AutoSize = true;
            this.label_GeneratedPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_GeneratedPoints.Location = new System.Drawing.Point(6, 110);
            this.label_GeneratedPoints.Name = "label_GeneratedPoints";
            this.label_GeneratedPoints.Size = new System.Drawing.Size(92, 13);
            this.label_GeneratedPoints.TabIndex = 8;
            this.label_GeneratedPoints.Text = "Generated Points:";
            // 
            // label_Epoch
            // 
            this.label_Epoch.AutoSize = true;
            this.label_Epoch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Epoch.Location = new System.Drawing.Point(6, 16);
            this.label_Epoch.Name = "label_Epoch";
            this.label_Epoch.Size = new System.Drawing.Size(41, 13);
            this.label_Epoch.TabIndex = 9;
            this.label_Epoch.Text = "Epoch:";
            // 
            // container
            // 
            this.container.Controls.Add(this.output_Epoch);
            this.container.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.container.Location = new System.Drawing.Point(111, 8);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(143, 30);
            this.container.TabIndex = 5;
            // 
            // output_Epoch
            // 
            this.output_Epoch.AutoSize = true;
            this.output_Epoch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_Epoch.Location = new System.Drawing.Point(3, 8);
            this.output_Epoch.Name = "output_Epoch";
            this.output_Epoch.Size = new System.Drawing.Size(27, 13);
            this.output_Epoch.TabIndex = 1;
            this.output_Epoch.Text = "N/A";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.output_CalculatedLine);
            this.panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(111, 39);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(143, 30);
            this.panel5.TabIndex = 6;
            // 
            // output_CalculatedLine
            // 
            this.output_CalculatedLine.AutoSize = true;
            this.output_CalculatedLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_CalculatedLine.Location = new System.Drawing.Point(3, 8);
            this.output_CalculatedLine.Name = "output_CalculatedLine";
            this.output_CalculatedLine.Size = new System.Drawing.Size(27, 13);
            this.output_CalculatedLine.TabIndex = 1;
            this.output_CalculatedLine.Text = "N/A";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.output_BiasError);
            this.panel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(111, 70);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(143, 30);
            this.panel6.TabIndex = 10;
            // 
            // output_BiasError
            // 
            this.output_BiasError.AutoSize = true;
            this.output_BiasError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_BiasError.Location = new System.Drawing.Point(3, 8);
            this.output_BiasError.Name = "output_BiasError";
            this.output_BiasError.Size = new System.Drawing.Size(27, 13);
            this.output_BiasError.TabIndex = 1;
            this.output_BiasError.Text = "N/A";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.output_WeightError);
            this.panel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel7.Location = new System.Drawing.Point(111, 101);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(143, 30);
            this.panel7.TabIndex = 11;
            // 
            // output_WeightError
            // 
            this.output_WeightError.AutoSize = true;
            this.output_WeightError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_WeightError.Location = new System.Drawing.Point(3, 8);
            this.output_WeightError.Name = "output_WeightError";
            this.output_WeightError.Size = new System.Drawing.Size(27, 13);
            this.output_WeightError.TabIndex = 1;
            this.output_WeightError.Text = "N/A";
            // 
            // label_CalculatedLine
            // 
            this.label_CalculatedLine.AutoSize = true;
            this.label_CalculatedLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CalculatedLine.Location = new System.Drawing.Point(6, 47);
            this.label_CalculatedLine.Name = "label_CalculatedLine";
            this.label_CalculatedLine.Size = new System.Drawing.Size(83, 13);
            this.label_CalculatedLine.TabIndex = 12;
            this.label_CalculatedLine.Text = "Calculated Line:";
            // 
            // label_BiasError
            // 
            this.label_BiasError.AutoSize = true;
            this.label_BiasError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_BiasError.Location = new System.Drawing.Point(6, 78);
            this.label_BiasError.Name = "label_BiasError";
            this.label_BiasError.Size = new System.Drawing.Size(55, 13);
            this.label_BiasError.TabIndex = 13;
            this.label_BiasError.Text = "Bias Error:";
            // 
            // label_WeightError
            // 
            this.label_WeightError.AutoSize = true;
            this.label_WeightError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_WeightError.Location = new System.Drawing.Point(6, 109);
            this.label_WeightError.Name = "label_WeightError";
            this.label_WeightError.Size = new System.Drawing.Size(69, 13);
            this.label_WeightError.TabIndex = 14;
            this.label_WeightError.Text = "Weight Error:";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.output_MSE);
            this.panel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel8.Location = new System.Drawing.Point(111, 132);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(143, 30);
            this.panel8.TabIndex = 12;
            // 
            // output_MSE
            // 
            this.output_MSE.AutoSize = true;
            this.output_MSE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_MSE.Location = new System.Drawing.Point(3, 8);
            this.output_MSE.Name = "output_MSE";
            this.output_MSE.Size = new System.Drawing.Size(27, 13);
            this.output_MSE.TabIndex = 1;
            this.output_MSE.Text = "N/A";
            // 
            // label_MSE
            // 
            this.label_MSE.AutoSize = true;
            this.label_MSE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MSE.Location = new System.Drawing.Point(6, 140);
            this.label_MSE.Name = "label_MSE";
            this.label_MSE.Size = new System.Drawing.Size(30, 13);
            this.label_MSE.TabIndex = 15;
            this.label_MSE.Text = "MSE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Linear Regression Visualization Tool";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.container.ResumeLayout(false);
            this.container.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_yEquals;
        private System.Windows.Forms.Label label_GroundTruthLine;
        private System.Windows.Forms.Label label_LearningRate;
        private System.Windows.Forms.TextBox input_b;
        private System.Windows.Forms.Label label_TimesXPlus;
        private System.Windows.Forms.TextBox input_w;
        private System.Windows.Forms.Label label_GeneratedPoints;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox input_p;
        private System.Windows.Forms.Label label_pEquals;
        private System.Windows.Forms.Label label_NoiseLevel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox input_n;
        private System.Windows.Forms.Label label_nEquals;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox input_r;
        private System.Windows.Forms.Label label_rEquals;
        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.Label output_Epoch;
        private System.Windows.Forms.Label label_Epoch;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label output_WeightError;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label output_BiasError;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label output_CalculatedLine;
        private System.Windows.Forms.Label label_CalculatedLine;
        private System.Windows.Forms.Label label_WeightError;
        private System.Windows.Forms.Label label_BiasError;
        private System.Windows.Forms.Label label_MSE;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label output_MSE;
    }
}


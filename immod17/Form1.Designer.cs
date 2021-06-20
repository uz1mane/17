
namespace immod17
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lambda1Num = new System.Windows.Forms.NumericUpDown();
            this.lambda2Num = new System.Windows.Forms.NumericUpDown();
            this.nNum = new System.Windows.Forms.NumericUpDown();
            this.tNum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.flow1Label = new System.Windows.Forms.Label();
            this.flow2Label = new System.Windows.Forms.Label();
            this.sumLabel = new System.Windows.Forms.Label();
            this.andLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lambda1Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lambda2Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tNum)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(-3, 0);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(536, 415);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea4.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart2.Legends.Add(legend4);
            this.chart2.Location = new System.Drawing.Point(539, 0);
            this.chart2.Name = "chart2";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart2.Series.Add(series4);
            this.chart2.Size = new System.Drawing.Size(536, 415);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // lambda1Num
            // 
            this.lambda1Num.Location = new System.Drawing.Point(101, 437);
            this.lambda1Num.Name = "lambda1Num";
            this.lambda1Num.Size = new System.Drawing.Size(120, 22);
            this.lambda1Num.TabIndex = 2;
            this.lambda1Num.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lambda2Num
            // 
            this.lambda2Num.Location = new System.Drawing.Point(101, 477);
            this.lambda2Num.Name = "lambda2Num";
            this.lambda2Num.Size = new System.Drawing.Size(120, 22);
            this.lambda2Num.TabIndex = 3;
            this.lambda2Num.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // nNum
            // 
            this.nNum.Location = new System.Drawing.Point(293, 437);
            this.nNum.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nNum.Name = "nNum";
            this.nNum.Size = new System.Drawing.Size(120, 22);
            this.nNum.TabIndex = 4;
            this.nNum.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // tNum
            // 
            this.tNum.DecimalPlaces = 3;
            this.tNum.Location = new System.Drawing.Point(293, 477);
            this.tNum.Name = "tNum";
            this.tNum.Size = new System.Drawing.Size(120, 22);
            this.tNum.TabIndex = 5;
            this.tNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 442);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Lambda1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 482);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Lambda2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 437);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "N";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 479);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "T";
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(458, 454);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 10;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // flow1Label
            // 
            this.flow1Label.AutoSize = true;
            this.flow1Label.Location = new System.Drawing.Point(572, 442);
            this.flow1Label.Name = "flow1Label";
            this.flow1Label.Size = new System.Drawing.Size(51, 17);
            this.flow1Label.TabIndex = 11;
            this.flow1Label.Text = "Flow l1";
            // 
            // flow2Label
            // 
            this.flow2Label.AutoSize = true;
            this.flow2Label.Location = new System.Drawing.Point(667, 442);
            this.flow2Label.Name = "flow2Label";
            this.flow2Label.Size = new System.Drawing.Size(51, 17);
            this.flow2Label.TabIndex = 12;
            this.flow2Label.Text = "Flow l2";
            // 
            // sumLabel
            // 
            this.sumLabel.AutoSize = true;
            this.sumLabel.Location = new System.Drawing.Point(765, 442);
            this.sumLabel.Name = "sumLabel";
            this.sumLabel.Size = new System.Drawing.Size(70, 17);
            this.sumLabel.TabIndex = 13;
            this.sumLabel.Text = "Flow l1+l2";
            // 
            // andLabel
            // 
            this.andLabel.AutoSize = true;
            this.andLabel.Location = new System.Drawing.Point(879, 442);
            this.andLabel.Name = "andLabel";
            this.andLabel.Size = new System.Drawing.Size(94, 17);
            this.andLabel.TabIndex = 14;
            this.andLabel.Text = "Flow l1 and l2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 893);
            this.Controls.Add(this.andLabel);
            this.Controls.Add(this.sumLabel);
            this.Controls.Add(this.flow2Label);
            this.Controls.Add(this.flow1Label);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tNum);
            this.Controls.Add(this.nNum);
            this.Controls.Add(this.lambda2Num);
            this.Controls.Add(this.lambda1Num);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lambda1Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lambda2Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.NumericUpDown lambda1Num;
        private System.Windows.Forms.NumericUpDown lambda2Num;
        private System.Windows.Forms.NumericUpDown nNum;
        private System.Windows.Forms.NumericUpDown tNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label flow1Label;
        private System.Windows.Forms.Label flow2Label;
        private System.Windows.Forms.Label sumLabel;
        private System.Windows.Forms.Label andLabel;
    }
}


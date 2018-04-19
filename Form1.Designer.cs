namespace Ch2___Simulated_Anealing
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
            System.Windows.Forms.Label labSize;
            System.Windows.Forms.Label labTemperature;
            System.Windows.Forms.Label labEnergy;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(50D, 30D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(100D, 50D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(150D, 60D);
            this.resultsBox = new System.Windows.Forms.TextBox();
            this.btnSolve = new System.Windows.Forms.Button();
            this.tbStats = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbEnergy = new System.Windows.Forms.TextBox();
            this.tbTemperature = new System.Windows.Forms.TextBox();
            this.tbSize = new System.Windows.Forms.TextBox();
            this.panControls = new System.Windows.Forms.Panel();
            this.btnTweak = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.chartResults = new System.Windows.Forms.DataVisualization.Charting.Chart();
            labSize = new System.Windows.Forms.Label();
            labTemperature = new System.Windows.Forms.Label();
            labEnergy = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panControls.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResults)).BeginInit();
            this.SuspendLayout();
            // 
            // labSize
            // 
            labSize.AutoSize = true;
            labSize.Dock = System.Windows.Forms.DockStyle.Fill;
            labSize.Location = new System.Drawing.Point(3, 0);
            labSize.Name = "labSize";
            labSize.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            labSize.Size = new System.Drawing.Size(134, 37);
            labSize.TabIndex = 0;
            labSize.Text = "Size";
            // 
            // labTemperature
            // 
            labTemperature.AutoSize = true;
            labTemperature.Dock = System.Windows.Forms.DockStyle.Fill;
            labTemperature.Location = new System.Drawing.Point(3, 37);
            labTemperature.Name = "labTemperature";
            labTemperature.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            labTemperature.Size = new System.Drawing.Size(134, 37);
            labTemperature.TabIndex = 2;
            labTemperature.Text = "Temperature";
            // 
            // labEnergy
            // 
            labEnergy.AutoSize = true;
            labEnergy.Dock = System.Windows.Forms.DockStyle.Fill;
            labEnergy.Location = new System.Drawing.Point(3, 74);
            labEnergy.Name = "labEnergy";
            labEnergy.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            labEnergy.Size = new System.Drawing.Size(134, 37);
            labEnergy.TabIndex = 7;
            labEnergy.Text = "Energy";
            // 
            // resultsBox
            // 
            this.resultsBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultsBox.Font = new System.Drawing.Font("Courier New", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsBox.Location = new System.Drawing.Point(3, 3);
            this.resultsBox.Multiline = true;
            this.resultsBox.Name = "resultsBox";
            this.resultsBox.ReadOnly = true;
            this.resultsBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.resultsBox.Size = new System.Drawing.Size(1295, 591);
            this.resultsBox.TabIndex = 1;
            this.resultsBox.TabStop = false;
            this.resultsBox.WordWrap = false;
            // 
            // btnSolve
            // 
            this.btnSolve.Location = new System.Drawing.Point(22, 256);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(219, 86);
            this.btnSolve.TabIndex = 0;
            this.btnSolve.Text = "Solve";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // tbStats
            // 
            this.tbStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbStats.Location = new System.Drawing.Point(1304, 600);
            this.tbStats.Multiline = true;
            this.tbStats.Name = "tbStats";
            this.tbStats.ReadOnly = true;
            this.tbStats.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbStats.Size = new System.Drawing.Size(400, 482);
            this.tbStats.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Controls.Add(labEnergy, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbEnergy, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbTemperature, 1, 1);
            this.tableLayoutPanel1.Controls.Add(labTemperature, 0, 1);
            this.tableLayoutPanel1.Controls.Add(labSize, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbSize, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(19, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(240, 111);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tbEnergy
            // 
            this.tbEnergy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbEnergy.Location = new System.Drawing.Point(143, 77);
            this.tbEnergy.Name = "tbEnergy";
            this.tbEnergy.ReadOnly = true;
            this.tbEnergy.Size = new System.Drawing.Size(94, 31);
            this.tbEnergy.TabIndex = 6;
            // 
            // tbTemperature
            // 
            this.tbTemperature.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTemperature.Location = new System.Drawing.Point(143, 40);
            this.tbTemperature.Name = "tbTemperature";
            this.tbTemperature.ReadOnly = true;
            this.tbTemperature.Size = new System.Drawing.Size(94, 31);
            this.tbTemperature.TabIndex = 3;
            // 
            // tbSize
            // 
            this.tbSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSize.Location = new System.Drawing.Point(143, 3);
            this.tbSize.Name = "tbSize";
            this.tbSize.Size = new System.Drawing.Size(94, 31);
            this.tbSize.TabIndex = 1;
            this.tbSize.Text = "10";
            this.tbSize.TextChanged += new System.EventHandler(this.tbSize_TextChanged);
            // 
            // panControls
            // 
            this.panControls.Controls.Add(this.btnTweak);
            this.panControls.Controls.Add(this.btnSolve);
            this.panControls.Controls.Add(this.tableLayoutPanel1);
            this.panControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panControls.Location = new System.Drawing.Point(1304, 3);
            this.panControls.Name = "panControls";
            this.panControls.Size = new System.Drawing.Size(400, 591);
            this.panControls.TabIndex = 5;
            // 
            // btnTweak
            // 
            this.btnTweak.Location = new System.Drawing.Point(22, 155);
            this.btnTweak.Name = "btnTweak";
            this.btnTweak.Size = new System.Drawing.Size(219, 74);
            this.btnTweak.TabIndex = 4;
            this.btnTweak.Text = "Tweak";
            this.btnTweak.UseVisualStyleBackColor = true;
            this.btnTweak.Click += new System.EventHandler(this.btnTweak_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.resultsBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panControls, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbStats, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.chartResults, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.0308F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.9692F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1707, 1085);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // chartResults
            // 
            chartArea1.AxisX.MajorGrid.Interval = 50D;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisY.Maximum = 100D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.chartResults.ChartAreas.Add(chartArea1);
            this.chartResults.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartResults.Legends.Add(legend1);
            this.chartResults.Location = new System.Drawing.Point(3, 600);
            this.chartResults.Name = "chartResults";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            this.chartResults.Series.Add(series1);
            this.chartResults.Size = new System.Drawing.Size(1295, 482);
            this.chartResults.TabIndex = 6;
            this.chartResults.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1707, 1085);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "Form1";
            this.Text = "Chapter 2 - Simulated Annealing - N Queens";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panControls.ResumeLayout(false);
            this.panControls.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox resultsBox;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.TextBox tbStats;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tbTemperature;
        private System.Windows.Forms.TextBox tbSize;
        private System.Windows.Forms.TextBox tbEnergy;
        private System.Windows.Forms.Panel panControls;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnTweak;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResults;
    }
}


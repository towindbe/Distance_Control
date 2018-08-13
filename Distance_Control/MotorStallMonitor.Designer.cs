namespace Distance_Control
{
    partial class MotorStallMonitor
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.CalibrateLF025_button = new System.Windows.Forms.Button();
            this.StallValue_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.StallValue_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // CalibrateLF025_button
            // 
            this.CalibrateLF025_button.Location = new System.Drawing.Point(12, 401);
            this.CalibrateLF025_button.Name = "CalibrateLF025_button";
            this.CalibrateLF025_button.Size = new System.Drawing.Size(93, 37);
            this.CalibrateLF025_button.TabIndex = 0;
            this.CalibrateLF025_button.Text = "Calibrate LF025";
            this.CalibrateLF025_button.UseVisualStyleBackColor = true;
            this.CalibrateLF025_button.Click += new System.EventHandler(this.CalibrateLF025_button_Click);
            // 
            // StallValue_chart
            // 
            chartArea1.Name = "ChartArea1";
            this.StallValue_chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.StallValue_chart.Legends.Add(legend1);
            this.StallValue_chart.Location = new System.Drawing.Point(12, 12);
            this.StallValue_chart.Name = "StallValue_chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Motor Load in %";
            this.StallValue_chart.Series.Add(series1);
            this.StallValue_chart.Size = new System.Drawing.Size(790, 372);
            this.StallValue_chart.TabIndex = 1;
            this.StallValue_chart.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title";
            title1.Text = "Motor Load depending on Stall Limit";
            this.StallValue_chart.Titles.Add(title1);
            // 
            // MotorStallMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 450);
            this.Controls.Add(this.StallValue_chart);
            this.Controls.Add(this.CalibrateLF025_button);
            this.Name = "MotorStallMonitor";
            this.Text = "MotorStallMonitor";
            ((System.ComponentModel.ISupportInitialize)(this.StallValue_chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CalibrateLF025_button;
        private System.Windows.Forms.DataVisualization.Charting.Chart StallValue_chart;
    }
}
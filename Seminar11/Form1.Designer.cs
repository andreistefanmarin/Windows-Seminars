namespace Seminar11
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
            ChartLibrary.BarChartValue barChartValue1 = new ChartLibrary.BarChartValue();
            ChartLibrary.BarChartValue barChartValue2 = new ChartLibrary.BarChartValue();
            this.barChartControl1 = new ChartLibrary.BarChartControl();
            this.SuspendLayout();
            // 
            // barChartControl1
            // 
            barChartValue1.Label = "andrei";
            barChartValue1.Value = 10;
            barChartValue2.Label = "code";
            barChartValue2.Value = 30;
            this.barChartControl1.Data = new ChartLibrary.BarChartValue[] {
        barChartValue1,
        barChartValue2};
            this.barChartControl1.Location = new System.Drawing.Point(89, 256);
            this.barChartControl1.Name = "barChartControl1";
            this.barChartControl1.Size = new System.Drawing.Size(761, 249);
            this.barChartControl1.TabIndex = 0;
            this.barChartControl1.Text = "barChartControl1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 572);
            this.Controls.Add(this.barChartControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ChartLibrary.BarChartControl barChartControl1;
    }
}


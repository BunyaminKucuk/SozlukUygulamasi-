namespace Dictionary
{
    partial class CubukGrafigi
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
            this.grafig = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.geribtn = new System.Windows.Forms.Button();
            this.grpögrenilenkelimeler = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.grafig)).BeginInit();
            this.grpögrenilenkelimeler.SuspendLayout();
            this.SuspendLayout();
            // 
            // grafig
            // 
            chartArea1.Name = "ChartArea1";
            this.grafig.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.grafig.Legends.Add(legend1);
            this.grafig.Location = new System.Drawing.Point(19, 43);
            this.grafig.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grafig.Name = "grafig";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Kelimeler";
            this.grafig.Series.Add(series1);
            this.grafig.Size = new System.Drawing.Size(800, 484);
            this.grafig.TabIndex = 0;
            this.grafig.Text = "chart1";
            // 
            // geribtn
            // 
            this.geribtn.BackColor = System.Drawing.Color.Transparent;
            this.geribtn.BackgroundImage = global::Dictionary.Properties.Resources.back22;
            this.geribtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.geribtn.FlatAppearance.BorderSize = 0;
            this.geribtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.geribtn.ForeColor = System.Drawing.Color.OldLace;
            this.geribtn.Location = new System.Drawing.Point(836, 27);
            this.geribtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.geribtn.Name = "geribtn";
            this.geribtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.geribtn.Size = new System.Drawing.Size(44, 49);
            this.geribtn.TabIndex = 33;
            this.geribtn.UseVisualStyleBackColor = false;
            this.geribtn.Click += new System.EventHandler(this.Geribtn_Click);
            // 
            // grpögrenilenkelimeler
            // 
            this.grpögrenilenkelimeler.Controls.Add(this.grafig);
            this.grpögrenilenkelimeler.Controls.Add(this.geribtn);
            this.grpögrenilenkelimeler.Location = new System.Drawing.Point(12, 12);
            this.grpögrenilenkelimeler.Name = "grpögrenilenkelimeler";
            this.grpögrenilenkelimeler.Size = new System.Drawing.Size(898, 541);
            this.grpögrenilenkelimeler.TabIndex = 34;
            this.grpögrenilenkelimeler.TabStop = false;
            this.grpögrenilenkelimeler.Text = "ÖĞRENİLEN KELİMELER";
            // 
            // CubukGrafigi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 562);
            this.Controls.Add(this.grpögrenilenkelimeler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CubukGrafigi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CubukGrafigi";
            this.Load += new System.EventHandler(this.CubukGrafigi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grafig)).EndInit();
            this.grpögrenilenkelimeler.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart grafig;
        private System.Windows.Forms.Button geribtn;
        private System.Windows.Forms.GroupBox grpögrenilenkelimeler;
    }
}
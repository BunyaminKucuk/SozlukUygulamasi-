namespace Dictionary
{
    partial class testetme
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
            this.components = new System.ComponentModel.Container();
            this.btnılerı = new System.Windows.Forms.Button();
            this.lblcumle = new System.Windows.Forms.Label();
            this.rdasıkkı = new System.Windows.Forms.RadioButton();
            this.rdbsıkkı = new System.Windows.Forms.RadioButton();
            this.rdcsıkkı = new System.Windows.Forms.RadioButton();
            this.rddsıkkı = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.sonrakibtn = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.grptest = new System.Windows.Forms.GroupBox();
            this.geri = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.grptest.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnılerı
            // 
            this.btnılerı.Location = new System.Drawing.Point(39, 264);
            this.btnılerı.Name = "btnılerı";
            this.btnılerı.Size = new System.Drawing.Size(158, 58);
            this.btnılerı.TabIndex = 5;
            this.btnılerı.Text = "BAŞLA";
            this.btnılerı.UseVisualStyleBackColor = true;
            this.btnılerı.Click += new System.EventHandler(this.Btnılerı_Click);
            // 
            // lblcumle
            // 
            this.lblcumle.AutoSize = true;
            this.lblcumle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblcumle.Location = new System.Drawing.Point(18, 69);
            this.lblcumle.Name = "lblcumle";
            this.lblcumle.Size = new System.Drawing.Size(65, 25);
            this.lblcumle.TabIndex = 6;
            this.lblcumle.Text = "Soru:";
            // 
            // rdasıkkı
            // 
            this.rdasıkkı.AutoSize = true;
            this.rdasıkkı.Location = new System.Drawing.Point(23, 156);
            this.rdasıkkı.Name = "rdasıkkı";
            this.rdasıkkı.Size = new System.Drawing.Size(45, 24);
            this.rdasıkkı.TabIndex = 12;
            this.rdasıkkı.TabStop = true;
            this.rdasıkkı.Text = "A";
            this.rdasıkkı.UseVisualStyleBackColor = true;
            // 
            // rdbsıkkı
            // 
            this.rdbsıkkı.AutoSize = true;
            this.rdbsıkkı.Location = new System.Drawing.Point(277, 156);
            this.rdbsıkkı.Name = "rdbsıkkı";
            this.rdbsıkkı.Size = new System.Drawing.Size(45, 24);
            this.rdbsıkkı.TabIndex = 13;
            this.rdbsıkkı.TabStop = true;
            this.rdbsıkkı.Text = "B";
            this.rdbsıkkı.UseVisualStyleBackColor = true;
            // 
            // rdcsıkkı
            // 
            this.rdcsıkkı.AutoSize = true;
            this.rdcsıkkı.Location = new System.Drawing.Point(23, 192);
            this.rdcsıkkı.Name = "rdcsıkkı";
            this.rdcsıkkı.Size = new System.Drawing.Size(45, 24);
            this.rdcsıkkı.TabIndex = 14;
            this.rdcsıkkı.TabStop = true;
            this.rdcsıkkı.Text = "C";
            this.rdcsıkkı.UseVisualStyleBackColor = true;
            // 
            // rddsıkkı
            // 
            this.rddsıkkı.AutoSize = true;
            this.rddsıkkı.Location = new System.Drawing.Point(277, 192);
            this.rddsıkkı.Name = "rddsıkkı";
            this.rddsıkkı.Size = new System.Drawing.Size(46, 24);
            this.rddsıkkı.TabIndex = 15;
            this.rddsıkkı.TabStop = true;
            this.rddsıkkı.Text = "D";
            this.rddsıkkı.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 8000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 18;
            // 
            // sonrakibtn
            // 
            this.sonrakibtn.Location = new System.Drawing.Point(39, 264);
            this.sonrakibtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sonrakibtn.Name = "sonrakibtn";
            this.sonrakibtn.Size = new System.Drawing.Size(158, 60);
            this.sonrakibtn.TabIndex = 20;
            this.sonrakibtn.Text = "SONRAKİ SORU";
            this.sonrakibtn.UseVisualStyleBackColor = true;
            this.sonrakibtn.Click += new System.EventHandler(this.sonrakibtn_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(336, 59);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(240, 26);
            this.dateTimePicker1.TabIndex = 33;
            // 
            // grptest
            // 
            this.grptest.Controls.Add(this.geri);
            this.grptest.Controls.Add(this.btnılerı);
            this.grptest.Controls.Add(this.lblcumle);
            this.grptest.Controls.Add(this.sonrakibtn);
            this.grptest.Controls.Add(this.rdasıkkı);
            this.grptest.Controls.Add(this.button2);
            this.grptest.Controls.Add(this.rdbsıkkı);
            this.grptest.Controls.Add(this.label1);
            this.grptest.Controls.Add(this.rdcsıkkı);
            this.grptest.Controls.Add(this.rddsıkkı);
            this.grptest.Location = new System.Drawing.Point(12, 12);
            this.grptest.Name = "grptest";
            this.grptest.Size = new System.Drawing.Size(564, 463);
            this.grptest.TabIndex = 34;
            this.grptest.TabStop = false;
            this.grptest.Text = "KELİME TESTİ";
            // 
            // geri
            // 
            this.geri.BackColor = System.Drawing.Color.Transparent;
            this.geri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.geri.FlatAppearance.BorderSize = 0;
            this.geri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.geri.ForeColor = System.Drawing.Color.OldLace;
            this.geri.Image = global::Dictionary.Properties.Resources.back25;
            this.geri.Location = new System.Drawing.Point(22, 15);
            this.geri.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.geri.Name = "geri";
            this.geri.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.geri.Size = new System.Drawing.Size(44, 49);
            this.geri.TabIndex = 32;
            this.geri.UseVisualStyleBackColor = false;
            this.geri.Click += new System.EventHandler(this.Geri_Click);
            // 
            // button2
            // 
            this.button2.Image = global::Dictionary.Properties.Resources.ANSWER;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(277, 264);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 58);
            this.button2.TabIndex = 19;
            this.button2.Text = "        CEVAPLA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // testetme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 487);
            this.Controls.Add(this.grptest);
            this.Controls.Add(this.dateTimePicker1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "testetme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Testetme_Load);
            this.grptest.ResumeLayout(false);
            this.grptest.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnılerı;
        private System.Windows.Forms.Label lblcumle;
        private System.Windows.Forms.RadioButton rdasıkkı;
        private System.Windows.Forms.RadioButton rdbsıkkı;
        private System.Windows.Forms.RadioButton rdcsıkkı;
        private System.Windows.Forms.RadioButton rddsıkkı;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button sonrakibtn;
        private System.Windows.Forms.Timer timer2;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button geri;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox grptest;
    }
}
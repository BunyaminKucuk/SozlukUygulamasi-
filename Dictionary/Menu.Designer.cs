namespace Dictionary
{
    partial class Menu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IngilziceAnlami = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TurkceAnlami = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IKelimeTuru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KelimeTuru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cumle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eklebtn = new System.Windows.Forms.Button();
            this.silbtn = new System.Windows.Forms.Button();
            this.guncellebtn = new System.Windows.Forms.Button();
            this.aratxt = new System.Windows.Forms.TextBox();
            this.arabtn = new System.Windows.Forms.Button();
            this.verigetirbtn = new System.Windows.Forms.Button();
            this.ogren = new System.Windows.Forms.Button();
            this.inglizcetxt = new System.Windows.Forms.TextBox();
            this.idtut = new System.Windows.Forms.TextBox();
            this.geri = new System.Windows.Forms.Button();
            this.cikis = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.grpanasayfa = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpanasayfa.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(282, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aranacak Kelime";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Red;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.IngilziceAnlami,
            this.TurkceAnlami,
            this.IKelimeTuru,
            this.KelimeTuru,
            this.Cumle});
            this.dataGridView1.Location = new System.Drawing.Point(232, 123);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(758, 369);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.DataGridView1_SelectionChanged);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // IngilziceAnlami
            // 
            this.IngilziceAnlami.DataPropertyName = "IngilziceAnlami";
            this.IngilziceAnlami.HeaderText = "İngilizce karşılığı";
            this.IngilziceAnlami.Name = "IngilziceAnlami";
            // 
            // TurkceAnlami
            // 
            this.TurkceAnlami.DataPropertyName = "TurkceAnlami";
            this.TurkceAnlami.HeaderText = "Türkçe ";
            this.TurkceAnlami.Name = "TurkceAnlami";
            // 
            // IKelimeTuru
            // 
            this.IKelimeTuru.DataPropertyName = "IKelimeTuru";
            this.IKelimeTuru.HeaderText = "word type";
            this.IKelimeTuru.Name = "IKelimeTuru";
            // 
            // KelimeTuru
            // 
            this.KelimeTuru.DataPropertyName = "KelimeTuru";
            this.KelimeTuru.HeaderText = "Kelime Türü";
            this.KelimeTuru.Name = "KelimeTuru";
            // 
            // Cumle
            // 
            this.Cumle.DataPropertyName = "Cumle";
            this.Cumle.HeaderText = "Kelime ile ilgili cümle";
            this.Cumle.Name = "Cumle";
            // 
            // eklebtn
            // 
            this.eklebtn.Image = global::Dictionary.Properties.Resources.add2;
            this.eklebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eklebtn.Location = new System.Drawing.Point(37, 123);
            this.eklebtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.eklebtn.Name = "eklebtn";
            this.eklebtn.Size = new System.Drawing.Size(182, 62);
            this.eklebtn.TabIndex = 5;
            this.eklebtn.Text = "KELİME\r\nEKLEME";
            this.eklebtn.UseVisualStyleBackColor = true;
            this.eklebtn.Click += new System.EventHandler(this.Eklebtn_Click);
            // 
            // silbtn
            // 
            this.silbtn.Image = global::Dictionary.Properties.Resources.delete1;
            this.silbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.silbtn.Location = new System.Drawing.Point(37, 195);
            this.silbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.silbtn.Name = "silbtn";
            this.silbtn.Size = new System.Drawing.Size(182, 62);
            this.silbtn.TabIndex = 6;
            this.silbtn.Text = "    KELİMEYİ SİL";
            this.silbtn.UseVisualStyleBackColor = true;
            this.silbtn.Click += new System.EventHandler(this.Silbtn_Click);
            // 
            // guncellebtn
            // 
            this.guncellebtn.Image = global::Dictionary.Properties.Resources.update2;
            this.guncellebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.guncellebtn.Location = new System.Drawing.Point(37, 267);
            this.guncellebtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guncellebtn.Name = "guncellebtn";
            this.guncellebtn.Size = new System.Drawing.Size(182, 62);
            this.guncellebtn.TabIndex = 7;
            this.guncellebtn.Text = "     KELİMEYİ \r\n     GÜNCELLE";
            this.guncellebtn.UseVisualStyleBackColor = true;
            this.guncellebtn.Click += new System.EventHandler(this.Guncellebtn_Click);
            // 
            // aratxt
            // 
            this.aratxt.Location = new System.Drawing.Point(418, 72);
            this.aratxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.aratxt.Name = "aratxt";
            this.aratxt.Size = new System.Drawing.Size(224, 26);
            this.aratxt.TabIndex = 8;
            // 
            // arabtn
            // 
            this.arabtn.Image = global::Dictionary.Properties.Resources.search;
            this.arabtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.arabtn.Location = new System.Drawing.Point(676, 51);
            this.arabtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.arabtn.Name = "arabtn";
            this.arabtn.Size = new System.Drawing.Size(153, 62);
            this.arabtn.TabIndex = 9;
            this.arabtn.Text = "ARA";
            this.arabtn.UseVisualStyleBackColor = true;
            this.arabtn.Click += new System.EventHandler(this.Arabtn_Click);
            // 
            // verigetirbtn
            // 
            this.verigetirbtn.Image = global::Dictionary.Properties.Resources.clean;
            this.verigetirbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.verigetirbtn.Location = new System.Drawing.Point(837, 51);
            this.verigetirbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.verigetirbtn.Name = "verigetirbtn";
            this.verigetirbtn.Size = new System.Drawing.Size(153, 62);
            this.verigetirbtn.TabIndex = 25;
            this.verigetirbtn.Text = "     TABLOYU\r\n      GETİR";
            this.verigetirbtn.UseVisualStyleBackColor = true;
            this.verigetirbtn.Click += new System.EventHandler(this.Verigetirbtn_Click);
            // 
            // ogren
            // 
            this.ogren.Image = global::Dictionary.Properties.Resources.LEARN;
            this.ogren.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ogren.Location = new System.Drawing.Point(37, 339);
            this.ogren.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ogren.Name = "ogren";
            this.ogren.Size = new System.Drawing.Size(182, 62);
            this.ogren.TabIndex = 28;
            this.ogren.Text = "      KELİME \r\n   ÖĞRENME";
            this.ogren.UseVisualStyleBackColor = true;
            this.ogren.Click += new System.EventHandler(this.Ogren_Click);
            // 
            // inglizcetxt
            // 
            this.inglizcetxt.Location = new System.Drawing.Point(76, 645);
            this.inglizcetxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inglizcetxt.Name = "inglizcetxt";
            this.inglizcetxt.Size = new System.Drawing.Size(14, 26);
            this.inglizcetxt.TabIndex = 30;
            this.inglizcetxt.Visible = false;
            // 
            // idtut
            // 
            this.idtut.Location = new System.Drawing.Point(18, 645);
            this.idtut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.idtut.Name = "idtut";
            this.idtut.Size = new System.Drawing.Size(25, 26);
            this.idtut.TabIndex = 10;
            this.idtut.Visible = false;
            // 
            // geri
            // 
            this.geri.BackColor = System.Drawing.Color.Transparent;
            this.geri.BackgroundImage = global::Dictionary.Properties.Resources.back26;
            this.geri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.geri.FlatAppearance.BorderSize = 0;
            this.geri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.geri.ForeColor = System.Drawing.Color.OldLace;
            this.geri.Location = new System.Drawing.Point(24, 13);
            this.geri.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.geri.Name = "geri";
            this.geri.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.geri.Size = new System.Drawing.Size(44, 49);
            this.geri.TabIndex = 31;
            this.geri.UseVisualStyleBackColor = false;
            this.geri.Click += new System.EventHandler(this.Geri_Click);
            // 
            // cikis
            // 
            this.cikis.BackColor = System.Drawing.Color.Transparent;
            this.cikis.BackgroundImage = global::Dictionary.Properties.Resources.closing1;
            this.cikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cikis.FlatAppearance.BorderSize = 0;
            this.cikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikis.ForeColor = System.Drawing.Color.OldLace;
            this.cikis.Location = new System.Drawing.Point(986, 13);
            this.cikis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cikis.Name = "cikis";
            this.cikis.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cikis.Size = new System.Drawing.Size(44, 49);
            this.cikis.TabIndex = 33;
            this.cikis.UseVisualStyleBackColor = false;
            this.cikis.Click += new System.EventHandler(this.Cikis_Click);
            // 
            // button1
            // 
            this.button1.Image = global::Dictionary.Properties.Resources.columnchart;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(37, 411);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 62);
            this.button1.TabIndex = 34;
            this.button1.Text = "      KELİME \r\n     GRAFİĞİ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // grpanasayfa
            // 
            this.grpanasayfa.BackColor = System.Drawing.Color.Transparent;
            this.grpanasayfa.Controls.Add(this.aratxt);
            this.grpanasayfa.Controls.Add(this.button1);
            this.grpanasayfa.Controls.Add(this.label1);
            this.grpanasayfa.Controls.Add(this.dataGridView1);
            this.grpanasayfa.Controls.Add(this.eklebtn);
            this.grpanasayfa.Controls.Add(this.silbtn);
            this.grpanasayfa.Controls.Add(this.ogren);
            this.grpanasayfa.Controls.Add(this.guncellebtn);
            this.grpanasayfa.Controls.Add(this.verigetirbtn);
            this.grpanasayfa.Controls.Add(this.arabtn);
            this.grpanasayfa.Location = new System.Drawing.Point(24, 70);
            this.grpanasayfa.Name = "grpanasayfa";
            this.grpanasayfa.Size = new System.Drawing.Size(1006, 511);
            this.grpanasayfa.TabIndex = 35;
            this.grpanasayfa.TabStop = false;
            this.grpanasayfa.Text = "ANA SAYFA";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::Dictionary.Properties.Resources.kitap;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1056, 596);
            this.ControlBox = false;
            this.Controls.Add(this.grpanasayfa);
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.geri);
            this.Controls.Add(this.inglizcetxt);
            this.Controls.Add(this.idtut);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpanasayfa.ResumeLayout(false);
            this.grpanasayfa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button eklebtn;
        private System.Windows.Forms.Button silbtn;
        private System.Windows.Forms.Button guncellebtn;
        private System.Windows.Forms.TextBox aratxt;
        private System.Windows.Forms.Button arabtn;
        private System.Windows.Forms.Button verigetirbtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IngilziceAnlami;
        private System.Windows.Forms.DataGridViewTextBoxColumn TurkceAnlami;
        private System.Windows.Forms.DataGridViewTextBoxColumn IKelimeTuru;
        private System.Windows.Forms.DataGridViewTextBoxColumn KelimeTuru;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cumle;
        private System.Windows.Forms.Button ogren;
        private System.Windows.Forms.TextBox inglizcetxt;
        private System.Windows.Forms.TextBox idtut;
        private System.Windows.Forms.Button geri;
        private System.Windows.Forms.Button cikis;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grpanasayfa;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Dictionary
{
    public partial class ogrenme : Form
    {
        
        public DateTime girisTarihi { set; get; }
        public string tut_ing { set; get; }
        public string tut_turk { set; get; }
        public int say { set; get; }

        public int sayac(int c)
        {
            say = c;
            return say;
        }
        public string ing(string a)
        {
            tut_ing = a;
            return tut_ing;
        }
        public string turk(string b)
        {
            tut_turk = b;
            return tut_turk;
        }
        public ogrenme()
        {
            InitializeComponent();
        }
        
        private void Cevaplabtn_Click(object sender, EventArgs e)
        {
            sayacIslemleri sayac = new sayacIslemleri();
            testetme frm = new testetme();

            girisTarihi = Convert.ToDateTime(dateTimePicker1.Value);

            if (textBox1.Text==tut_turk)
            {
                MessageBox.Show("Doğru bildiniz.","TEBRİKLER",MessageBoxButtons.OK,MessageBoxIcon.Information);
                sayac.sayacArtır(say, tut_turk, tut_ing, girisTarihi);
            }
            else
            {
                MessageBox.Show("Soruyu bilemediniz program yeniden baslatılacak bildirim yeniden ayarlanacak!","ÜZGÜNÜZ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Hide();
        }
        
        private void Ogrenme_Load(object sender, EventArgs e)
        {
            label2.Text = "'"+tut_ing+"'" + "  Kelimenin türkçecisini nedir?";
        }
    }
}

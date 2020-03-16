using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary
{
    public partial class kelimeGüncellemeFrm : Form
    {
        public kelimeGüncellemeFrm()
        {
            InitializeComponent();
        }

        private void Temizlebtn_Click(object sender, EventArgs e)
        {
            turkcetxt.Text = "";
            inglizcetxt.Text = "";
            Turkceturucbx.Text = "";
            Ingilizceturucbx.Text = "";
            cumletxt.Text = "";
        }

        private void Geri_Click(object sender, EventArgs e)
        {
            Menu geri = new Menu();
            geri.Show();
            this.Hide();
        }

        private void Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Guncellebtn_Click(object sender, EventArgs e)
        {
            yeniKelime kelime = new yeniKelime();
            kelime.KelimeGuncelle(turkcetxt.Text, inglizcetxt.Text, Turkceturucbx.Text, Ingilizceturucbx.Text, cumletxt.Text, groupBox1,comboBox1.Text);
        }
       
        //comoboxa kelime ekleme
        private void KelimeGüncellemeFrm_Load(object sender, EventArgs e)
        {
            dataBase db = new dataBase();
            db.baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kelimeler ", db.baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while(oku.Read())
            {
                comboBox1.Items.Add(oku["IngilziceAnlami"]); 
            }
            db.baglanti.Close();
         }
    }
}

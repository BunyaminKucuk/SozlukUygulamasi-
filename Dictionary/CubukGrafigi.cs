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
    public partial class CubukGrafigi : Form
    {
        public CubukGrafigi()
        {
            InitializeComponent();
        }
        dataBase db = new dataBase();
        private void CubukGrafigi_Load(object sender, EventArgs e)
        {
            try
            {
                db.baglanti.Open();
                SqlCommand komut = new SqlCommand("select Sayac,Ingilizcesi from ogrenilmisKelimeler", db.baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                while(oku.Read())
                {

                    grafig.Series["Kelimeler"].Points.AddXY(oku[1].ToString() , oku[0].ToString());
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("" + hata);
            }
            finally
            {
                db.baglanti.Close();
            }
        }

        private void Geribtn_Click(object sender, EventArgs e)
        {
            Menu mn = new Menu();
            mn.Show();
            this.Hide();
        }
    }
}

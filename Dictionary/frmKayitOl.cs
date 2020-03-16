using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary
{
    public partial class frmKayitOl : Form
    {
        public frmKayitOl()
        {
            InitializeComponent();
        }
    
        private void Kayitol_Click(object sender, EventArgs e)
        {
            musteriKayitOl kayiti = new musteriKayitOl();
            kayiti.kayitOl(txtAdSoyad.Text, txtKulAdi.Text, txtSifre.Text, txtTekrar.Text, txtSoru.Text, txtCevap.Text, grpkayıtol);
        }

        private void Geri_Click(object sender, EventArgs e)
        {
            Form1 FRM = new Form1();
            FRM.Show();
            this.Hide();
        }
    }
}

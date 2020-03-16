using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//IngilziceAnlami
namespace Dictionary
{
    public partial class Menu : Form
    {
        string Türkçe;
        public Menu()
        {
            InitializeComponent();
        }
      

        private void Menu_Load(object sender, EventArgs e)
        {
            kelimeIslemleri me = new kelimeIslemleri();
            dataGridView1.DataSource = me.tablola();
        }
       
        private void Eklebtn_Click(object sender, EventArgs e)
        {
            kelimeEkle ekle = new kelimeEkle();
            ekle.Show();
            this.Hide();
        }

        private void Silbtn_Click(object sender, EventArgs e)
        {
           
            kelimeIslemleri sil = new kelimeIslemleri();
            sil.kelimeSil(Türkçe);
            dataGridView1.DataSource = sil.tablola();
            MessageBox.Show(inglizcetxt.Text +" "+ " kelimesi sözlükten silinmiştir...");

            
        }

        
        private void Arabtn_Click(object sender, EventArgs e)
        {
            kelimeIslemleri islem = new kelimeIslemleri();
            dataGridView1.DataSource = islem.araYap(aratxt.Text);
        }

        private void Guncellebtn_Click(object sender, EventArgs e)
        {
            kelimeGüncellemeFrm güncelle = new kelimeGüncellemeFrm();
            güncelle.Show();
            this.Hide();
        }

      

        private void Verigetirbtn_Click(object sender, EventArgs e)
        {
            kelimeIslemleri getir = new kelimeIslemleri();
            dataGridView1.DataSource = getir.tablola();
        }


        

        private void Ogren_Click(object sender, EventArgs e)
        {
            //timer1.Start();
            testetme frm = new testetme();
            frm.Show();
            this.Hide();
            
        }
        
        private void Geri_Click(object sender, EventArgs e)
        {
            Form1 geri = new Form1();
            geri.Show();
            this.Hide();
        }

        private void Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            CubukGrafigi graf = new CubukGrafigi();
            graf.Show();
            this.Hide();
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

                Türkçe = Convert.ToString(selectedRow.Cells["TurkceAnlami"].Value);

               
            }
         
        }
    }
}

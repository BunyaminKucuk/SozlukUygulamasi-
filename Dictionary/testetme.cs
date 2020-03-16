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
using System.Collections;

namespace Dictionary
{

    public partial class testetme : Form
    { public testetme()
        {
            InitializeComponent();
        }
        dataBase db = new dataBase();
        public string tut { set; get; }
        public string tut_ing { set; get; }
        public string kelimeTr { set; get; }
        public string kelimeIng { set; get; }
        public int secim_tut { get; set; }
        public int konroltut { set; get; }
        private void Testetme_Load(object sender, EventArgs e)
        {
          // dateTimePicker1.Value = Convert.ToDateTime(DateTime.Now.ToLongDateString());
            timer1.Start();
            label1.Visible = false;
            sonrakibtn.Visible = false;
            rdasıkkı.Visible = false;
            rdbsıkkı.Visible = false;
            rdcsıkkı.Visible = false;
            rddsıkkı.Visible = false;
            button2.Visible = false;
            lblcumle.Visible = false;
            sonrakibtn.Text = "Bilgilendirmeyi Geç";
            db.baglanti.Open();
            SqlCommand komutb = new SqlCommand("select top 1 TurkceAnlami from kelimeler order by NEWID()", db.baglanti);
            SqlDataReader okub = komutb.ExecuteReader();

            if (okub.Read())
            {
                kelimeTr = okub["TurkceAnlami"].ToString();
            }
            okub.Close();
            komutb.Dispose();
            SqlCommand ing = new SqlCommand("select IngilziceAnlami from kelimeler where TurkceAnlami=@TurkceAnlami", db.baglanti);
            ing.Parameters.AddWithValue("TurkceAnlami", kelimeTr);
            ing.ExecuteNonQuery();
            SqlDataReader ing_oku = ing.ExecuteReader();

            if (ing_oku.Read())
            {
                kelimeIng = ing_oku["IngilziceAnlami"].ToString();


            }
            ing_oku.Close();
            db.baglanti.Close();

        }
        private void Btnılerı_Click(object sender, EventArgs e)
        {
            lblcumle.Visible = true;
            rdasıkkı.Visible = true;
            rdbsıkkı.Visible = true;
            rdcsıkkı.Visible = true;
            rddsıkkı.Visible = true;
            button2.Visible = true;
            sonrakibtn.Visible = true;
            btnılerı.Visible = false;
            label1.Visible = true;
            label1.Text = "Testimiz 4 şıklı olup sadece bilginizi ölçmek için yapılmıştır.Başarılar.";
            lblcumle.Text = "Bilgilendirme";
        }
       
        private int sayac = 0;
       
        private void Timer1_Tick(object sender, EventArgs e)
        {
            timer2.Start();
        }
        Menu mn = new Menu();
       
        public int secim()
        {
            Random rnd = new Random();
            int sayi = rnd.Next(1, 4);
            return sayi;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (rdasıkkı.Checked == false && rdbsıkkı.Checked == false && rdcsıkkı.Checked == false && rddsıkkı.Checked == false)
            {
                MessageBox.Show("Lütfen bir şık seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (rdasıkkı.Checked == true)
                {
                    if (rdasıkkı.Text == tut_ing.ToString())
                    {
                        MessageBox.Show("Doğru yanıtladınız");
                        SayacKontrol(rdasıkkı.Text);

                    }
                    else
                    {
                        MessageBox.Show("Yanlış cevapladınız");
                    }
                }
                else if (rdbsıkkı.Checked == true)
                {
                    if (rdbsıkkı.Text == tut_ing.ToString())
                    {
                        MessageBox.Show("Doğru yanıtladınız");
                        SayacKontrol(rdbsıkkı.Text);

                    }
                    else
                    {
                        MessageBox.Show("Yanlış cevapladınız");
                    }
                }
                else if (rdcsıkkı.Checked == true)
                {
                    if (rdcsıkkı.Text == tut_ing.ToString())
                    {
                        MessageBox.Show("Doğru yanıtladınız");
                        SayacKontrol(rdcsıkkı.Text);

                    }
                    else
                    {
                        MessageBox.Show("Yanlış cevapladınız");
                    }
                }
                else
                {
                    if (rddsıkkı.Text == tut_ing.ToString())
                    {
                        MessageBox.Show("Doğru yanıtladınız");
                        SayacKontrol(rddsıkkı.Text);

                    }
                    else
                    {
                        MessageBox.Show("Yanlış cevapladız");
                    }
                }
            }

        }


        private void SayacKontrol(string INGKelime)
        {
            db.baglanti.Open();
            SqlCommand cmd = new SqlCommand("SELECT Sayac from kelimeler where trim(IngilziceAnlami)=@p1 ", db.baglanti);
            cmd.Parameters.AddWithValue("@p1", INGKelime.ToLower());
            SqlDataReader dr = cmd.ExecuteReader();

            int sayi = -1;

            while (dr.Read())
            {
                sayi = Convert.ToInt16(dr[0]);
            }
            db.baglanti.Close();



            if (sayi + 1 != 4) //4 kere bilmediyse sayıyı +1 yapacak şekilde güncelle
            {
                db.baglanti.Open();
                SqlCommand cmd1 = new SqlCommand("UPDATE kelimeler SET Sayac=@p1 where trim(IngilziceAnlami)=@p2", db.baglanti);
                cmd1.Parameters.AddWithValue("@p1", sayi + 1);
                cmd1.Parameters.AddWithValue("@p2", INGKelime.ToLower());
                cmd1.ExecuteNonQuery();
            }
            else // 4 kere bildiyse tablolar arası geçiş yap
            {
                TablodanTabloyaGeçiş(INGKelime.ToLower());
            }
            db.baglanti.Close();

        }


        private void TablodanTabloyaGeçiş(string INGKelime)
        {

            db.baglanti.Open();
            SqlCommand cmd = new SqlCommand("SELECT TurkceAnlami from kelimeler where trim(IngilziceAnlami)=@p1 ", db.baglanti); //kelimenin ingilizcesini al
            cmd.Parameters.AddWithValue("@p1", INGKelime.ToLower());
            SqlDataReader dr = cmd.ExecuteReader();
            string TR = "";

            while (dr.Read())
            {
                TR = dr[0].ToString().Trim();
            }
            db.baglanti.Close();
            db.baglanti.Open();

            SqlCommand cmd1 = new SqlCommand("DELETE kelimeler where trim(IngilziceAnlami)=@p1", db.baglanti); //Öncekinden sil
            cmd1.Parameters.AddWithValue("@p1", INGKelime.ToLower());
            cmd1.ExecuteNonQuery();

            db.baglanti.Close();
            db.baglanti.Open();

            SqlCommand cmd2 = new SqlCommand("INSERT INTO ogrenilmisKelimeler(Turkcesi,Ingilizcesi,Sayac,Tarih) VALUES('" + TR + "','" + INGKelime + "','"+4+"','"+DateTime.Now.ToString()+"')", db.baglanti); //sonrakine ekle
            cmd2.ExecuteNonQuery();
            cmd2.Dispose();


        }


        private void sonrakibtn_Click(object sender, EventArgs e)
        {
            
            lblcumle.Text = "Soru:";
            sonrakibtn.Text = "Sonraki Soru";
            if (db.baglanti.State == System.Data.ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand komut = new SqlCommand("select top 4 IngilziceAnlami from kelimeler order by NEWID() ", db.baglanti);
                SqlDataReader oku = komut.ExecuteReader();

                List<string> dizi = new List<string>();
                while (oku.Read())
                {
                    dizi.Add(oku["IngilziceAnlami"].ToString());
                }
                rdasıkkı.Text = dizi[0].ToString();
                rdbsıkkı.Text = dizi[1].ToString();
                rdcsıkkı.Text = dizi[2].ToString();
                rddsıkkı.Text = dizi[3].ToString();
                oku.Close();
                komut.Dispose();
                SqlCommand komutb = new SqlCommand("select top 1 TurkceAnlami from kelimeler order by NEWID()", db.baglanti);
                SqlDataReader okub = komutb.ExecuteReader();

                if (okub.Read())
                {
                    tut = okub["TurkceAnlami"].ToString();
                }
                okub.Close();
                komutb.Dispose();
                SqlCommand ing = new SqlCommand("select IngilziceAnlami from kelimeler where TurkceAnlami=@TurkceAnlami", db.baglanti);
                ing.Parameters.AddWithValue("TurkceAnlami", tut);
                ing.ExecuteNonQuery();
                SqlDataReader ing_oku = ing.ExecuteReader();

                if (ing_oku.Read())
                {
                    tut_ing = ing_oku["IngilziceAnlami"].ToString();
                  
                
                }
                ing_oku.Close();
                secim_tut = secim();

                if (secim_tut == 1)
                {
                    rdasıkkı.Text = tut_ing.ToString();
                }
                else if (secim_tut == 2)
                {
                    rdbsıkkı.Text = tut_ing.ToString();
                }
                else if (secim_tut == 3)
                {
                    rdcsıkkı.Text = tut_ing.ToString();
                }
                else
                {
                    rddsıkkı.Text = tut_ing.ToString();
                }
                if (rdasıkkı.Text == rdbsıkkı.Text || rdasıkkı.Text == rdcsıkkı.Text || rdasıkkı.Text == rddsıkkı.Text)
                {
                    SqlCommand komuta = new SqlCommand("select top 1 IngilziceAnlami from kelimeler order by NEWID() ", db.baglanti);
                    SqlDataReader okua = komut.ExecuteReader();
                    if (okua.Read())
                    {
                        rdasıkkı.Text = okua["IngilziceAnlami"].ToString();
                    }

                    komuta.Dispose();
                    okua.Close();
                }
                if (rdbsıkkı.Text == rdasıkkı.Text || rdbsıkkı.Text == rdcsıkkı.Text || rdbsıkkı.Text == rddsıkkı.Text)
                {
                    SqlCommand komutc = new SqlCommand("select top 1 IngilziceAnlami from kelimeler order by NEWID() ", db.baglanti);
                    SqlDataReader okuc = komut.ExecuteReader();
                    if (okuc.Read())
                    {
                        rdbsıkkı.Text = okuc["IngilziceAnlami"].ToString();
                    }
                    komutc.Dispose();
                    okuc.Close();
                }
                if (rdcsıkkı.Text == rdbsıkkı.Text || rdcsıkkı.Text == rdasıkkı.Text || rdcsıkkı.Text == rddsıkkı.Text)
                {
                    SqlCommand komutd = new SqlCommand("select top 1 IngilziceAnlami from kelimeler order by NEWID() ", db.baglanti);
                    SqlDataReader okud = komut.ExecuteReader();
                    if (okud.Read())
                    {
                        rdcsıkkı.Text = okud["IngilziceAnlami"].ToString();
                    }
                    komutd.Dispose();
                    okud.Close();
                }
                if (rddsıkkı.Text == rdbsıkkı.Text || rddsıkkı.Text == rdasıkkı.Text || rddsıkkı.Text == rdcsıkkı.Text)
                {
                    SqlCommand komutf = new SqlCommand("select top 1 IngilziceAnlami from kelimeler order by NEWID() ", db.baglanti);
                    SqlDataReader okuf = komut.ExecuteReader();
                    if (okuf.Read())
                    {
                        rddsıkkı.Text = okuf["IngilziceAnlami"].ToString();
                    }
                    komutf.Dispose();
                    okuf.Close();
                }
                label1.Text = "Bu kelimenin İngilizce karşılığını şeçiniz-->" + tut.ToString();
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
        private void Button3_Click(object sender, EventArgs e)
        {
            timer2.Start();

        }
        public DialogResult ask;
        private void Timer2_Tick(object sender, EventArgs e)
        {
            
            while (sayac<4)
            {
                ogrenme ogr = new ogrenme();
                sayac++;
                timer2.Interval += 10000;
                ask = MessageBox.Show("Ögrendiğiniz kelimeleri görmek istermsiniz?", "Hatırlatma", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (ask==DialogResult.Yes)
                {
                    ogr.turk(kelimeTr);
                    ogr.ing(kelimeIng);
                    ogr.sayac(sayac);
                    ogr.Show();
                    break;             
                }
                else
                {
                    timer2.Stop();
                    timer2.Stop();
                    timer1.Stop();
                    break;
                }
            } 
            
        }

        private void Geri_Click(object sender, EventArgs e)
        {
            mn.Show();
            this.Hide();
        }
    }
}

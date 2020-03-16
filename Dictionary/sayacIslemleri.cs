using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Dictionary
{
    class sayacIslemleri
    {
        dataBase db = new dataBase();

        public int sayackontol { set; get; }
        public string takas { set; get; }
        public void sayacArtır(int sayac, string turkcesi, string ingilizce, DateTime tarih)
        {

            if (db.baglanti.State == System.Data.ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand ing = new SqlCommand("select Sayac from kelimeler where TurkceAnlami=@TurkceAnlami", db.baglanti);
                ing.Parameters.AddWithValue("@TurkceAnlami", turkcesi);
                ing.ExecuteNonQuery();
                SqlDataReader say_oku = ing.ExecuteReader();

                if (say_oku.Read())
                {
                    //kelimeIng = ing_oku["IngilziceAnlami"].ToString();
                    takas = say_oku["Sayac"].ToString();
                    sayackontol = int.Parse(takas);
                    sayackontol += 1;
                    SqlCommand sayacGuncelle = new SqlCommand("update kelimeler set Sayac=@Sayac where TurkceAnlami=@TurkceAnlami", db.baglanti);
                    sayacGuncelle.Parameters.AddWithValue("@Sayac", sayackontol.ToString());
                    sayacGuncelle.Parameters.AddWithValue("@TurkceAnlami", turkcesi);
                    sayacGuncelle.ExecuteNonQuery();
                 
                }
                    if (sayackontol == 4)
                    {
                        SqlCommand artır = new SqlCommand("insert into ogrenilmisKelimeler values (@Turkcesi,@Ingilizcesi,@Sayac,@Tarih)", db.baglanti);
                        artır.Parameters.AddWithValue("@Sayac", sayac.ToString());
                        artır.Parameters.AddWithValue("@Turkcesi", turkcesi);
                        artır.Parameters.AddWithValue("@Ingilizcesi", ingilizce);
                        artır.Parameters.AddWithValue("@Tarih", tarih);
                        artır.ExecuteNonQuery();
                        artır.Dispose();
                    }
                    else
                    {
                       SqlCommand sayacGuncelle1 = new SqlCommand("update ogrenilmisKelimeler set Sayac=@Sayac where Turkcesi=@Turkcesi", db.baglanti);
                       sayacGuncelle1.Parameters.AddWithValue("@Sayac", sayackontol.ToString());
                       sayacGuncelle1.Parameters.AddWithValue("@Turkcesi", turkcesi);
                       sayacGuncelle1.ExecuteNonQuery();
                    }
            }
            catch(Exception hata)
            {
                MessageBox.Show(""+hata);
            }
            finally
            {
                db.baglanti.Close();
            }
        }
    }
}

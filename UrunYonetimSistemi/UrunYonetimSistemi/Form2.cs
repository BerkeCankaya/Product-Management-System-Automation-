using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UrunYonetimSistemi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        static string conString = "Data Source=DESKTOP-H1TC8F9\\SQLEXPRESS;Initial Catalog = UrunYonetimSistemi; Integrated Security = True;";
        SqlConnection connect = new SqlConnection(conString);
        private void button1_Click(object sender, EventArgs e)
        {

            if (txt_ad.Text == "" || txt_soyad.Text == "" || txt_email.Text == "" || txt_kadi.Text == "" || txt_sifre.Text == "" || !txt_email.Text.Contains("@"))
                {
                  MessageBox.Show("Lütfen Tüm Alanları Doldurunuz! ya da Emailde '@' İşaretini kullanın");
                }
              else
              {

                  try
                  {
                      if (connect.State == ConnectionState.Closed)
                          connect.Open();
                      string kayit = "insert into Kullanicilar (kullanici_adi,kullanici_soyadi,kullanici_email,kullanici_kadi,kullanici_sifre) values(@kullanici_ad,@kullanici_soyad,@kullanici_email,@kullanici_kadi,@kullanici_sifre)";
                      SqlCommand komut = new SqlCommand(kayit, connect);

                      komut.Parameters.AddWithValue("@kullanici_ad", txt_ad.Text);
                      komut.Parameters.AddWithValue("@kullanici_soyad", txt_soyad.Text);
                      komut.Parameters.AddWithValue("@kullanici_email", txt_email.Text);
                      komut.Parameters.AddWithValue("@kullanici_kadi", txt_kadi.Text);
                      komut.Parameters.AddWithValue("@kullanici_sifre", txt_sifre.Text);

                      komut.ExecuteNonQuery();

                      connect.Close();
                      MessageBox.Show("Kayıt Başarıyla Eklendi");
                      this.Close();

                  }

                  catch
                  {
                      MessageBox.Show("Hata,İşlem Gerçekleşmedi");
                  }
                }
        }

      
    }   
}


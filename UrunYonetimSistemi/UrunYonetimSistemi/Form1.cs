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
using System.Security.Policy;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace UrunYonetimSistemi
{
    public partial class Form1 : Form
    {
        SqlDataReader dr;
        SqlConnection con;
        SqlCommand com;
        public Form1()
        {
            InitializeComponent();
        }
        static string constring = "Data Source=DESKTOP-H1TC8F9\\SQLEXPRESS;Initial Catalog = UrunYonetimSistemi; Integrated Security = True; Trust Server Certificate=True";

  
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kadi = txt_kadi.Text;
            string sifre = txt_sifre.Text;
            con = new SqlConnection("Data Source=DESKTOP-H1TC8F9\\SQLEXPRESS;Initial Catalog = UrunYonetimSistemi; Integrated Security = True;");
            com = new SqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText = "Select * From Kullanicilar Where kullanici_kadi='" + kadi +  "' And kullanici_sifre='" + sifre + "'";
            com.Parameters.AddWithValue("@kadi", kadi);
            com.Parameters.AddWithValue("@sifre", sifre);
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Tebrikler, Başarılı Giriş");
                con.Close();
                this.Hide();
                Form3 form3 = new Form3(kadi,sifre);
                form3.Show();
               
            }
            else
            {
                MessageBox.Show("Hatalı ad,soyad veya sifre");
            }
            con.Close();

           
            
        }
    }
}   


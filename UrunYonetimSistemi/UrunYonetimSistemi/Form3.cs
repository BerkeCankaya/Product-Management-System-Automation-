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

namespace UrunYonetimSistemi
{
    public partial class Form3 : Form
    {
        SqlDataReader dr;
        SqlConnection con;
        SqlCommand com;

        private string kullaniciAdi;
        private string kullaniciSoyadi;
        public Form3(string adi, string soyadi)
        {
            InitializeComponent();
            kullaniciAdi = adi;
            kullaniciSoyadi = soyadi;
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-H1TC8F9\\SQLEXPRESS;Initial Catalog = UrunYonetimSistemi; Integrated Security = True;");
        public void veriGosterUrun(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler , baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        public void veriGosterKategori(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Form3_Load(object sender, EventArgs e)
        {


            string query = "SELECT kullanici_adi, kullanici_soyadi FROM Kullanicilar WHERE kullanici_kadi = @kullaniciKadi";
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-H1TC8F9\\SQLEXPRESS;Initial Catalog=UrunYonetimSistemi;Integrated Security=True;"))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@kullaniciKadi", kullaniciAdi); 
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string ad = reader["kullanici_adi"].ToString();
                    string soyad = reader["kullanici_soyadi"].ToString();
                    lbl_kisi.Text = $"{ad} {soyad}";
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kategoriAdi = txt_kategoriAdi.Text;
            string connectionString = "Data Source=DESKTOP-H1TC8F9\\SQLEXPRESS;Initial Catalog=UrunYonetimSistemi;Integrated Security=True";

            if (!string.IsNullOrEmpty(kategoriAdi))
            {
               

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "INSERT INTO Kategori (kategori_adi) VALUES (@kategoriAdi)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@kategoriAdi", kategoriAdi);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Kategori başarıyla eklendi.");
                        txt_kategoriAdi.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Kategori eklenirken bir hata oluştu.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir kategori adı girin.");
            }

           
            DataTable dataTable = new DataTable();

            
            string queryString = "SELECT * FROM Kategori";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }

          
            dataGridView1.DataSource = dataTable;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string kategori_adi = txt_kategoriAdi.Text;

           
            if (!string.IsNullOrWhiteSpace(kategori_adi))
            {
                SqlCommand komut = new SqlCommand("DELETE FROM Kategori WHERE kategori_adi = @adi", baglanti);
                komut.Parameters.AddWithValue("@adi", kategori_adi);
                komut.ExecuteNonQuery();
                veriGosterKategori("SELECT * FROM Kategori");
                txt_kategoriAdi.Clear();
            }
            else
            {
                MessageBox.Show("Kategori adı girmediniz. Lütfen bir kategori adı girin.", "Hata");
            }

            baglanti.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            veriGosterUrun("Select * from Urunler");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            veriGosterKategori("Select * from Kategori");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM Urunler WHERE urun_adi LIKE '%" + txt_urunAra.Text + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            txt_urunAra.Clear();
            baglanti.Close();
        }

       

        private void UrnSil_Click(object sender, EventArgs e)
        {
          
            string urunId = txt_id.Text;

           
            if (!string.IsNullOrEmpty(urunId))
            {
                DialogResult result = MessageBox.Show("Bu ürünü silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("DELETE FROM Urunler WHERE urun_id = @urunId", baglanti);
                    komut.Parameters.AddWithValue("@urunId", urunId);
                    komut.ExecuteNonQuery();
                    veriGosterKategori("SELECT * FROM Urunler");
                    txt_id.Clear();
                }
                else{
                    MessageBox.Show("Ürün silme işlemi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Urun ID girmediniz. Lütfen bir Urun ID girin.", "Hata");
            }

            baglanti.Close();
        }

        private void urnEkle_Click(object sender, EventArgs e)
        {
            string urunAdi = txt_urunAdi.Text;
            string urunFiyati = txt_urunFiyati.Text;
            string urunStok = txt_urunStok.Text;
            string urunkatId =  txt_katid.Text;
            string connectionString = "Data Source=DESKTOP-H1TC8F9\\SQLEXPRESS;Initial Catalog=UrunYonetimSistemi;Integrated Security=True";

            if (!string.IsNullOrEmpty(urunAdi) && !string.IsNullOrEmpty(urunFiyati) && !string.IsNullOrEmpty(urunStok) && !string.IsNullOrEmpty(urunkatId))
            {


                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "INSERT INTO Urunler (urun_adi,fiyat,stok_miktari,kategori_id) VALUES (@urunAdi,@urunFiyati,@urunStok,@urunkatId)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@urunAdi", urunAdi);
                    cmd.Parameters.AddWithValue("@urunFiyati", urunFiyati);
                    cmd.Parameters.AddWithValue("@urunStok", urunStok);
                    cmd.Parameters.AddWithValue("@urunkatId", urunkatId);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Ürün başarıyla eklendi.");
                        txt_urunAdi.Clear();
                        txt_katid.Clear();
                        txt_urunFiyati.Clear();
                        txt_urunStok.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Ürün eklenirken bir hata oluştu.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen gerekli alanları doldurunuz.");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilialan = dataGridView1.SelectedCells[0].RowIndex;
            string Urunid = dataGridView1.Rows[secilialan].Cells[0].Value.ToString();
            string Urunad = dataGridView1.Rows[secilialan].Cells[1].Value.ToString();
            string UrunKatId = dataGridView1.Rows[secilialan].Cells[2].Value.ToString();
            string UrunFiyat = dataGridView1.Rows[secilialan].Cells[3].Value.ToString();
            string UrunStok = dataGridView1.Rows[secilialan].Cells[4].Value.ToString();

            txt_id.Text = Urunid;
            txt_urunAdi.Text = Urunad;
            txt_urunStok.Text = UrunStok;
            txt_urunFiyati.Text = UrunFiyat;
            txt_katid.Text = UrunKatId;
         

        }

        private void UrnGnclle_Click(object sender, EventArgs e)
        {
            
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            try
            {
                string query = "UPDATE Urunler SET urun_adi = @urun_adi, kategori_id = @kategori_id, fiyat = @fiyat, stok_miktari = @stok_miktari WHERE urun_id = @urun_id";
                using (SqlCommand komut = new SqlCommand(query, baglanti))
                {
                  
                    komut.Parameters.AddWithValue("@urun_id", int.Parse(txt_id.Text));
                    komut.Parameters.AddWithValue("@urun_adi", txt_urunAdi.Text);
                    komut.Parameters.AddWithValue("@kategori_id", int.Parse(txt_katid.Text));
                    komut.Parameters.AddWithValue("@fiyat", decimal.Parse(txt_urunFiyati.Text));
                    komut.Parameters.AddWithValue("@stok_miktari", int.Parse(txt_urunStok.Text));

                   
                    komut.ExecuteNonQuery();
                    txt_id.Clear();
                    txt_urunAdi.Clear();
                    txt_katid.Clear();
                    txt_urunFiyati.Clear();
                    txt_urunStok.Clear();
                }

                
                veriGosterUrun("SELECT * FROM Urunler");
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Girdiğiniz veriler doğru formatta değil: " + ex.Message, "Format Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Veritabanı hatası: " + ex.Message, "Veritabanı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
        }

       
    }
}


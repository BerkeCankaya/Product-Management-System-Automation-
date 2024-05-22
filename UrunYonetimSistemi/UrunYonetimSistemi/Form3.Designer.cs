namespace UrunYonetimSistemi
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_kisi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.urunYonetimSistemiDataSet1 = new UrunYonetimSistemi.UrunYonetimSistemiDataSet1();
            this.urunYonetimSistemiDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.urunYonetimSistemiDataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kategoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.urunYonetimSistemiDataSet = new UrunYonetimSistemi.UrunYonetimSistemiDataSet();
            this.kategoriTableAdapter = new UrunYonetimSistemi.UrunYonetimSistemiDataSetTableAdapters.KategoriTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_urunAdi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.UrnGnclle = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_urunAra = new System.Windows.Forms.TextBox();
            this.txt_urunFiyati = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_katid = new System.Windows.Forms.TextBox();
            this.UrnSil = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.urnEkle = new System.Windows.Forms.Button();
            this.txt_urunStok = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.kullanicilarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kullanicilarTableAdapter = new UrunYonetimSistemi.UrunYonetimSistemiDataSet1TableAdapters.KullanicilarTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_kategoriAdi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.urunYonetimSistemiDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunYonetimSistemiDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunYonetimSistemiDataSet1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunYonetimSistemiDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilarBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_kisi
            // 
            this.lbl_kisi.AutoSize = true;
            this.lbl_kisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kisi.ForeColor = System.Drawing.Color.White;
            this.lbl_kisi.Location = new System.Drawing.Point(25, 18);
            this.lbl_kisi.Name = "lbl_kisi";
            this.lbl_kisi.Size = new System.Drawing.Size(0, 24);
            this.lbl_kisi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(322, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Yönetim Sistemi Otomasyonu";
            // 
            // urunYonetimSistemiDataSet1
            // 
            this.urunYonetimSistemiDataSet1.DataSetName = "UrunYonetimSistemiDataSet1";
            this.urunYonetimSistemiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // urunYonetimSistemiDataSet1BindingSource
            // 
            this.urunYonetimSistemiDataSet1BindingSource.DataSource = this.urunYonetimSistemiDataSet1;
            this.urunYonetimSistemiDataSet1BindingSource.Position = 0;
            // 
            // urunYonetimSistemiDataSet1BindingSource1
            // 
            this.urunYonetimSistemiDataSet1BindingSource1.DataSource = this.urunYonetimSistemiDataSet1;
            this.urunYonetimSistemiDataSet1BindingSource1.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Teal;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(46, 367);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(594, 198);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // kategoriBindingSource
            // 
            this.kategoriBindingSource.DataMember = "Kategori";
            this.kategoriBindingSource.DataSource = this.urunYonetimSistemiDataSet;
            // 
            // urunYonetimSistemiDataSet
            // 
            this.urunYonetimSistemiDataSet.DataSetName = "UrunYonetimSistemiDataSet";
            this.urunYonetimSistemiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kategoriTableAdapter
            // 
            this.kategoriTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_urunAdi);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txt_id);
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.UrnGnclle);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_urunAra);
            this.groupBox2.Controls.Add(this.txt_urunFiyati);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_katid);
            this.groupBox2.Controls.Add(this.UrnSil);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.urnEkle);
            this.groupBox2.Controls.Add(this.txt_urunStok);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(680, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(405, 452);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürünler";
            // 
            // txt_urunAdi
            // 
            this.txt_urunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_urunAdi.Location = new System.Drawing.Point(124, 122);
            this.txt_urunAdi.Name = "txt_urunAdi";
            this.txt_urunAdi.Size = new System.Drawing.Size(100, 22);
            this.txt_urunAdi.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(21, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 18);
            this.label10.TabIndex = 12;
            this.label10.Text = "Kategori ID :";
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_id.Location = new System.Drawing.Point(121, 57);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(97, 22);
            this.txt_id.TabIndex = 6;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(140, 375);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(120, 39);
            this.button8.TabIndex = 14;
            this.button8.Text = "Ürün Ara";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // UrnGnclle
            // 
            this.UrnGnclle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.UrnGnclle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UrnGnclle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UrnGnclle.Location = new System.Drawing.Point(260, 214);
            this.UrnGnclle.Name = "UrnGnclle";
            this.UrnGnclle.Size = new System.Drawing.Size(108, 47);
            this.UrnGnclle.TabIndex = 14;
            this.UrnGnclle.Text = "Ürün Güncelle";
            this.UrnGnclle.UseVisualStyleBackColor = false;
            this.UrnGnclle.Click += new System.EventHandler(this.UrnGnclle_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(40, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 18);
            this.label9.TabIndex = 10;
            this.label9.Text = "Ürün ID :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(83, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Aranacak Ürün :";
            // 
            // txt_urunAra
            // 
            this.txt_urunAra.Location = new System.Drawing.Point(226, 327);
            this.txt_urunAra.Name = "txt_urunAra";
            this.txt_urunAra.Size = new System.Drawing.Size(97, 29);
            this.txt_urunAra.TabIndex = 13;
            // 
            // txt_urunFiyati
            // 
            this.txt_urunFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_urunFiyati.Location = new System.Drawing.Point(124, 214);
            this.txt_urunFiyati.Name = "txt_urunFiyati";
            this.txt_urunFiyati.Size = new System.Drawing.Size(100, 22);
            this.txt_urunFiyati.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(18, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Stok Miktarı :";
            // 
            // txt_katid
            // 
            this.txt_katid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_katid.Location = new System.Drawing.Point(124, 167);
            this.txt_katid.Name = "txt_katid";
            this.txt_katid.Size = new System.Drawing.Size(100, 22);
            this.txt_katid.TabIndex = 9;
            // 
            // UrnSil
            // 
            this.UrnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.UrnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UrnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UrnSil.Location = new System.Drawing.Point(260, 53);
            this.UrnSil.Name = "UrnSil";
            this.UrnSil.Size = new System.Drawing.Size(111, 33);
            this.UrnSil.TabIndex = 7;
            this.UrnSil.Text = "Ürün Sil";
            this.UrnSil.UseVisualStyleBackColor = false;
            this.UrnSil.Click += new System.EventHandler(this.UrnSil_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(25, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ürün Fiyatı :";
            // 
            // urnEkle
            // 
            this.urnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.urnEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.urnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urnEkle.Location = new System.Drawing.Point(260, 138);
            this.urnEkle.Name = "urnEkle";
            this.urnEkle.Size = new System.Drawing.Size(108, 47);
            this.urnEkle.TabIndex = 12;
            this.urnEkle.Text = "Ürün Ekle";
            this.urnEkle.UseVisualStyleBackColor = false;
            this.urnEkle.Click += new System.EventHandler(this.urnEkle_Click);
            // 
            // txt_urunStok
            // 
            this.txt_urunStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_urunStok.Location = new System.Drawing.Point(124, 260);
            this.txt_urunStok.Name = "txt_urunStok";
            this.txt_urunStok.Size = new System.Drawing.Size(100, 22);
            this.txt_urunStok.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(48, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(39, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ürün Adı :";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(481, 123);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(127, 59);
            this.button5.TabIndex = 4;
            this.button5.Text = "Ürünler";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(481, 216);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(127, 59);
            this.button6.TabIndex = 5;
            this.button6.Text = "Kategori";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // kullanicilarBindingSource
            // 
            this.kullanicilarBindingSource.DataMember = "Kullanicilar";
            this.kullanicilarBindingSource.DataSource = this.urunYonetimSistemiDataSet1BindingSource1;
            // 
            // kullanicilarTableAdapter
            // 
            this.kullanicilarTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(78, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kategori Adı :";
            // 
            // txt_kategoriAdi
            // 
            this.txt_kategoriAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kategoriAdi.Location = new System.Drawing.Point(187, 64);
            this.txt_kategoriAdi.Name = "txt_kategoriAdi";
            this.txt_kategoriAdi.Size = new System.Drawing.Size(100, 22);
            this.txt_kategoriAdi.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(27, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 59);
            this.button1.TabIndex = 2;
            this.button1.Text = "Kategori Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(212, 138);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 59);
            this.button4.TabIndex = 3;
            this.button4.Text = "Kategori Sil";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txt_kategoriAdi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(29, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 256);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kategori";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1119, 598);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_kisi);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.urunYonetimSistemiDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunYonetimSistemiDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunYonetimSistemiDataSet1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunYonetimSistemiDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilarBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_kisi;
        private System.Windows.Forms.Label label1;
        private UrunYonetimSistemiDataSet1 urunYonetimSistemiDataSet1;
        private System.Windows.Forms.BindingSource urunYonetimSistemiDataSet1BindingSource;
        private System.Windows.Forms.BindingSource urunYonetimSistemiDataSet1BindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private UrunYonetimSistemiDataSet urunYonetimSistemiDataSet;
        private System.Windows.Forms.BindingSource kategoriBindingSource;
        private UrunYonetimSistemiDataSetTableAdapters.KategoriTableAdapter kategoriTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button urnEkle;
        private System.Windows.Forms.TextBox txt_urunStok;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_urunFiyati;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_katid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.BindingSource kullanicilarBindingSource;
        private UrunYonetimSistemiDataSet1TableAdapters.KullanicilarTableAdapter kullanicilarTableAdapter;
        private System.Windows.Forms.Button UrnGnclle;
        private System.Windows.Forms.Button UrnSil;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_urunAra;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_urunAdi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_kategoriAdi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
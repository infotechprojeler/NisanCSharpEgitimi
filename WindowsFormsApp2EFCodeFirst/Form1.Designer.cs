namespace WindowsFormsApp2EFCodeFirst
{
    partial class Form1
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
            this.dgvUrunler = new System.Windows.Forms.DataGridView();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbKategoriler = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbDurum = new System.Windows.Forms.CheckBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtUrunAciklamasi = new System.Windows.Forms.RichTextBox();
            this.txtUrunStok = new System.Windows.Forms.TextBox();
            this.txtUrunFiyati = new System.Windows.Forms.TextBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUrunler
            // 
            this.dgvUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrunler.Location = new System.Drawing.Point(12, 52);
            this.dgvUrunler.Name = "dgvUrunler";
            this.dgvUrunler.RowHeadersWidth = 51;
            this.dgvUrunler.RowTemplate.Height = 24;
            this.dgvUrunler.Size = new System.Drawing.Size(713, 443);
            this.dgvUrunler.TabIndex = 1;
            this.dgvUrunler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUrunler_CellClick);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(186, 12);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 6;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(80, 12);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(100, 22);
            this.txtAra.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ürün Ara";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbKategoriler);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbDurum);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.txtUrunAciklamasi);
            this.groupBox1.Controls.Add(this.txtUrunStok);
            this.groupBox1.Controls.Add(this.txtUrunFiyati);
            this.groupBox1.Controls.Add(this.txtUrunAdi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(731, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 340);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Bilgileri";
            // 
            // cbKategoriler
            // 
            this.cbKategoriler.FormattingEnabled = true;
            this.cbKategoriler.Location = new System.Drawing.Point(137, 250);
            this.cbKategoriler.Name = "cbKategoriler";
            this.cbKategoriler.Size = new System.Drawing.Size(121, 24);
            this.cbKategoriler.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Kategori";
            // 
            // cbDurum
            // 
            this.cbDurum.AutoSize = true;
            this.cbDurum.Location = new System.Drawing.Point(137, 223);
            this.cbDurum.Name = "cbDurum";
            this.cbDurum.Size = new System.Drawing.Size(54, 20);
            this.cbDurum.TabIndex = 9;
            this.cbDurum.Text = "Aktif";
            this.cbDurum.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(224, 299);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(137, 300);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(80, 23);
            this.btnGuncelle.TabIndex = 7;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(55, 300);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtUrunAciklamasi
            // 
            this.txtUrunAciklamasi.Location = new System.Drawing.Point(137, 120);
            this.txtUrunAciklamasi.Name = "txtUrunAciklamasi";
            this.txtUrunAciklamasi.Size = new System.Drawing.Size(197, 96);
            this.txtUrunAciklamasi.TabIndex = 5;
            this.txtUrunAciklamasi.Text = "";
            // 
            // txtUrunStok
            // 
            this.txtUrunStok.Location = new System.Drawing.Point(137, 92);
            this.txtUrunStok.Name = "txtUrunStok";
            this.txtUrunStok.Size = new System.Drawing.Size(100, 22);
            this.txtUrunStok.TabIndex = 4;
            // 
            // txtUrunFiyati
            // 
            this.txtUrunFiyati.Location = new System.Drawing.Point(137, 64);
            this.txtUrunFiyati.Name = "txtUrunFiyati";
            this.txtUrunFiyati.Size = new System.Drawing.Size(100, 22);
            this.txtUrunFiyati.TabIndex = 4;
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(137, 36);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(100, 22);
            this.txtUrunAdi.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ürün Açıklaması";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ürün Stok";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ürün Fiyatı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ürün Adı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 531);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvUrunler);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUrunler;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbDurum;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.RichTextBox txtUrunAciklamasi;
        private System.Windows.Forms.TextBox txtUrunStok;
        private System.Windows.Forms.TextBox txtUrunFiyati;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbKategoriler;
        private System.Windows.Forms.Label label6;
    }
}


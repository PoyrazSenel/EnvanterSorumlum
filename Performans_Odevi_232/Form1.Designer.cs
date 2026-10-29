namespace Veri_Tabanis_Tekrars
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            btnListele = new Button();
            btnSil = new Button();
            btnGuncelle = new Button();
            btnEkle = new Button();
            txtSatisFiyati = new TextBox();
            txtBarkod = new TextBox();
            txtUrunAd = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            groupBox2 = new GroupBox();
            dataGridView2 = new DataGridView();
            btnIslem = new Button();
            txtMiktar = new TextBox();
            cbIslemTuru = new ComboBox();
            cbUrun = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            tabPage3 = new TabPage();
            btnRaporListele = new Button();
            dataGridView3 = new DataGridView();
            groupBox3 = new GroupBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(925, 483);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(917, 455);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Urun";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(btnListele);
            groupBox1.Controls.Add(btnSil);
            groupBox1.Controls.Add(btnGuncelle);
            groupBox1.Controls.Add(btnEkle);
            groupBox1.Controls.Add(txtSatisFiyati);
            groupBox1.Controls.Add(txtBarkod);
            groupBox1.Controls.Add(txtUrunAd);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(908, 443);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Yönetim Paneli";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 204);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(896, 224);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick_1;
            // 
            // btnListele
            // 
            btnListele.Location = new Point(787, 112);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(75, 23);
            btnListele.TabIndex = 12;
            btnListele.Text = "Listele";
            btnListele.UseVisualStyleBackColor = true;
            btnListele.Click += btnListele_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(542, 112);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 23);
            btnSil.TabIndex = 11;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click_1;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(283, 112);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(75, 23);
            btnGuncelle.TabIndex = 10;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click_1;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(66, 112);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(75, 23);
            btnEkle.TabIndex = 9;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click_1;
            // 
            // txtSatisFiyati
            // 
            txtSatisFiyati.Location = new Point(762, 32);
            txtSatisFiyati.Name = "txtSatisFiyati";
            txtSatisFiyati.Size = new Size(100, 23);
            txtSatisFiyati.TabIndex = 6;
            // 
            // txtBarkod
            // 
            txtBarkod.Location = new Point(390, 32);
            txtBarkod.Name = "txtBarkod";
            txtBarkod.Size = new Size(100, 23);
            txtBarkod.TabIndex = 5;
            // 
            // txtUrunAd
            // 
            txtUrunAd.Location = new Point(66, 32);
            txtUrunAd.Name = "txtUrunAd";
            txtUrunAd.Size = new Size(100, 23);
            txtUrunAd.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(662, 35);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 2;
            label3.Text = "Urun Satış Fiyatı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(325, 35);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "Urun Tipi:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 35);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Urun Adı:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(917, 455);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Stok";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView2);
            groupBox2.Controls.Add(btnIslem);
            groupBox2.Controls.Add(txtMiktar);
            groupBox2.Controls.Add(cbIslemTuru);
            groupBox2.Controls.Add(cbUrun);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(6, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(905, 443);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Stok İşlem Paneli";
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(0, 79);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(899, 358);
            dataGridView2.TabIndex = 7;
            // 
            // btnIslem
            // 
            btnIslem.Location = new Point(703, 31);
            btnIslem.Name = "btnIslem";
            btnIslem.Size = new Size(99, 23);
            btnIslem.TabIndex = 6;
            btnIslem.Text = "İşlem Yap";
            btnIslem.UseVisualStyleBackColor = true;
            btnIslem.Click += btnIslem_Click;
            // 
            // txtMiktar
            // 
            txtMiktar.Location = new Point(447, 31);
            txtMiktar.Name = "txtMiktar";
            txtMiktar.Size = new Size(100, 23);
            txtMiktar.TabIndex = 5;
            // 
            // cbIslemTuru
            // 
            cbIslemTuru.FormattingEnabled = true;
            cbIslemTuru.Location = new Point(257, 31);
            cbIslemTuru.Name = "cbIslemTuru";
            cbIslemTuru.Size = new Size(121, 23);
            cbIslemTuru.TabIndex = 4;
            // 
            // cbUrun
            // 
            cbUrun.FormattingEnabled = true;
            cbUrun.Location = new Point(48, 31);
            cbUrun.Name = "cbUrun";
            cbUrun.Size = new Size(121, 23);
            cbUrun.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(397, 34);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 2;
            label6.Text = "Miktar:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(185, 34);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 1;
            label5.Text = "İşlem Türü:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 34);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 0;
            label4.Text = "Ürün:";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btnRaporListele);
            tabPage3.Controls.Add(dataGridView3);
            tabPage3.Controls.Add(groupBox3);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(917, 455);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Rapor ";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnRaporListele
            // 
            btnRaporListele.Location = new Point(24, 21);
            btnRaporListele.Name = "btnRaporListele";
            btnRaporListele.Size = new Size(102, 36);
            btnRaporListele.TabIndex = 1;
            btnRaporListele.Text = "Rapor Listele";
            btnRaporListele.UseVisualStyleBackColor = true;
            btnRaporListele.Click += btnRaporListele_Click;
            // 
            // dataGridView3
            // 
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Dock = DockStyle.Bottom;
            dataGridView3.Location = new Point(0, 100);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(917, 355);
            dataGridView3.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Location = new Point(0, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(921, 455);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Rapor Paneli";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 507);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Envanter Sorumlum";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Button btnListele;
        private Button btnSil;
        private Button btnGuncelle;
        private Button btnEkle;
        private TextBox txtSatisFiyati;
        private TextBox txtBarkod;
        private TextBox txtUrunAd;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private GroupBox groupBox2;
        private Button btnIslem;
        private TextBox txtMiktar;
        private ComboBox cbIslemTuru;
        private ComboBox cbUrun;
        private Label label6;
        private Label label5;
        private Label label4;
        private DataGridView dataGridView2;
        private Button btnRaporListele;
        private DataGridView dataGridView3;
        private GroupBox groupBox3;
    }
}

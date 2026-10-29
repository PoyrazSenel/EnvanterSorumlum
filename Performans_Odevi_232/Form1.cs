using Performans_Odevi_232;

namespace Veri_Tabanis_Tekrars
{
    public partial class Form1 : Form
    {
        private UrunDbContext db = new UrunDbContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void Listele()
        {
            UrunDbContext db = new UrunDbContext();
            var tablo = db.TblUrunler.ToList();
            dataGridView1.DataSource = tablo;
        }

        private void UrunleriDoldur()
        {
            UrunDbContext db = new UrunDbContext();

            cbUrun.DataSource = db.TblUrunler.ToList();
            cbUrun.DisplayMember = "UrunAdi";
            cbUrun.ValueMember = "Id";

            cbIslemTuru.Items.Clear();
            cbIslemTuru.Items.Add("Stok Giriþ");
            cbIslemTuru.Items.Add("Stok Çýkýþ");
            cbIslemTuru.SelectedIndex = 0;
        }
        private void StokListele()
        {
            UrunDbContext db = new UrunDbContext();
            
            var tablo = (from s in db.TblStokHareketleri
                         join u in db.TblUrunler on s.UrunId equals u.Id
                         select new
                         {
                             s.Id,
                             UrunAdi = u.UrunAdi,
                             s.IslemTuru,
                             s.Miktar,
                             s.Tarih
                         }).ToList();

            dataGridView2.DataSource = tablo;
        }
        private void RaporListele()
        {
            UrunDbContext db = new UrunDbContext();

            var rapor = db.TblUrunler
                .Select(u => new StokRapor
                {
                    UrunId = u.Id,
                    UrunAdi = u.UrunAdi,
                    MevcutStok =
                        db.TblStokHareketleri
                        .Where(x => x.UrunId == u.Id)
                        .Sum(x => x.IslemTuru == "IN" ? x.Miktar : -x.Miktar)
                })
                .ToList();

            dataGridView3.DataSource = rapor;

            if (dataGridView3.Columns["UrunId"] != null)
            {
                dataGridView3.Columns["UrunId"].Visible = false;
            }
        }


        private void btnEkle_Click_1(object sender, EventArgs e)
        {
            UrunDbContext db = new UrunDbContext();
            Urun u = new Urun();

            u.UrunAdi = txtUrunAd.Text;
            u.UrunTuru= txtBarkod.Text;
            u.SatisFiyati = int.Parse(txtSatisFiyati.Text);

            db.Add(u);
            db.SaveChanges();

            Listele();
            UrunleriDoldur();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Listele();
            UrunleriDoldur();
            StokListele();
            RaporListele();
        }

        private void btnGuncelle_Click_1(object sender, EventArgs e)
        {
            UrunDbContext db = new UrunDbContext();

            int secilenId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            Urun u = db.TblUrunler.Find(secilenId);

            u.UrunAdi = txtUrunAd.Text;
            u.UrunTuru = txtBarkod.Text;
            u.SatisFiyati = int.Parse(txtSatisFiyati.Text);

            db.SaveChanges();

            Listele();
            UrunleriDoldur();
        }

        private void btnSil_Click_1(object sender, EventArgs e)
        {
            UrunDbContext db = new UrunDbContext();

            int secilenId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            var sil = db.TblUrunler.Find(secilenId);

            db.Remove(sil);
            db.SaveChanges();

            Listele();
            UrunleriDoldur();   
        }

        private void dataGridView1_DoubleClick_1(object sender, EventArgs e)
        {
            UrunDbContext db = new UrunDbContext();

            int secilenId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            Urun u = db.TblUrunler.Find(secilenId);

            txtUrunAd.Text = u.UrunAdi;
            txtBarkod.Text = u.UrunTuru;
            txtSatisFiyati.Text = u.SatisFiyati.ToString();
        }

        private void btnIslem_Click(object sender, EventArgs e)
        {
            UrunDbContext db = new UrunDbContext();

            StokHareketi sh = new StokHareketi();

            sh.UrunId = Convert.ToInt32(cbUrun.SelectedValue);

            // Ýþlem türünü IN/OUT'a çevir
            if (cbIslemTuru.Text == "Stok Giriþ")
                sh.IslemTuru = "IN";
            else
                sh.IslemTuru = "OUT";

            sh.Miktar = int.Parse(txtMiktar.Text);
            sh.Tarih = DateTime.Now;

            if (sh.IslemTuru == "OUT")
            {
                int girisToplam = db.TblStokHareketleri
                    .Where(x => x.UrunId == sh.UrunId && x.IslemTuru == "IN")
                    .Sum(x => x.Miktar);

                int cikisToplam = db.TblStokHareketleri
                    .Where(x => x.UrunId == sh.UrunId && x.IslemTuru == "OUT")
                    .Sum(x => x.Miktar);

                int mevcutStok = girisToplam - cikisToplam;

                if (mevcutStok < sh.Miktar)
                {
                    MessageBox.Show("Yetersiz stok!");
                    return;
                }
            }

            db.Add(sh);
            db.SaveChanges();

            txtMiktar.Clear();
            StokListele();
        }

        private void btnRaporListele_Click(object sender, EventArgs e)
        {
            RaporListele();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

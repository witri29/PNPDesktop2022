namespace POSApplication.ForntEnd
{
    public partial class FormCalculator : Form
    {
        public FormCalculator()
        {
            InitializeComponent();
        }



        private void btnHitungLuasSegitigas_Click(object sender, EventArgs e)
        {
            double alas = Convert.ToDouble(txtAlas.Text);
            double tinggi = Convert.ToDouble(txtTinggi.Text);
            double luasSegitiga = 0.5 * alas * tinggi;
            txtHasilLuasSegitiga.Text = luasSegitiga.ToString();
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            double dbBill1 = Convert.ToDouble(txtBil1.Text);
            double dbBill2 = Convert.ToDouble(txtBil2.Text);
            double Hasil = 0.0;

            if(rdTambah.Checked)
            {
                Hasil = dbBill1 + dbBill2;
            }
            else if(rdKurang.Checked)
            {
                Hasil = dbBill1 - dbBill2;
            }
            else if(rdKali.Checked)
            {
                Hasil = dbBill1 * dbBill2;
            }
            else
            {
                Hasil = dbBill1 / dbBill2;
            }

            txtHasil.Text = Hasil.ToString();
        }
    }
}
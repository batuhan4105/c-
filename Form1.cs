using System.Windows.Forms;

namespace ankara
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        //BASÝT HESAP MAK.
        #region degiskenler
        public int sayi_1, sayi_2, sonuc;
        calculate islemler = new calculate();
        #endregion
        #region donustur_metodu
        void donustur()
        {
            sayi_1 = Convert.ToInt32(textBox1.Text);
            sayi_2 = Convert.ToInt32(textBox2.Text);
        }
        #endregion
        #region topla_Butonu
        private void topla_Click(object sender, EventArgs e)
        {

            donustur();
            sonuc = islemler.toplama(sayi_1, sayi_2);
            label4.Text = sonuc.ToString();
        }
        #endregion
        #region cikar_Butonu
        private void cikar_Click(object sender, EventArgs e)
        {

            donustur();
            sonuc = islemler.cikarma(sayi_1, sayi_2);
            label4.Text = sonuc.ToString();
        }
        #endregion
        #region carp_Butonu
        private void carp_Click(object sender, EventArgs e)
        {

            donustur();
            sonuc = islemler.carpma(sayi_1, sayi_2);
            label4.Text = sonuc.ToString();
        }
        #endregion
        #region bolme_Butonu
        private void bolme_Click(object sender, EventArgs e)
        {

            donustur();
            sonuc = islemler.bolme(sayi_1, sayi_2);
            label4.Text = sonuc.ToString();
        }
        #endregion
        #region temizle_Butonu
        private void temizle_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label4.Text = ("0");

        }
        #endregion





    }
}

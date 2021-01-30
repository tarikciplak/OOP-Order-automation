using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProjeodeviNW
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnYonetici_Click(object sender, EventArgs e)
        {
            int sayi = 0;
            StreamReader okuyucu = File.OpenText("E:\\Yonetici Bilgi.txt");
            string satir = okuyucu.ReadLine();
            while (satir != null)
            {
                string[] parca = satir.Split('-');
                if (txtKullaniciAd.Text == parca[0] && txtKullaniciSifre.Text == parca[1])
                {
                    sayi++;
                    Form2 form2 = new Form2(this);
                    form2.Show();
                    this.Hide();

                }

                satir = okuyucu.ReadLine();

            }
            if (sayi == 0)
            {
                MessageBox.Show("Bilgileriniz yanlistir", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKullaniciAd.Text = "";
                txtKullaniciSifre.Text = "";
                txtKullaniciAd.Focus();
            }
            okuyucu.Close();
        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            int sayi = 0;
            StreamReader okuyucu = File.OpenText("E:\\Musteri Bilgi.txt");
            string satir = okuyucu.ReadLine();
            while (satir != null)
            {
                string[] parca = satir.Split('-');
                if (txtKullaniciAd.Text == parca[2] && txtKullaniciSifre.Text == parca[3])
                {
                    sayi++;
                    Customer c = new Customer();
                    c.id = Convert.ToInt32(parca[4]);
                    c.adSoyad = parca[0] +" "+ parca[1];
                    Depo.Kullanicilar=c;
                    Form1 form1 = new Form1(c);
                    form1.musteri_Ad = parca[0];
                    form1.musteri_Soyad = parca[1];
                    form1.Show();
                    this.Hide();
                    break;
                }
              
                satir = okuyucu.ReadLine();

            }
            if (sayi == 0)
            {
                MessageBox.Show("Bilgileriniz yanlistir", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKullaniciAd.Text = "";
                txtKullaniciSifre.Text = "";
                txtKullaniciAd.Focus();
            }
           
             okuyucu.Close();
        }

        private void lblCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            txtKullaniciAd.Focus();
        }

        private void txtKullaniciSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
           
        }
    }
}

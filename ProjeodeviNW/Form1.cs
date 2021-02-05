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
using System.Data.SqlClient;

namespace ProjeodeviNW
{
    public partial class Form1 : Form
    {
        public Customer c1;
        public Form1(Customer c)
        {
            c1 = c;
            InitializeComponent();
            listele();
        }
        public void listele()
        {
            SqlConnection con = new SqlConnection("Data Source=OWL\\TARIKOWL;Initial Catalog='Nayt story';Integrated Security=True");
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from items", con);
            da.Fill(dt);
            con.Close();
            con.Open();
            SqlDataAdapter da2 = new SqlDataAdapter("select count(*) from items", con);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            con.Close();
            for (int i = 0; i < Convert.ToInt32(dt2.Rows[0][0]); i++)
            {//dizinin 6. indisinden cinsiyet tanımı yapılmakta
                // True değeri  erkek cinsiyetini simgelenmekte
                // bu durum sağlandığında tbPgErkeksaat page kısmına atama yapılmakta
                if (Convert.ToBoolean(dt.Rows[i][6])==true)
                {
                    İtem a = new İtem();
                    a.id = Convert.ToInt32(dt.Rows[i][0]);
                    a.renk = dt.Rows[i][1].ToString();
                    a.kdv = Convert.ToDecimal(dt.Rows[i][2]);
                    a.fiyat= Convert.ToDecimal(dt.Rows[i][3]);
                    a.Resim = dt.Rows[i][4].ToString();
                    a.agirlik= Convert.ToDecimal(dt.Rows[i][5]);
                    Depo.eİtem.Add(a);
                    Depo.esayi++;
                }
                else
                {
                    İtem a = new İtem();
                    a.id = Convert.ToInt32(dt.Rows[i][0]);
                    a.renk = dt.Rows[i][1].ToString();
                    a.kdv = Convert.ToDecimal(dt.Rows[i][2]);
                    a.fiyat = Convert.ToDecimal(dt.Rows[i][3]);
                    a.Resim = dt.Rows[i][4].ToString();
                    a.agirlik = Convert.ToDecimal(dt.Rows[i][5]);
                    Depo.kİtem.Add(a);
                    Depo.ksayi++;
                }
            }
            atamap();
            atama2();
        }

        public string musteri_Ad;
        public string musteri_Soyad;

        private void Form1_Load(object sender, EventArgs e)
        {
            lblAd.Text = musteri_Ad + " " + musteri_Soyad;

        }
        public void atama2()
        {
            if (Depo.kİtem[Depo.kindis] != null)
            {
                pictureBox13.ImageLocation = Depo.kİtem[Depo.kindis].Resim;
                lblBayanSiyahRenk.Text = Depo.kİtem[Depo.kindis].renk;
                lblBayanSiyahKdv.Text = Depo.kİtem[Depo.kindis].kdv.ToString();
                lblBayanSiyahGr.Text = Depo.kİtem[Depo.kindis].agirlik.ToString();
                lblBayanSiyahFiyat.Text = Depo.kİtem[Depo.kindis].fiyat.ToString();
                z1.Text = Depo.kİtem[Depo.kindis].id.ToString();
                Depo.kindisp();

            }
            if (Depo.kİtem[Depo.kindis] != null)
            {
                pictureBox12.ImageLocation = Depo.kİtem[Depo.kindis].Resim;
                lblBayanAltinRenk.Text = Depo.kİtem[Depo.kindis].renk;
                lblBayanAltinKdv.Text = Depo.kİtem[Depo.kindis].kdv.ToString();
                lblBayanAltinGr.Text = Depo.kİtem[Depo.kindis].agirlik.ToString();
                lblBayanAltinFiyat.Text = Depo.kİtem[Depo.kindis].fiyat.ToString();
                z2.Text = Depo.kİtem[Depo.kindis].id.ToString();
                Depo.kindisp();

            }
            if (Depo.kİtem[Depo.kindis] != null)
            {
                pictureBox11.ImageLocation = Depo.kİtem[Depo.kindis].Resim;
                lblBayanKahveRenk.Text = Depo.kİtem[Depo.kindis].renk;
                lbllBayanKahveKdv.Text = Depo.kİtem[Depo.kindis].kdv.ToString();
                lbllBayanKahveGr.Text = Depo.kİtem[Depo.kindis].agirlik.ToString();
                lbllBayanKahveFiyat.Text = Depo.kİtem[Depo.kindis].fiyat.ToString();
                z3.Text = Depo.kİtem[Depo.kindis].id.ToString();
                Depo.kindisp();

            }
            if (Depo.kİtem[Depo.kindis] != null)
            {
                pictureBox10.ImageLocation = Depo.kİtem[Depo.kindis].Resim;
                lblBayanGumusRenk.Text = Depo.kİtem[Depo.kindis].renk;
                lblBayanGumusKdv.Text = Depo.kİtem[Depo.kindis].kdv.ToString();
                lblBayanGumusGr.Text = Depo.kİtem[Depo.kindis].agirlik.ToString();
                lblBayanGumusFiyat.Text = Depo.kİtem[Depo.kindis].fiyat.ToString();
                z4.Text = Depo.kİtem[Depo.kindis].id.ToString();
                Depo.kindisp();

            }
            if (Depo.kİtem[Depo.kindis] != null)
            {
                pictureBox9.ImageLocation = Depo.kİtem[Depo.kindis].Resim;
                lblBayanTurkuazRenk.Text = Depo.kİtem[Depo.kindis].renk;
                lblBayanTurkuazKdv.Text = Depo.kİtem[Depo.kindis].kdv.ToString();
                lblBayanTurkuazGr.Text = Depo.kİtem[Depo.kindis].agirlik.ToString();
                lblBayanTurkuazFiyat.Text = Depo.kİtem[Depo.kindis].fiyat.ToString();
                z5.Text = Depo.kİtem[Depo.kindis].id.ToString();
                Depo.kindisp();

            }
            if (Depo.kİtem[Depo.kindis] != null)
            {
                pictureBox8.ImageLocation = Depo.kİtem[Depo.kindis].Resim;
                lblBayanBeyazRenk.Text = Depo.kİtem[Depo.kindis].renk;
                lblBayanBeyazKdv.Text = Depo.kİtem[Depo.kindis].kdv.ToString();
                lblBayanBeyazGr.Text = Depo.kİtem[Depo.kindis].agirlik.ToString();
                lblBayanBeyazFiyat.Text = Depo.kİtem[Depo.kindis].fiyat.ToString(); z6.Text = Depo.kİtem[Depo.kindis].id.ToString();
                Depo.kindisp();

            }

        }
        public void atamap()
        {
            if (Depo.eİtem[Depo.eindis] != null)
            {
                pictureBox2.ImageLocation = Depo.eİtem[Depo.eindis].Resim;
                lblErkekSiyahRenk.Text = Depo.eİtem[Depo.eindis].renk;
                lblErkekSiyahKdv.Text = Depo.eİtem[Depo.eindis].kdv.ToString();
                lblErkekSiyahGr.Text = Depo.eİtem[Depo.eindis].agirlik.ToString();
                lblErkekSiyahFiyat.Text = Depo.eİtem[Depo.eindis].fiyat.ToString();
                l1.Text = Depo.eİtem[Depo.eindis].id.ToString();
                Depo.eindisp();
                
            }
            if (Depo.eİtem[Depo.eindis] != null)
            {
                pictureBox3.ImageLocation = Depo.eİtem[Depo.eindis].Resim;
                lblErkekMaviRenk.Text = Depo.eİtem[Depo.eindis].renk;
                lblErkekMaviKdv.Text = Depo.eİtem[Depo.eindis].kdv.ToString();
                lblErkekSiyahGr.Text = Depo.eİtem[Depo.eindis].agirlik.ToString();
                lblErkekMaviFiyat.Text = Depo.eİtem[Depo.eindis].fiyat.ToString();
                l2.Text = Depo.eİtem[Depo.eindis].id.ToString();
                Depo.eindisp();
                
            }
            if (Depo.eİtem[Depo.eindis] != null)
            {
                pictureBox4.ImageLocation = Depo.eİtem[Depo.eindis].Resim;
                lblErkekKırmızıRenk.Text = Depo.eİtem[Depo.eindis].renk;
                lblErkekKırmızıKdv.Text = Depo.eİtem[Depo.eindis].kdv.ToString();
                lblErkekKırmızıGr.Text = Depo.eİtem[Depo.eindis].agirlik.ToString();
                lblErkekKırmızıFiyat.Text = Depo.eİtem[Depo.eindis].fiyat.ToString();
                l3.Text = Depo.eİtem[Depo.eindis].id.ToString();
                Depo.eindisp();
            }
            if (Depo.eİtem[Depo.eindis] != null)
            {
                pictureBox7.ImageLocation = Depo.eİtem[Depo.eindis].Resim;
                lblErkekAltinRenk.Text = Depo.eİtem[Depo.eindis].renk;
                lblErkekAltinKdv.Text = Depo.eİtem[Depo.eindis].kdv.ToString();
                lblErkekAltinGr.Text = Depo.eİtem[Depo.eindis].agirlik.ToString();
                lblErkekAltinFiyat.Text = Depo.eİtem[Depo.eindis].fiyat.ToString();
                l4.Text = Depo.eİtem[Depo.eindis].id.ToString();
                Depo.eindisp();
            }
            if (Depo.eİtem[Depo.eindis] != null)
            {
                pictureBox6.ImageLocation = Depo.eİtem[Depo.eindis].Resim;
                lblErkekKahveRenk.Text = Depo.eİtem[Depo.eindis].renk;
                lblErkekKahveKdv.Text = Depo.eİtem[Depo.eindis].kdv.ToString();
                lblErkekKahveGr.Text = Depo.eİtem[Depo.eindis].agirlik.ToString();
                lblErkekKahveFiyat.Text = Depo.eİtem[Depo.eindis].fiyat.ToString();
                l5.Text = Depo.eİtem[Depo.eindis].id.ToString();
                Depo.eindisp();
            }
            if (Depo.eİtem[Depo.eindis] != null)
            {
                pictureBox5.ImageLocation = Depo.eİtem[Depo.eindis].Resim;
                lblErkekGumusRenk.Text = Depo.eİtem[Depo.eindis].renk;
                lblErkekGumusKdv.Text = Depo.eİtem[Depo.eindis].kdv.ToString();
                lblbErkekGumusGr.Text = Depo.eİtem[Depo.eindis].agirlik.ToString();
                lblErkekGumusFiyat.Text = Depo.eİtem[Depo.eindis].fiyat.ToString();
                l6.Text = Depo.eİtem[Depo.eindis].id.ToString();
                Depo.eindisp();
            }
        }

     

        private void btnBayanSiyah_Click(object sender, EventArgs e)
        {
            if (cmbBayanSiyah.SelectedIndex == -1)
            {
                MessageBox.Show("Lutfen miktar sayisini giriniz!", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                İtem i = new İtem();
                i.id = Convert.ToInt32(z1.Text);
                i.agirlik = Convert.ToDecimal(lblBayanSiyahGr.Text);
                i.fiyat = Convert.ToDecimal(lblBayanSiyahFiyat.Text);
                i.kdv = Convert.ToDecimal(lblBayanSiyahKdv.Text);
                i.renk = lblBayanSiyahRenk.Text;
                OrderDetail od = new OrderDetail();
                od.adet = Convert.ToInt32(cmbBayanSiyah.SelectedItem);
                od.ürün = i;
                Order o = new Order();
                o.slist.Add(od);
                c1.sepet.Add(o);
                dataGridView1.Rows.Add(lblBayanSiyahRenk.Text, cmbBayanSiyah.Text, lblBayanSiyahGr.Text + "gr", lblBayanSiyahKdv.Text, lblBayanSiyahFiyat.Text + "TL");
                MessageBox.Show("Ürün Sepetinize Eklenmiştir...", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


        }

        private void btnBayanAltin_Click(object sender, EventArgs e)
        {
            if (cmbBayanAltin.SelectedIndex == -1)
            {
                MessageBox.Show("Lutfen miktar sayisini giriniz!", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                İtem i = new İtem();
                i.id = Convert.ToInt32(z2.Text);
                i.agirlik = Convert.ToDecimal(lblBayanAltinGr.Text);
                i.fiyat = Convert.ToDecimal(lblBayanAltinFiyat.Text);
                i.kdv = Convert.ToDecimal(lblBayanAltinKdv.Text);
                i.renk = lblBayanAltinRenk.Text;
                OrderDetail od = new OrderDetail();
                od.adet = Convert.ToInt32(cmbBayanAltin.SelectedItem);
                od.ürün = i;
                Order o = new Order();
                o.slist.Add(od);
                c1.sepet.Add(o);
                dataGridView1.Rows.Add(lblBayanAltinRenk.Text, cmbBayanAltin.Text, lblBayanAltinGr.Text + "gr", lblBayanAltinKdv.Text, lblBayanAltinFiyat.Text + "TL");
                MessageBox.Show("Ürün Sepetinize Eklenmiştir...", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnlBayanKahve_Click(object sender, EventArgs e)
        {
            if (cmbBayanKahve.SelectedIndex == -1)
            {
                MessageBox.Show("Lutfen miktar sayisini giriniz!", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                İtem i = new İtem();
                i.id = Convert.ToInt32(z3.Text);
                i.agirlik = Convert.ToDecimal(lbllBayanKahveGr.Text);
                i.fiyat = Convert.ToDecimal(lbllBayanKahveFiyat.Text);
                i.kdv = Convert.ToDecimal(lbllBayanKahveKdv.Text);
                i.renk = lblBayanKahveRenk.Text;
                OrderDetail od = new OrderDetail();
                od.adet = Convert.ToInt32(cmbBayanKahve.SelectedItem);
                od.ürün = i;
                Order o = new Order();
                o.slist.Add(od);
                c1.sepet.Add(o);
                dataGridView1.Rows.Add(lblBayanKahveRenk.Text, cmbBayanKahve.Text, lbllBayanKahveGr.Text + "gr", lbllBayanKahveKdv.Text, lbllBayanKahveFiyat.Text + "TL");
                MessageBox.Show("Ürün Sepetinize Eklenmiştir...", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnBayanGumus_Click(object sender, EventArgs e)
        {
            if (cmbBayanGumus.SelectedIndex == -1)
            {
                MessageBox.Show("Lutfen miktar sayisini giriniz!", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                İtem i = new İtem();
                i.id = Convert.ToInt32(z4.Text);
                i.agirlik = Convert.ToDecimal(lblBayanGumusGr.Text);
                i.fiyat = Convert.ToDecimal(lblBayanGumusFiyat.Text);
                i.kdv = Convert.ToDecimal(lblBayanGumusKdv.Text);
                i.renk = lblBayanGumusRenk.Text;
                OrderDetail od = new OrderDetail();
                od.adet = Convert.ToInt32(cmbBayanGumus.SelectedItem);
                od.ürün = i;
                Order o = new Order();
                o.slist.Add(od);
                c1.sepet.Add(o);
                dataGridView1.Rows.Add(lblBayanGumusRenk.Text, cmbBayanGumus.Text, lblBayanGumusGr.Text + "gr", lblBayanGumusKdv.Text, lblBayanGumusFiyat.Text + "TL");
                MessageBox.Show("Ürün Sepetinize Eklenmiştir...", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnBayanTurkuaz_Click(object sender, EventArgs e)
        {
            if (cmbBayanTurkuaz.SelectedIndex == -1)
            {
                MessageBox.Show("Lutfen miktar sayisini giriniz!", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                İtem i = new İtem();
                i.id = Convert.ToInt32(z5.Text);
                i.agirlik = Convert.ToDecimal(lblBayanTurkuazGr.Text);
                i.fiyat = Convert.ToDecimal(lblBayanTurkuazFiyat.Text);
                i.kdv = Convert.ToDecimal(lblBayanTurkuazKdv.Text);
                i.renk = lblBayanTurkuazRenk.Text;
                OrderDetail od = new OrderDetail();
                od.adet = Convert.ToInt32(cmbBayanTurkuaz.SelectedItem);
                od.ürün = i;
                Order o = new Order();
                o.slist.Add(od);
                c1.sepet.Add(o);
                MessageBox.Show("Ürün Sepetinize Eklenmiştir...", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataGridView1.Rows.Add(lblBayanTurkuazRenk.Text, cmbBayanTurkuaz.Text, lblBayanTurkuazGr.Text + "gr", lblBayanTurkuazKdv.Text, lblBayanTurkuazFiyat.Text + "TL");
            }

        }

        private void btnBayanBeyaz_Click(object sender, EventArgs e)
        {
            if (cmbBayanBeyaz.SelectedIndex == -1)
            {
                MessageBox.Show("Lutfen miktar sayisini giriniz!", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                
                İtem i = new İtem();
                i.id = Convert.ToInt32(z6.Text);
                i.agirlik = Convert.ToDecimal(lblBayanBeyazGr.Text);
                i.fiyat = Convert.ToDecimal(lblBayanBeyazFiyat.Text);
                i.kdv = Convert.ToDecimal(lblBayanBeyazKdv.Text);
                i.renk = lblBayanBeyazRenk.Text;
                OrderDetail od = new OrderDetail();
                od.adet = Convert.ToInt32(cmbBayanBeyaz.SelectedItem);
                od.ürün = i;
                Order o = new Order();
                o.slist.Add(od);
                c1.sepet.Add(o);
                MessageBox.Show("Ürün Sepetinize Eklenmiştir...", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataGridView1.Rows.Add(lblBayanBeyazRenk.Text, cmbBayanBeyaz.Text, lblBayanBeyazGr.Text + "gr", lblBayanBeyazKdv.Text, lblBayanBeyazFiyat.Text + "TL");
                

            }

        }


        private void btnErkekSiyah_Click(object sender, EventArgs e)
        {
            if (cmbErkekSiyah.SelectedIndex == -1)
            {
                MessageBox.Show("Lutfen miktar sayisini giriniz!", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                İtem i = new İtem();
                i.id = Convert.ToInt32(l1.Text);
                i.agirlik = Convert.ToDecimal(lblErkekSiyahGr.Text);
                i.fiyat = Convert.ToDecimal(lblErkekSiyahFiyat.Text);
                i.kdv = Convert.ToDecimal(lblErkekSiyahKdv.Text);
                i.renk = lblErkekSiyahRenk.Text;
                OrderDetail od = new OrderDetail();
                od.adet = Convert.ToInt32(cmbErkekSiyah.SelectedItem);
                od.ürün = i;
                Order o = new Order();
                o.slist.Add(od);
                c1.sepet.Add(o);
                MessageBox.Show("Ürün Sepetinize Eklenmiştir...", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataGridView1.Rows.Add(lblErkekSiyahRenk.Text, cmbErkekSiyah.Text, lblErkekSiyahGr.Text + "gr", lblErkekSiyahKdv.Text, lblErkekSiyahFiyat.Text + "TL");
                
            }
        }

        private void btnErkekMavi_Click(object sender, EventArgs e)
        {
            if (cmbErkekMavi.SelectedIndex == -1)
            {
                MessageBox.Show("Lutfen miktar sayisini giriniz!", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                İtem i = new İtem();
                i.id = Convert.ToInt32(l2.Text);
                i.agirlik = Convert.ToDecimal(lblErkekMaviGr.Text);
                i.fiyat = Convert.ToDecimal(lblErkekMaviFiyat.Text);
                i.kdv = Convert.ToDecimal(lblErkekMaviKdv.Text);
                i.renk = lblErkekMaviRenk.Text;
                OrderDetail od = new OrderDetail();
                od.adet = Convert.ToInt32(cmbErkekMavi.SelectedItem);
                od.ürün = i;
                Order o = new Order();
                o.slist.Add(od);
                c1.sepet.Add(o);
                MessageBox.Show("Ürün Sepetinize Eklenmiştir...", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataGridView1.Rows.Add(lblErkekMaviRenk.Text, cmbErkekMavi.Text, lblErkekMaviGr.Text + "gr", lblErkekMaviKdv.Text, lblErkekMaviFiyat.Text + "TL");
               
            }
        }

        private void btnErkekKırmızı_Click(object sender, EventArgs e)
        {
            if (cmbErkekKırmızı.SelectedIndex == -1)
            {
                MessageBox.Show("Lutfen miktar sayisini giriniz!", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                İtem i = new İtem();
                i.id = Convert.ToInt32(l3.Text);
                i.agirlik = Convert.ToDecimal(lblErkekKırmızıGr.Text);
                i.fiyat = Convert.ToDecimal(lblErkekKırmızıFiyat.Text);
                i.kdv = Convert.ToDecimal(lblErkekKırmızıKdv.Text);
                i.renk = lblErkekKırmızıRenk.Text;
                OrderDetail od = new OrderDetail();
                od.adet = Convert.ToInt32(cmbErkekKırmızı.SelectedItem);
                od.ürün = i;
                Order o = new Order();
                o.slist.Add(od);
                c1.sepet.Add(o);
                dataGridView1.Rows.Add(lblErkekKırmızıRenk.Text, cmbErkekKırmızı.Text, lblErkekKırmızıGr.Text + "gr", lblErkekKırmızıKdv.Text, lblErkekKırmızıFiyat.Text + "TL");
                MessageBox.Show("Ürün Sepetinize Eklenmiştir...", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnErkekAltin_Click(object sender, EventArgs e)
        {
            if (cmbErkekAltin.SelectedIndex == -1)
            {
                MessageBox.Show("Lutfen miktar sayisini giriniz!", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                İtem i = new İtem();
                i.id = Convert.ToInt32(l4.Text);
                i.agirlik = Convert.ToDecimal(lblErkekAltinGr.Text);
                i.fiyat = Convert.ToDecimal(lblErkekAltinFiyat.Text);
                i.kdv = Convert.ToDecimal(lblErkekAltinKdv.Text);
                i.renk = lblErkekAltinRenk.Text;
                OrderDetail od = new OrderDetail();
                od.adet = Convert.ToInt32(cmbErkekAltin.SelectedItem);
                od.ürün = i;
                Order o = new Order();
                o.slist.Add(od);
                c1.sepet.Add(o);
                dataGridView1.Rows.Add(lblErkekAltinRenk.Text, cmbErkekAltin.Text, lblErkekAltinGr.Text + "gr", lblErkekAltinKdv.Text, lblErkekAltinFiyat.Text + "TL");
                MessageBox.Show("Ürün Sepetinize Eklenmiştir...", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnErkekKahve_Click(object sender, EventArgs e)
        {
            if (cmbErkekKahve.SelectedIndex == -1)
            {
                MessageBox.Show("Lutfen miktar sayisini giriniz!", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                İtem i = new İtem();
                i.id = Convert.ToInt32(l5.Text);
                i.agirlik = Convert.ToDecimal(lblErkekKahveGr.Text);
                i.fiyat = Convert.ToDecimal(lblErkekKahveFiyat.Text);
                i.kdv = Convert.ToDecimal(lblErkekKahveKdv.Text);
                i.renk = lblErkekKahveRenk.Text;
                OrderDetail od = new OrderDetail();
                od.adet = Convert.ToInt32(cmbErkekKahve.SelectedItem);
                od.ürün = i;
                Order o = new Order();
                o.slist.Add(od);
                c1.sepet.Add(o);
                dataGridView1.Rows.Add(lblErkekKahveRenk.Text, cmbErkekKahve.Text, lblErkekKahveGr.Text + "gr", lblErkekKahveKdv.Text, lblErkekKahveFiyat.Text + "TL");
                MessageBox.Show("Ürün Sepetinize Eklenmiştir...", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnErkekGumus_Click(object sender, EventArgs e)
        {
            if (cmbErkekGumus.SelectedIndex == -1)
            {
                MessageBox.Show("Lutfen miktar sayisini giriniz!", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                İtem i = new İtem();
                i.id = Convert.ToInt32(l6.Text);
                i.agirlik = Convert.ToDecimal(lblbErkekGumusGr.Text);
                i.fiyat = Convert.ToDecimal(lblErkekGumusFiyat.Text);
                i.kdv = Convert.ToDecimal(lblErkekGumusKdv.Text);
                i.renk = lblErkekGumusRenk.Text;
                OrderDetail od = new OrderDetail();
                od.adet = Convert.ToInt32(cmbErkekGumus.SelectedItem);
                od.ürün = i;
                Order o = new Order();
                o.slist.Add(od);
                c1.sepet.Add(o);
                dataGridView1.Rows.Add(lblErkekGumusRenk.Text, cmbErkekGumus.Text, lblbErkekGumusGr.Text + "gr", lblErkekGumusKdv.Text, lblErkekGumusFiyat.Text + "TL");
                MessageBox.Show("Ürün Sepetinize Eklenmiştir...", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        
        private void simpleButton5_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Cikis Yapmak istediginizden emin misiniz?", "CIKIS", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cevap == DialogResult.Yes)
            {
                    Form4 form4 = new Form4();
                    Depo.eindis = 0;
                    Depo.eindis = 0;
                    Depo.eİtem.Clear();
                    Depo.kİtem.Clear();



                    form4.Show();
                    this.Hide();
            }

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            atamap();

        }
        
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            atama2();
            panel12.Visible = false;
            panel11.Visible = false;
            panel10.Visible = false;
            panel9.Visible = false;
            panel8.Visible = false;
            
        }

        private void tbPgSiparislerim_Click(object sender, EventArgs e)
        {

        }
        
        private void simpleButton1_Click_1(object sender, EventArgs e)

        {
            dataGridView1.Rows.Clear();
            ödemeşekli a = new ödemeşekli(c1);
            a.Show();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex==3)
            {
                decimal topf = 0;
                decimal topa = 0;

                foreach (Order item in c1.sepet)
                {
                    topf += item.kdvlitoplamfiyat();
                    topa += item.toplamagirlik();

                }
                kdvliucret.Text = topf.ToString();
                if (topa>0 && topa < 199)
                {
                    kargouc.Text = "10"; }
                else if (topa == 0)
                {
                    kargouc.Text = "0";
                }
                else if (topa <299)

                {
                    kargouc.Text = "15";
                }
                else { kargouc.Text = "20"; }
                odenecektutar.Text = (topf + Convert.ToDecimal(kargouc.Text)).ToString();
            }
        }

        private void odenecektutar_Click(object sender, EventArgs e)
        {

        }
    }
}
    

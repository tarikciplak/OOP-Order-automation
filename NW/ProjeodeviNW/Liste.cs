using System;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Data;
using System.Drawing;

namespace ProjeodeviNW
{
    public partial class Liste : Form
    {
        public Liste()
        {
            InitializeComponent();
            tabloyukle();
        }
        public void tabloyukle()
        {
            SqlConnection con = new SqlConnection("Data Source = OWL\\TARIKOWL; Initial Catalog =  'Nayt story'; Integrated Security = True");
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select id,renk,kdv,fiyat,resim,agirlik,cinsiyet from items" , con);
            da.Fill(dt);
            con.Close();
            gridControl1.DataSource = dt;




        }
        public void eklesil(int ek ){
            switch (ek)
            {
                case 0:
                    {
                        ekle.Visible = false;
                        sil.Visible = false;
                    simpleButton1.Visible = true;
                    simpleButton1.Location = new Point(63, 335);
                    break; }

                case 1:
                    {
                        simpleButton1.Visible = false;
                        ekle.Visible = true;
                        ekle.Location= new Point(22,346);
                        sil.Visible = true;
                        sil.Location=new Point(103,346);
                        break; 


                    }

            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
            if(textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && pictureBox1.ImageLocation != "" && textBox4.Text != "" && comboBox1.Text != "")
            {
                if (label7.Text != "")
                {
                    SqlConnection c = new SqlConnection("Data Source = OWL\\TARIKOWL; Initial Catalog =  'Nayt story'; Integrated Security = True");
                    c.Open();
                    SqlCommand ce = new SqlCommand("update items set renk=@renk,kdv=@kdv,fiyat=@fiyat,resim=@resim,agirlik=@agirlik,cinsiyet=@cinsiyet where id='" + label7.Text + "'", c);
                    ce.Parameters.AddWithValue("@renk", textBox1.Text);
                    ce.Parameters.AddWithValue("@kdv", Convert.ToDecimal(textBox2.Text));
                    ce.Parameters.AddWithValue("@fiyat", Convert.ToDecimal(textBox3.Text));
                    ce.Parameters.AddWithValue("@resim", pictureBox1.ImageLocation);
                    ce.Parameters.AddWithValue("@agirlik", Convert.ToDecimal(textBox4.Text));
                    if (comboBox1.SelectedItem.ToString() == "Bay")
                    {
                        ce.Parameters.AddWithValue("@cinsiyet", true);
                    }
                    else if (comboBox1.SelectedItem.ToString() == "Bayan")
                    {
                        ce.Parameters.AddWithValue("@cinsiyet", false);
                    }
                    ce.ExecuteNonQuery();
                    c.Close();
                    MessageBox.Show("İşlem başarılı");
                    tabloyukle();
                }
                else { MessageBox.Show("Güncellenecek bir ürün seçiniz!");}
            }
            else
                MessageBox.Show("Tüm boşlukları doldurunuz");





        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void txtKullaniciSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) || (int)e.KeyChar == 44)
            
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            

        }
        private void text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            label7.Text = layoutView1.GetFocusedRowCellValue("id").ToString();
            pictureBox1.ImageLocation = layoutView1.GetFocusedRowCellValue("resim").ToString();
            textBox1.Text = layoutView1.GetFocusedRowCellValue("renk").ToString();
            textBox2.Text = layoutView1.GetFocusedRowCellValue("kdv").ToString();
            textBox3.Text = layoutView1.GetFocusedRowCellValue("fiyat").ToString();
            textBox4.Text = layoutView1.GetFocusedRowCellValue("agirlik").ToString();
            if (layoutView1.GetFocusedRowCellValue("cinsiyet").ToString()=="True") {
                comboBox1.Text = "Bay";
            }
            else
            {
                comboBox1.Text = "Bayan";
            }


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ekle_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && pictureBox1.ImageLocation != "" && textBox4.Text != "" && comboBox1.Text != "")
            {
                SqlConnection c = new SqlConnection("Data Source = OWL\\TARIKOWL; Initial Catalog =  'Nayt story'; Integrated Security = True");
                c.Open();
                SqlCommand ce = new SqlCommand("insert into items (renk,kdv,fiyat,resim,agirlik,cinsiyet) VALUES (@renk,@kdv,@fiyat,@resim,@agirlik,@cinsiyet)", c);
                ce.Parameters.AddWithValue("@renk", textBox1.Text);
                ce.Parameters.AddWithValue("@kdv",Convert.ToDecimal( textBox2.Text));
                ce.Parameters.AddWithValue("@fiyat", Convert.ToDecimal( textBox3.Text));
                ce.Parameters.AddWithValue("@resim", pictureBox1.ImageLocation);
                ce.Parameters.AddWithValue("@agirlik", Convert.ToDecimal(textBox4.Text));
                if (comboBox1.SelectedItem.ToString()=="Bay") {
                    ce.Parameters.AddWithValue("@cinsiyet", true);
                }
                else if( comboBox1.SelectedItem.ToString() == "Bayan")
                {
                    ce.Parameters.AddWithValue("@cinsiyet", false);
                }
                ce.ExecuteNonQuery();
                c.Close();
                MessageBox.Show("İşlem başarılı");
                tabloyukle();
            }
            else
                MessageBox.Show("Tüm boşlukları doldurunuz");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void sil_Click(object sender, EventArgs e)
        {
            if (label7.Text != "")
            {
                DialogResult d = MessageBox.Show("Ürünün silinmesini onaylıyor musunuz!", "Silme işlemi", MessageBoxButtons.YesNo);
                if (DialogResult.Yes == d)
                {
                    SqlConnection c = new SqlConnection("Data Source = OWL\\TARIKOWL; Initial Catalog =  'Nayt story'; Integrated Security = True");
                    c.Open();
                    SqlCommand ce = new SqlCommand("delete from items where id='" + label7.Text + "'", c);
                    ce.ExecuteNonQuery();
                    MessageBox.Show("Silme işlemi gerçekleştirildi");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

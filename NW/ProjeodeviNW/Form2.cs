using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeodeviNW
{
    public partial class Form2 : Form
    {
        Form4 f4;
        public Form2(Form4 f)
        {
            f4 = f;
            InitializeComponent();
        }
        public Liste l;
        public SatisRapor sr;
        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (l == null)
            {
                l = new Liste();
            }
            l.MdiParent = this;
            l.eklesil(1);
            l.Show();
            l.Focus();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (l == null)
            {
                l = new Liste();
            }
            l.MdiParent = this;
            l.eklesil(0);
            l.Show();
            l.Focus();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
            f4.Show();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (sr == null)
                sr = new SatisRapor();
            sr.MdiParent = this;
            sr.Show();
            sr.Focus();
        }
    }
}

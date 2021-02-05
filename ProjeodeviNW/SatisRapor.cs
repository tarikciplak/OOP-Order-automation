using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjeodeviNW
{
    public partial class SatisRapor : Form
    {
        public void rapor()
        {
            SqlConnection con = new SqlConnection("Data Source=OWL\\TARIKOWL;Initial Catalog='Nayt story';Integrated Security=True");
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Alimlar",con);
            da.Fill(dt);
            con.Close();
            gridControl1.DataSource = dt;
        }
            
        public SatisRapor()
        {
            InitializeComponent();
            rapor();
        }
    }
}

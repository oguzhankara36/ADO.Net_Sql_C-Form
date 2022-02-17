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
namespace Pastane_ADO
{
    public partial class Genel_siparis : Form
    {
        public Genel_siparis()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1H088T4\\SA;Initial Catalog=Pastane;Integrated Security=True");
        public void listele(string ulas)
        {
            SqlDataAdapter goruntule = new SqlDataAdapter(ulas, baglanti);
            DataSet doldur = new DataSet();
            goruntule.Fill(doldur);
            dataGridView1.DataSource = doldur.Tables[0];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            listele("select s.siparisadi,s.tutar,m.musteriadsoyad from siparis s join musteriler m on  s.siparisno=m.siparisno");
        }
    }
}

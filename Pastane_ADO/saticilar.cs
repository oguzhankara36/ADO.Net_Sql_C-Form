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
    public partial class saticilar : Form
    {
        public saticilar()
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

        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            listele("select * from Satıcı");
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Satıcı(satıcıadı,satıcıadres,satıcıil,satıcıilçe) values (@satıcıadı,@satıcıadres,@satıcıil,@satıcıilçe)", baglanti);
            komut.Parameters.AddWithValue("@satıcıadı", txtadsoyad.Text);
            komut.Parameters.AddWithValue("@satıcıadres", txtadres.Text);
            komut.Parameters.AddWithValue("@satıcıil", txtil.Text);
            komut.Parameters.AddWithValue("@satıcıilçe", txtilce.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            listele("select * from Satıcı");
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Satıcı where satıcıno=@satıcıno", baglanti);
            komut.Parameters.AddWithValue("@satıcıno", txtno.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            listele("select * from Satıcı");
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update  Satıcı set satıcıadres='" + txtadres.Text.ToString() + "',satıcıil='" + txtil.Text.ToString() + "',satıcıilçe='" + txtilce.Text.ToString() + "' where satıcıno='" + txtno.Text.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            listele("select * from Satıcı");
            baglanti.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sectim = dataGridView1.SelectedCells[0].RowIndex;
            string satıcıno = dataGridView1.Rows[sectim].Cells[0].Value.ToString();
            string satıcıadsoyad = dataGridView1.Rows[sectim].Cells[1].Value.ToString();
            string satıcıadres = dataGridView1.Rows[sectim].Cells[2].Value.ToString();
            string satıcıil = dataGridView1.Rows[sectim].Cells[3].Value.ToString();
            string satıcıilçe = dataGridView1.Rows[sectim].Cells[4].Value.ToString();

            txtno.Text = satıcıno;
            txtadsoyad.Text = satıcıadsoyad;
            txtadres.Text = satıcıadres;
            txtil.Text = satıcıil;
            txtilce.Text = satıcıilçe;
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Satıcı where satıcıadı like '%" + txtadsoyad.Text + "%'", baglanti);
    
            komut.ExecuteNonQuery();

            SqlDataAdapter goruntule = new SqlDataAdapter(komut);
            DataSet doldur = new DataSet();
            goruntule.Fill(doldur);
            dataGridView1.DataSource = doldur.Tables[0];
            baglanti.Close();
        }
    }
}

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
    public partial class Müsteriler : Form
    {
        public Müsteriler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1H088T4\\SA;Initial Catalog=Pastane;Integrated Security=True");
        private void Müsteriler_Load(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("select * from siparis", baglanti);

            SqlDataReader dr;

            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtsiparisno.Items.Add(dr["siparisno"]);
            }
            baglanti.Close();
        }
        public void listele(string ulas)
        {
            SqlDataAdapter goruntule = new SqlDataAdapter(ulas, baglanti);
            DataSet doldur = new DataSet();
            goruntule.Fill(doldur);
            dataGridView1.DataSource = doldur.Tables[0];
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from musteriler where müsterino=@musterino", baglanti);
            komut.Parameters.AddWithValue("@musterino", txtmusterino.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            listele("select * from musteriler");
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            listele("select * from musteriler");
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into musteriler(musteriadsoyad,musteritel,siparisno) values (@musteriadsoyad,@musteritel,@siparisno)", baglanti);
            komut.Parameters.AddWithValue("@musteriadsoyad", txtmusteriadsoyad.Text);
            komut.Parameters.AddWithValue("@musteritel", txtmusteritel.Text);
            komut.Parameters.AddWithValue("@siparisno", txtsiparisno.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            listele("select * from musteriler");
        }

        private void btnarama_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from musteriler where siparisadi like '%" + txtmusteriadsoyad.Text + "%'", baglanti);

            komut.ExecuteNonQuery();

            SqlDataAdapter goruntule = new SqlDataAdapter(komut);
            DataSet doldur = new DataSet();
            goruntule.Fill(doldur);
            dataGridView1.DataSource = doldur.Tables[0];
            baglanti.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sectim = dataGridView1.SelectedCells[0].RowIndex;
            string musterino = dataGridView1.Rows[sectim].Cells[0].Value.ToString();
            string adsoyad = dataGridView1.Rows[sectim].Cells[1].Value.ToString();
            string musteritel = dataGridView1.Rows[sectim].Cells[2].Value.ToString();
            string siparisno = dataGridView1.Rows[sectim].Cells[3].Value.ToString();


            txtmusteriadsoyad.Text = adsoyad;
            txtmusterino.Text = musterino;
            txtmusteritel.Text = musteritel;
            txtsiparisno.Text = siparisno;

        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            listele("select * from musteriler");
        }
    }
}

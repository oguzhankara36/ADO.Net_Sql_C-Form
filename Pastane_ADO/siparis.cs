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
    public partial class siparis : Form
    {
        public siparis()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1H088T4\\SA;Initial Catalog=Pastane;Integrated Security=True");
        private void siparis_Load(object sender, EventArgs e)
        {
            txttutar.Enabled = false;
            baglanti.Open();

            SqlCommand komut = new SqlCommand("select * from Urunler", baglanti);

            SqlDataReader dr;

            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txturunno.Items.Add(dr["urunno"]);
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
        private void btnekle_Click(object sender, EventArgs e)
        {
            int adet = int.Parse(txtadet.Text);
            int fiyat = int.Parse(txtfiyat.Text);
            int sonuc = adet * fiyat;
            txttutar.Text = sonuc.ToString();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into siparis(siparisadi,siparisadres,siparisadet,siparisfiyat,urunno,tutar) values (@siparisadi,@siparisadres,@siparisadet,@siparisfiyat,@urunno,@tutar)", baglanti);
            komut.Parameters.AddWithValue("@siparisadi", txtadı.Text);
            komut.Parameters.AddWithValue("@siparisadres", txtadres.Text);
            komut.Parameters.AddWithValue("@siparisadet", txtadet.Text);
            komut.Parameters.AddWithValue("@siparisfiyat", txtfiyat.Text);
            komut.Parameters.AddWithValue("@urunno", txturunno.Text);
            komut.Parameters.AddWithValue("@tutar", txttutar.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            listele("select * from siparis");
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from siparis where siparisno=@siparisno", baglanti);
            komut.Parameters.AddWithValue("@siparisno", txtsipno.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            listele("select * from siparis");
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            listele("select * from siparis");
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            int adet = int.Parse(txtadet.Text);
            int fiyat = int.Parse(txtfiyat.Text);
            int sonuc = adet * fiyat;
            txttutar.Text = sonuc.ToString();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update  siparis set siparisfiyat='" + txtfiyat.Text.ToString() + "',siparisadi='"+txtadı.Text.ToString()+"',siparisadet='="+txtadet.Text.ToString()+"',tutar='"+txttutar.Text.ToString()+"' where siparisno='" + txtsipno.Text.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            listele("select * from siparis");
            baglanti.Close();
        }

        private void btnarama_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from siparis where siparisadi like '%" + txtadı.Text + "%'", baglanti);

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
            string sipno = dataGridView1.Rows[sectim].Cells[0].Value.ToString();
            string ad = dataGridView1.Rows[sectim].Cells[1].Value.ToString();
            string adres = dataGridView1.Rows[sectim].Cells[2].Value.ToString();
            string adet = dataGridView1.Rows[sectim].Cells[3].Value.ToString();
            string fiyat = dataGridView1.Rows[sectim].Cells[4].Value.ToString();
            string urunno = dataGridView1.Rows[sectim].Cells[5].Value.ToString();
            string tutar = dataGridView1.Rows[sectim].Cells[6].Value.ToString();

            txtsipno.Text = urunno;
            txtadı.Text = ad;
            txtfiyat.Text = fiyat;
            txtadet.Text = adet;
            txtadres.Text = adres;
            txttutar.Text = tutar;
            txturunno.Text = urunno;
        }
    }
}

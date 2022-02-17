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
    public partial class Urunler : Form
    {
        public Urunler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1H088T4\\SA;Initial Catalog=Pastane;Integrated Security=True");
        private void Urunler_Load(object sender, EventArgs e)
        {  baglanti.Open();

            SqlCommand komut = new SqlCommand("select * from Satıcı",baglanti);
           
            SqlDataReader dr;
          
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                satıcınocombo.Items.Add(dr["satıcıno"]);
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
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Urunler(urunadi,urunfiyat,kullanımtarihi,uretimtarihi,satıcıno) values (@urunadi,@urunfiyat,@kullanımtarihi,@uretimtarihi,@satıcıno)", baglanti);
            komut.Parameters.AddWithValue("@urunadi", txturunadı.Text);
            komut.Parameters.AddWithValue("@urunfiyat", txtfiyat.Text);
            komut.Parameters.AddWithValue("@kullanımtarihi", txtsonkullanma.Text);
            komut.Parameters.AddWithValue("@uretimtarihi", txturetim.Text);
            komut.Parameters.AddWithValue("@satıcıno", satıcınocombo.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            listele("select * from Urunler");
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            listele("select * from Urunler");
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Urunler where urunno=@urunno", baglanti);
            komut.Parameters.AddWithValue("@urunno", txturunno.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            listele("select * from Urunler");
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update  Urunler set urunfiyat='" + txtfiyat.Text.ToString() + "' where urunno='" + txturunno.Text.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            listele("select * from Urunler");
            baglanti.Close();
        }

        private void btnarama_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Urunler where urunadi like '%" + txturunadı.Text + "%'", baglanti);

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
            string urunno = dataGridView1.Rows[sectim].Cells[0].Value.ToString();
            string urunad = dataGridView1.Rows[sectim].Cells[1].Value.ToString();
            string urunfiyat = dataGridView1.Rows[sectim].Cells[2].Value.ToString();
            string urunkullanma = dataGridView1.Rows[sectim].Cells[3].Value.ToString();
            string urunuretim = dataGridView1.Rows[sectim].Cells[4].Value.ToString();
            string satıcıno = dataGridView1.Rows[sectim].Cells[5].Value.ToString();

            txturunno.Text = urunno;
            txturunadı.Text = urunad;
            txtfiyat.Text = urunfiyat;
            txtsonkullanma.Text = urunkullanma;
            txturetim.Text = urunuretim;
            satıcınocombo.Text = satıcıno;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 ana = new Form1();
            ana.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

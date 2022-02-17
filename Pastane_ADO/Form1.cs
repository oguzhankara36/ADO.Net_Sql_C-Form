using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pastane_ADO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saticilar st = new saticilar();
            st.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Urunler urun = new Urunler();
            urun.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            siparis sp = new siparis();
            sp.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Müsteriler ms = new Müsteriler();
            ms.Show();
            this.Show();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

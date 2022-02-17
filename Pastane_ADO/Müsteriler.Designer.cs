
namespace Pastane_ADO
{
    partial class Müsteriler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Müsteriler));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsiparisno = new System.Windows.Forms.ComboBox();
            this.txtmusterino = new System.Windows.Forms.TextBox();
            this.txtmusteriadsoyad = new System.Windows.Forms.TextBox();
            this.txtmusteritel = new System.Windows.Forms.TextBox();
            this.btnlistele = new System.Windows.Forms.Button();
            this.btnarama = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(36, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "müşteri no";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(7, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "musteri ad soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(36, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "müşteri tel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(36, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "sipariş no";
            // 
            // txtsiparisno
            // 
            this.txtsiparisno.FormattingEnabled = true;
            this.txtsiparisno.Location = new System.Drawing.Point(99, 149);
            this.txtsiparisno.Name = "txtsiparisno";
            this.txtsiparisno.Size = new System.Drawing.Size(121, 21);
            this.txtsiparisno.TabIndex = 4;
            // 
            // txtmusterino
            // 
            this.txtmusterino.Location = new System.Drawing.Point(99, 11);
            this.txtmusterino.Name = "txtmusterino";
            this.txtmusterino.Size = new System.Drawing.Size(100, 20);
            this.txtmusterino.TabIndex = 5;
            // 
            // txtmusteriadsoyad
            // 
            this.txtmusteriadsoyad.Location = new System.Drawing.Point(99, 55);
            this.txtmusteriadsoyad.Name = "txtmusteriadsoyad";
            this.txtmusteriadsoyad.Size = new System.Drawing.Size(100, 20);
            this.txtmusteriadsoyad.TabIndex = 6;
            // 
            // txtmusteritel
            // 
            this.txtmusteritel.Location = new System.Drawing.Point(99, 107);
            this.txtmusteritel.Name = "txtmusteritel";
            this.txtmusteritel.Size = new System.Drawing.Size(100, 20);
            this.txtmusteritel.TabIndex = 7;
            // 
            // btnlistele
            // 
            this.btnlistele.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnlistele.BackgroundImage")));
            this.btnlistele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnlistele.Location = new System.Drawing.Point(703, 160);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(90, 63);
            this.btnlistele.TabIndex = 27;
            this.btnlistele.UseVisualStyleBackColor = true;
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // btnarama
            // 
            this.btnarama.BackColor = System.Drawing.Color.White;
            this.btnarama.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnarama.BackgroundImage")));
            this.btnarama.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnarama.Location = new System.Drawing.Point(39, 421);
            this.btnarama.Name = "btnarama";
            this.btnarama.Size = new System.Drawing.Size(82, 63);
            this.btnarama.TabIndex = 26;
            this.btnarama.UseVisualStyleBackColor = false;
            this.btnarama.Click += new System.EventHandler(this.btnarama_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnguncelle.BackgroundImage")));
            this.btnguncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnguncelle.Location = new System.Drawing.Point(39, 351);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(82, 64);
            this.btnguncelle.TabIndex = 25;
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsil.BackgroundImage")));
            this.btnsil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsil.Location = new System.Drawing.Point(39, 282);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(82, 63);
            this.btnsil.TabIndex = 24;
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnekle
            // 
            this.btnekle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnekle.BackgroundImage")));
            this.btnekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnekle.Location = new System.Drawing.Point(39, 203);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(82, 62);
            this.btnekle.TabIndex = 23;
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(423, -4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(370, 158);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Müsteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(852, 539);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnlistele);
            this.Controls.Add(this.btnarama);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.txtmusteritel);
            this.Controls.Add(this.txtmusteriadsoyad);
            this.Controls.Add(this.txtmusterino);
            this.Controls.Add(this.txtsiparisno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Müsteriler";
            this.Text = "Müsteriler";
            this.Load += new System.EventHandler(this.Müsteriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txtsiparisno;
        private System.Windows.Forms.TextBox txtmusterino;
        private System.Windows.Forms.TextBox txtmusteriadsoyad;
        private System.Windows.Forms.TextBox txtmusteritel;
        private System.Windows.Forms.Button btnlistele;
        private System.Windows.Forms.Button btnarama;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
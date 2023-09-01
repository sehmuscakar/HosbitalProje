namespace HosbitalOtomasyon
{
    partial class frmHastalarPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHastalarPaneli));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txthastaid = new System.Windows.Forms.TextBox();
            this.btnhastatemizle = new System.Windows.Forms.Button();
            this.txthastasikayet = new System.Windows.Forms.TextBox();
            this.btnhastaguncelle = new System.Windows.Forms.Button();
            this.btnhastasil = new System.Windows.Forms.Button();
            this.btnhastaekle = new System.Windows.Forms.Button();
            this.txthastasoyadı = new System.Windows.Forms.TextBox();
            this.txthastaad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbbranchhasta = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(725, 329);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(377, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 1);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1112, 310);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbbranchhasta);
            this.groupBox1.Controls.Add(this.txthastaid);
            this.groupBox1.Controls.Add(this.btnhastatemizle);
            this.groupBox1.Controls.Add(this.txthastasikayet);
            this.groupBox1.Controls.Add(this.btnhastaguncelle);
            this.groupBox1.Controls.Add(this.btnhastasil);
            this.groupBox1.Controls.Add(this.btnhastaekle);
            this.groupBox1.Controls.Add(this.txthastasoyadı);
            this.groupBox1.Controls.Add(this.txthastaad);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(10, 317);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(709, 204);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hasta İşlemler Paneli";
            // 
            // txthastaid
            // 
            this.txthastaid.Location = new System.Drawing.Point(569, 110);
            this.txthastaid.Name = "txthastaid";
            this.txthastaid.Size = new System.Drawing.Size(91, 30);
            this.txthastaid.TabIndex = 15;
            this.txthastaid.Visible = false;
            // 
            // btnhastatemizle
            // 
            this.btnhastatemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnhastatemizle.Location = new System.Drawing.Point(559, 140);
            this.btnhastatemizle.Name = "btnhastatemizle";
            this.btnhastatemizle.Size = new System.Drawing.Size(133, 45);
            this.btnhastatemizle.TabIndex = 13;
            this.btnhastatemizle.Text = "Temizle";
            this.btnhastatemizle.UseVisualStyleBackColor = false;
            this.btnhastatemizle.Click += new System.EventHandler(this.btnhastatemizle_Click);
            // 
            // txthastasikayet
            // 
            this.txthastasikayet.Location = new System.Drawing.Point(417, 29);
            this.txthastasikayet.Name = "txthastasikayet";
            this.txthastasikayet.Size = new System.Drawing.Size(275, 30);
            this.txthastasikayet.TabIndex = 11;
            // 
            // btnhastaguncelle
            // 
            this.btnhastaguncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnhastaguncelle.Location = new System.Drawing.Point(244, 140);
            this.btnhastaguncelle.Name = "btnhastaguncelle";
            this.btnhastaguncelle.Size = new System.Drawing.Size(124, 45);
            this.btnhastaguncelle.TabIndex = 10;
            this.btnhastaguncelle.Text = "Güncelle";
            this.btnhastaguncelle.UseVisualStyleBackColor = false;
            this.btnhastaguncelle.Click += new System.EventHandler(this.btnhastaguncelle_Click);
            // 
            // btnhastasil
            // 
            this.btnhastasil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnhastasil.Location = new System.Drawing.Point(405, 140);
            this.btnhastasil.Name = "btnhastasil";
            this.btnhastasil.Size = new System.Drawing.Size(133, 45);
            this.btnhastasil.TabIndex = 9;
            this.btnhastasil.Text = "Sil";
            this.btnhastasil.UseVisualStyleBackColor = false;
            this.btnhastasil.Click += new System.EventHandler(this.btnhastasil_Click);
            // 
            // btnhastaekle
            // 
            this.btnhastaekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnhastaekle.Location = new System.Drawing.Point(61, 140);
            this.btnhastaekle.Name = "btnhastaekle";
            this.btnhastaekle.Size = new System.Drawing.Size(135, 45);
            this.btnhastaekle.TabIndex = 8;
            this.btnhastaekle.Text = "Ekle";
            this.btnhastaekle.UseVisualStyleBackColor = false;
            this.btnhastaekle.Click += new System.EventHandler(this.btnhastaekle_Click);
            // 
            // txthastasoyadı
            // 
            this.txthastasoyadı.Location = new System.Drawing.Point(100, 74);
            this.txthastasoyadı.Name = "txthastasoyadı";
            this.txthastasoyadı.Size = new System.Drawing.Size(223, 30);
            this.txthastasoyadı.TabIndex = 5;
            // 
            // txthastaad
            // 
            this.txthastaad.Location = new System.Drawing.Point(99, 32);
            this.txthastaad.Name = "txthastaad";
            this.txthastaad.Size = new System.Drawing.Size(224, 30);
            this.txthastaad.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Branş:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şikayet:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyadı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı:";
            // 
            // cmbbranchhasta
            // 
            this.cmbbranchhasta.FormattingEnabled = true;
            this.cmbbranchhasta.Location = new System.Drawing.Point(417, 77);
            this.cmbbranchhasta.Name = "cmbbranchhasta";
            this.cmbbranchhasta.Size = new System.Drawing.Size(275, 33);
            this.cmbbranchhasta.TabIndex = 16;
            // 
            // frmHastalarPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 532);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmHastalarPaneli";
            this.Text = "Hastalar Paneli";
            this.Load += new System.EventHandler(this.frmHastalarPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnhastatemizle;
        private System.Windows.Forms.TextBox txthastasikayet;
        private System.Windows.Forms.Button btnhastaguncelle;
        private System.Windows.Forms.Button btnhastasil;
        private System.Windows.Forms.Button btnhastaekle;
        private System.Windows.Forms.TextBox txthastasoyadı;
        private System.Windows.Forms.TextBox txthastaad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txthastaid;
        private System.Windows.Forms.ComboBox cmbbranchhasta;
    }
}
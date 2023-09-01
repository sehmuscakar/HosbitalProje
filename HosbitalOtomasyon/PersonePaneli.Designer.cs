namespace HosbitalOtomasyon
{
    partial class frmPersonePaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonePaneli));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbbranchpersonel = new System.Windows.Forms.ComboBox();
            this.txtpersonelid = new System.Windows.Forms.TextBox();
            this.btnpersoneltemizle = new System.Windows.Forms.Button();
            this.btnpersonelguncelle = new System.Windows.Forms.Button();
            this.btnpersonelsil = new System.Windows.Forms.Button();
            this.btnpersonelekle = new System.Windows.Forms.Button();
            this.txtpersonelsoyadı = new System.Windows.Forms.TextBox();
            this.txtpersonelad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbbranchpersonel);
            this.groupBox1.Controls.Add(this.txtpersonelid);
            this.groupBox1.Controls.Add(this.btnpersoneltemizle);
            this.groupBox1.Controls.Add(this.btnpersonelguncelle);
            this.groupBox1.Controls.Add(this.btnpersonelsil);
            this.groupBox1.Controls.Add(this.btnpersonelekle);
            this.groupBox1.Controls.Add(this.txtpersonelsoyadı);
            this.groupBox1.Controls.Add(this.txtpersonelad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(16, 321);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(709, 204);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel İşlemler Paneli";
            // 
            // cmbbranchpersonel
            // 
            this.cmbbranchpersonel.FormattingEnabled = true;
            this.cmbbranchpersonel.Location = new System.Drawing.Point(425, 54);
            this.cmbbranchpersonel.Name = "cmbbranchpersonel";
            this.cmbbranchpersonel.Size = new System.Drawing.Size(275, 33);
            this.cmbbranchpersonel.TabIndex = 16;
            // 
            // txtpersonelid
            // 
            this.txtpersonelid.Location = new System.Drawing.Point(540, 92);
            this.txtpersonelid.Name = "txtpersonelid";
            this.txtpersonelid.Size = new System.Drawing.Size(91, 30);
            this.txtpersonelid.TabIndex = 15;
            this.txtpersonelid.Visible = false;
            // 
            // btnpersoneltemizle
            // 
            this.btnpersoneltemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnpersoneltemizle.Location = new System.Drawing.Point(559, 140);
            this.btnpersoneltemizle.Name = "btnpersoneltemizle";
            this.btnpersoneltemizle.Size = new System.Drawing.Size(133, 45);
            this.btnpersoneltemizle.TabIndex = 13;
            this.btnpersoneltemizle.Text = "Temizle";
            this.btnpersoneltemizle.UseVisualStyleBackColor = false;
            this.btnpersoneltemizle.Click += new System.EventHandler(this.btnpersoneltemizle_Click);
            // 
            // btnpersonelguncelle
            // 
            this.btnpersonelguncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnpersonelguncelle.Location = new System.Drawing.Point(244, 140);
            this.btnpersonelguncelle.Name = "btnpersonelguncelle";
            this.btnpersonelguncelle.Size = new System.Drawing.Size(124, 45);
            this.btnpersonelguncelle.TabIndex = 10;
            this.btnpersonelguncelle.Text = "Güncelle";
            this.btnpersonelguncelle.UseVisualStyleBackColor = false;
            this.btnpersonelguncelle.Click += new System.EventHandler(this.btnpersonelguncelle_Click);
            // 
            // btnpersonelsil
            // 
            this.btnpersonelsil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnpersonelsil.Location = new System.Drawing.Point(405, 140);
            this.btnpersonelsil.Name = "btnpersonelsil";
            this.btnpersonelsil.Size = new System.Drawing.Size(133, 45);
            this.btnpersonelsil.TabIndex = 9;
            this.btnpersonelsil.Text = "Sil";
            this.btnpersonelsil.UseVisualStyleBackColor = false;
            this.btnpersonelsil.Click += new System.EventHandler(this.btnpersonelsil_Click);
            // 
            // btnpersonelekle
            // 
            this.btnpersonelekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnpersonelekle.Location = new System.Drawing.Point(61, 140);
            this.btnpersonelekle.Name = "btnpersonelekle";
            this.btnpersonelekle.Size = new System.Drawing.Size(135, 45);
            this.btnpersonelekle.TabIndex = 8;
            this.btnpersonelekle.Text = "Ekle";
            this.btnpersonelekle.UseVisualStyleBackColor = false;
            this.btnpersonelekle.Click += new System.EventHandler(this.btnpersonelekle_Click);
            // 
            // txtpersonelsoyadı
            // 
            this.txtpersonelsoyadı.Location = new System.Drawing.Point(100, 74);
            this.txtpersonelsoyadı.Name = "txtpersonelsoyadı";
            this.txtpersonelsoyadı.Size = new System.Drawing.Size(223, 30);
            this.txtpersonelsoyadı.TabIndex = 5;
            // 
            // txtpersonelad
            // 
            this.txtpersonelad.Location = new System.Drawing.Point(99, 32);
            this.txtpersonelad.Name = "txtpersonelad";
            this.txtpersonelad.Size = new System.Drawing.Size(224, 30);
            this.txtpersonelad.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Görevi:";
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(731, 333);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(377, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToOrderColumns = true;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(6, 5);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(1112, 310);
            this.dataGridView3.TabIndex = 4;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // frmPersonePaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 540);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView3);
            this.Name = "frmPersonePaneli";
            this.Text = "Persone Paneli";
            this.Load += new System.EventHandler(this.frmPersonePaneli_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnpersoneltemizle;
        private System.Windows.Forms.Button btnpersonelguncelle;
        private System.Windows.Forms.Button btnpersonelsil;
        private System.Windows.Forms.Button btnpersonelekle;
        private System.Windows.Forms.TextBox txtpersonelsoyadı;
        private System.Windows.Forms.TextBox txtpersonelad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TextBox txtpersonelid;
        private System.Windows.Forms.ComboBox cmbbranchpersonel;
    }
}
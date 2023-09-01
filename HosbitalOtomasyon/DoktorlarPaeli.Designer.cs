namespace HosbitalOtomasyon
{
    partial class frmDoktorlarPaeli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoktorlarPaeli));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbbranchdoktor = new System.Windows.Forms.ComboBox();
            this.txtdoktorid = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btndoktorguncelle = new System.Windows.Forms.Button();
            this.btndoktorsil = new System.Windows.Forms.Button();
            this.btndotorekle = new System.Windows.Forms.Button();
            this.txtdoctorsoyadı = new System.Windows.Forms.TextBox();
            this.txtdoctorad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmdoktorkidem = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdoktorkidem);
            this.groupBox1.Controls.Add(this.cmbbranchdoktor);
            this.groupBox1.Controls.Add(this.txtdoktorid);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btndoktorguncelle);
            this.groupBox1.Controls.Add(this.btndoktorsil);
            this.groupBox1.Controls.Add(this.btndotorekle);
            this.groupBox1.Controls.Add(this.txtdoctorsoyadı);
            this.groupBox1.Controls.Add(this.txtdoctorad);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 312);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(709, 204);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doktor İşlemler Paneli";
            // 
            // cmbbranchdoktor
            // 
            this.cmbbranchdoktor.FormattingEnabled = true;
            this.cmbbranchdoktor.Location = new System.Drawing.Point(417, 28);
            this.cmbbranchdoktor.Name = "cmbbranchdoktor";
            this.cmbbranchdoktor.Size = new System.Drawing.Size(275, 33);
            this.cmbbranchdoktor.TabIndex = 15;
            // 
            // txtdoktorid
            // 
            this.txtdoktorid.Location = new System.Drawing.Point(601, 112);
            this.txtdoktorid.Name = "txtdoktorid";
            this.txtdoktorid.Size = new System.Drawing.Size(91, 30);
            this.txtdoktorid.TabIndex = 14;
            this.txtdoktorid.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(559, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 45);
            this.button1.TabIndex = 13;
            this.button1.Text = "Temizle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btndoktorguncelle
            // 
            this.btndoktorguncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btndoktorguncelle.Location = new System.Drawing.Point(244, 140);
            this.btndoktorguncelle.Name = "btndoktorguncelle";
            this.btndoktorguncelle.Size = new System.Drawing.Size(124, 45);
            this.btndoktorguncelle.TabIndex = 10;
            this.btndoktorguncelle.Text = "Güncelle";
            this.btndoktorguncelle.UseVisualStyleBackColor = false;
            this.btndoktorguncelle.Click += new System.EventHandler(this.btndoktorguncelle_Click);
            // 
            // btndoktorsil
            // 
            this.btndoktorsil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btndoktorsil.Location = new System.Drawing.Point(405, 140);
            this.btndoktorsil.Name = "btndoktorsil";
            this.btndoktorsil.Size = new System.Drawing.Size(133, 45);
            this.btndoktorsil.TabIndex = 9;
            this.btndoktorsil.Text = "Sil";
            this.btndoktorsil.UseVisualStyleBackColor = false;
            this.btndoktorsil.Click += new System.EventHandler(this.btndoktorsil_Click);
            // 
            // btndotorekle
            // 
            this.btndotorekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btndotorekle.Location = new System.Drawing.Point(61, 140);
            this.btndotorekle.Name = "btndotorekle";
            this.btndotorekle.Size = new System.Drawing.Size(135, 45);
            this.btndotorekle.TabIndex = 8;
            this.btndotorekle.Text = "Ekle";
            this.btndotorekle.UseVisualStyleBackColor = false;
            this.btndotorekle.Click += new System.EventHandler(this.btndotorekle_Click);
            // 
            // txtdoctorsoyadı
            // 
            this.txtdoctorsoyadı.Location = new System.Drawing.Point(100, 74);
            this.txtdoctorsoyadı.Name = "txtdoctorsoyadı";
            this.txtdoctorsoyadı.Size = new System.Drawing.Size(223, 30);
            this.txtdoctorsoyadı.TabIndex = 5;
            // 
            // txtdoctorad
            // 
            this.txtdoctorad.Location = new System.Drawing.Point(99, 32);
            this.txtdoctorad.Name = "txtdoctorad";
            this.txtdoctorad.Size = new System.Drawing.Size(224, 30);
            this.txtdoctorad.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(340, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kıdemi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Branşı:";
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, -4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1102, 310);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(727, 326);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(377, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // cmdoktorkidem
            // 
            this.cmdoktorkidem.FormattingEnabled = true;
            this.cmdoktorkidem.Location = new System.Drawing.Point(417, 79);
            this.cmdoktorkidem.Name = "cmdoktorkidem";
            this.cmdoktorkidem.Size = new System.Drawing.Size(275, 33);
            this.cmdoktorkidem.TabIndex = 16;
            // 
            // frmDoktorlarPaeli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1116, 530);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDoktorlarPaeli";
            this.Text = "DoktorlarPaeli";
            this.Load += new System.EventHandler(this.frmDoktorlarPaeli_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdoctorsoyadı;
        private System.Windows.Forms.TextBox txtdoctorad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btndoktorguncelle;
        private System.Windows.Forms.Button btndoktorsil;
        private System.Windows.Forms.Button btndotorekle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtdoktorid;
        private System.Windows.Forms.ComboBox cmbbranchdoktor;
        private System.Windows.Forms.ComboBox cmdoktorkidem;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HosbitalOtomasyon
{
    public partial class frmDoktorlarPaeli : Form
    {
        public frmDoktorlarPaeli()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Server=DESKTOP-PBFD0LU; Initial Catalog=TigrisHosbitalProject; integrated security=true");
     
        DoctorDal _doctorDal = new DoctorDal();// ilgili classı burda çağırdık kullanmak için
        private void frmDoktorlarPaeli_Load(object sender, EventArgs e)
        {
         
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from Branchs", baglanti);
            SqlDataReader read=komut.ExecuteReader();
            while (read.Read())
            {
                cmbbranchdoktor.Items.Add(read["Name"]);
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select * from doktorUnvan", baglanti);
            SqlDataReader read2 = komut2.ExecuteReader();
            while (read2.Read())
            {
                cmdoktorkidem.Items.Add(read2["Name"]);
            }
            baglanti.Close();
            VeriYukle();
        }

        void VeriYukle()// verilerimizi db den alıp bu metota çağıracaz 
        {
            dataGridView1.DataSource = _doctorDal.GetAll();
        }

        private void btndotorekle_Click(object sender, EventArgs e)
        {
            Doctor doctor = new Doctor
            {
                Name = txtdoctorad.Text,
                Surname = txtdoctorsoyadı.Text,
                Branch = cmbbranchdoktor.Text,
                Degree=cmdoktorkidem.Text
            };
            _doctorDal.AddDoctor(doctor);
            VeriYukle();
            MessageBox.Show("Kayıt başarıyla Eklendi","TigrisTech Yazılım",MessageBoxButtons.OK,MessageBoxIcon.Information);//messagebox araç kutusu özelikleri 
            Temizle();
        }


        void Temizle()
        {
            txtdoctorad.Clear();// temizleme 
            txtdoctorsoyadı.Text = "";//temizleme
            cmbbranchdoktor.Text = " ";
            cmdoktorkidem.Text = " ";
        }

        private void btndoktorguncelle_Click(object sender, EventArgs e)
        {
            Doctor doctor = new Doctor
            {
                Id=Convert.ToInt16(txtdoktorid.Text),
                Name = txtdoctorad.Text,
                Surname = txtdoctorsoyadı.Text,
                Branch=cmbbranchdoktor.Text,
                Degree= cmdoktorkidem.Text,
        
            };
           _doctorDal.DoctorUpdate(doctor);
            VeriYukle();
            MessageBox.Show("Kayıt Başarıyla Güncellendi", "TigrisTech Yazılım", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Temizle();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)//tıklanma olduğunda veriler araçalrımıza gelmesi için 
        {
            txtdoktorid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtdoctorad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtdoctorsoyadı.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cmbbranchdoktor.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cmdoktorkidem.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Temizle();
        }

    

        private void btndoktorsil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            _doctorDal.RemoveDoctor(id);
            MessageBox.Show("Kayıt Başarıyla Silinid", "TigrisTech Yazılım", MessageBoxButtons.OK, MessageBoxIcon.Information);
            VeriYukle();
        }

        //private void cmbbranch_Click(object sender, EventArgs e)
        //{
          
        //}

     
    }
}

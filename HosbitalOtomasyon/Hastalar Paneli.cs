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
    public partial class frmHastalarPaneli : Form
    {
        public frmHastalarPaneli()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Server=DESKTOP-PBFD0LU; Initial Catalog=TigrisHosbitalProject; integrated security=true");
        PatientDal _patientDal = new PatientDal();
        private void frmHastalarPaneli_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from Branchs", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
               cmbbranchhasta.Items.Add(read["Name"]);
            }
            baglanti.Close();
            PatientVeriYukle();
        }

       void PatientVeriYukle()
        {
            dataGridView2.DataSource = _patientDal.PatientGetAll();
        }

        private void btnhastaekle_Click(object sender, EventArgs e)
        {
            Patient patient=new Patient
            {
                Name = txthastaad.Text,
                Surname = txthastasoyadı.Text,
                Comment = txthastasikayet.Text,
                Branch = cmbbranchhasta.Text
            };
            _patientDal.AddPatient(patient);
            PatientVeriYukle();
            MessageBox.Show("Kayıt başarıyla Eklendi", "TigrisTech Yazılım", MessageBoxButtons.OK, MessageBoxIcon.Information);//messagebox araç kutusu özelikleri 
            Temizle();

        }

        void Temizle()
        {
            txthastaad.Clear();// temizleme 
            txthastasoyadı.Text = "";//temizleme
            txthastasikayet.Text = "";
            cmbbranchhasta.Text = " ";
          
        }

        private void btnhastatemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txthastaid.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            txthastaad.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            txthastasoyadı.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            txthastasikayet.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            cmbbranchhasta.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnhastaguncelle_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient
            {
                ID=Convert.ToInt16(txthastaid.Text),
                Name=txthastaad.Text,
                Surname=txthastasoyadı.Text,
                Comment=txthastasikayet.Text,
                Branch=cmbbranchhasta.Text,
            };
            _patientDal.PatientUpdate(patient);
            PatientVeriYukle();
            MessageBox.Show("Kayıt Başarıyla Güncellendi", "TigrisTech Yazılım", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Temizle();
        }

        private void btnhastasil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(txthastaid.Text);
            _patientDal.PatientDelete(id);
            MessageBox.Show("Kayıt Başarıyla Silinid", "TigrisTech Yazılım", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PatientVeriYukle();
        }
    }
}

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
    public partial class frmPersonePaneli : Form
    {
        public frmPersonePaneli()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Server=DESKTOP-PBFD0LU; Initial Catalog=TigrisHosbitalProject; integrated security=true");
        EmployeeDal _employeeDal = new EmployeeDal();// EmloyeeDal classını _employeeDal nesnesi ile  burada çağıryoruz 
        private void frmPersonePaneli_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select * from PersonelGorev", baglanti);
            SqlDataReader read2 = komut2.ExecuteReader();
            while (read2.Read())
            {
                cmbbranchpersonel.Items.Add(read2["Name"]);
            }
            baglanti.Close();
            EmplyeeVeriYukle();
        }

        public void EmplyeeVeriYukle()
        {
            dataGridView3.DataSource = _employeeDal.EmployeeGetAll();
        }

        private void btnpersonelekle_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee
            {
                Name = txtpersonelad.Text,
                Surname = txtpersonelsoyadı.Text,
                Duty = cmbbranchpersonel.Text
            };
            _employeeDal.AddEmployee(employee);
            EmplyeeVeriYukle();
            MessageBox.Show("Kayıt başarıyla Eklendi", "TigrisTech Yazılım", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Temizle();
        }

        void Temizle()
        {
            txtpersonelad.Clear();// temizleme 
            txtpersonelsoyadı.Text = "";//temizleme
            cmbbranchpersonel.Text = " ";
        }

        private void btnpersoneltemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtpersonelid.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();
            txtpersonelad.Text = dataGridView3.CurrentRow.Cells[1].Value.ToString();
            txtpersonelsoyadı.Text = dataGridView3.CurrentRow.Cells[2].Value.ToString();
            cmbbranchpersonel.Text = dataGridView3.CurrentRow.Cells[3].Value.ToString();
           
        }

        private void btnpersonelsil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtpersonelid.Text);
            _employeeDal.EmployeeDelete(id);
            MessageBox.Show("Kayıt Başarıyla Silinid", "TigrisTech Yazılım", MessageBoxButtons.OK, MessageBoxIcon.Information);
            EmplyeeVeriYukle();
        }

        private void btnpersonelguncelle_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee
            {
                ID = Convert.ToInt32(txtpersonelid.Text),
                Name = txtpersonelad.Text,
                Surname = txtpersonelsoyadı.Text,
                Duty = cmbbranchpersonel.Text
            };
            _employeeDal.EmployeeUpdate(employee);
            EmplyeeVeriYukle();
            MessageBox.Show("Kayıt Başarıyla Güncellendi", "TigrisTech Yazılım", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Temizle();
        }
    }
}

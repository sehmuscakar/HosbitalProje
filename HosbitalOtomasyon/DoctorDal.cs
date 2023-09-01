using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HosbitalOtomasyon
{
    public class DoctorDal
    {
        public List<Doctor> GetAll()//Metot oluşturduk 
        {
            List<Doctor> doctors = new List<Doctor>();// list sınıfından doctors nesnesini türetik
            SqlConnection sqlConnection = new SqlConnection("Server=DESKTOP-PBFD0LU; Initial Catalog=TigrisHosbitalProject; integrated security=true");//veritabanı bağlantısı için 
            if (sqlConnection.State == ConnectionState.Closed)//tekar tekrar open yapmamk için 
            {
                sqlConnection.Open();
            }

            SqlCommand sqlCommand = new SqlCommand("select * from DoctorTable", sqlConnection);//db soruguları için 
            

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();//okuma işini yapıyoruuz
            while (sqlDataReader.Read())
            {
                Doctor doctor = new Doctor//doctor sınıfından nesne doctor nesnesii oluşturduk, bu nesne db den verileri çekmemizi sağlayacak 
                {
                    Id = Convert.ToInt32(sqlDataReader["ID"]),// Id viual studio da tanımladığımız isim ID db deki isim
                    Name = sqlDataReader["Name"].ToString(),
                    Surname = sqlDataReader["Surname"].ToString(),
                    Branch = sqlDataReader["Branch"].ToString(),
                    Degree = sqlDataReader["Degree"].ToString(),
                };
                doctors.Add(doctor);//burda doctor nesnesine ekledik yani veri tabanınddan çektiğimiz alan isimlerini burda tanımladığımız propertylerine atadık

            }
            sqlConnection.Close();

            return doctors;// bu nesneyi return yaptık çünkü list veri tipinde metot tanımladık 

        }

        public void AddDoctor(Doctor doctor)
        {
            SqlConnection sqlConnection = new SqlConnection("Server=DESKTOP-PBFD0LU; Initial Catalog=TigrisHosbitalProject; integrated security=true");
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            SqlCommand sqlCommand = new SqlCommand("Insert Into DoctorTable values(@p1,@p2,@p3,@p4)", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@p1", doctor.Name);
            sqlCommand.Parameters.AddWithValue("@p2", doctor.Surname);
            sqlCommand.Parameters.AddWithValue("@p3", doctor.Branch);
            sqlCommand.Parameters.AddWithValue("@p4", doctor.Degree);
            sqlCommand.ExecuteNonQuery();//değişiklikleri kaydediyor
            sqlConnection.Close();//bağlantıyı kapatıyor
        }

        public void DoctorUpdate(Doctor doctor)
        {
            SqlConnection sqlConnection = new SqlConnection("Server=DESKTOP-PBFD0LU; Initial Catalog=TigrisHosbitalProject; integrated security=true");
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            SqlCommand sqlCommand = new SqlCommand("Update DoctorTable set Name=@p1,Surname=@p2,Branch=@p3,Degree=@p4 where Id=@ID", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@p1", doctor.Name);
            sqlCommand.Parameters.AddWithValue("@p2", doctor.Surname);
            sqlCommand.Parameters.AddWithValue("@p3", doctor.Branch);
            sqlCommand.Parameters.AddWithValue("@p4", doctor.Degree);
            sqlCommand.Parameters.AddWithValue("@ID", doctor.Id);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public void RemoveDoctor(int id)
        {
            SqlConnection sqlConnection = new SqlConnection("Server=DESKTOP-PBFD0LU; Initial Catalog=TigrisHosbitalProject; integrated security=true");
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            SqlCommand sqlCommand = new SqlCommand("Delete From DoctorTable where ID=@p1", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@p1", id);//paremetryi verdik
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HosbitalOtomasyon
{
    public class PatientDal//HattaDal
    {
        public List<Patient> PatientGetAll()
        {
            List<Patient> patients = new List<Patient>();
            SqlConnection sqlConnection = new SqlConnection("Server=DESKTOP-PBFD0LU; Initial Catalog=TigrisHosbitalProject; integrated security=true");
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }

            SqlCommand sqlCommand = new SqlCommand("select * from PatientTable", sqlConnection);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Patient patient = new Patient
                {
                    ID = Convert.ToInt32(sqlDataReader["ID"]),
                    Name = sqlDataReader["Name"].ToString(),
                    Surname = sqlDataReader["Surname"].ToString(),
                    Comment = sqlDataReader["Comment"].ToString(),
                    Branch = sqlDataReader["Branch"].ToString()

                };
                patients.Add(patient);

            }
            sqlConnection.Close();

            return patients;

        }

        public void AddPatient(Patient patient)
        {
            SqlConnection sqlConnection = new SqlConnection("Server=DESKTOP-PBFD0LU; Initial Catalog=TigrisHosbitalProject; integrated security=true");
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            SqlCommand sqlCommand = new SqlCommand("Insert Into PatientTable values(@p1,@p2,@p3,@p4)", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@p1", patient.Name);
            sqlCommand.Parameters.AddWithValue("@p2", patient.Surname);
            sqlCommand.Parameters.AddWithValue("@p3", patient.Comment);
            sqlCommand.Parameters.AddWithValue("@p4", patient.Branch);
            sqlCommand.ExecuteNonQuery();//değişiklikleri kaydediyor
            sqlConnection.Close();//bağlantıyı kapatıyor
        }


        public void PatientUpdate(Patient patient)
        {
            SqlConnection sqlConnection = new SqlConnection("Server=DESKTOP-PBFD0LU; Initial Catalog=TigrisHosbitalProject; integrated security=true");
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            SqlCommand sqlCommand = new SqlCommand("Update PatientTable set Name=@p1,Surname=@p2,Comment=@p3,Branch=@p4 where Id=@id", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@p1", patient.Name);
            sqlCommand.Parameters.AddWithValue("@p2", patient.Surname);
            sqlCommand.Parameters.AddWithValue("@p3", patient.Comment);
            sqlCommand.Parameters.AddWithValue("@p4", patient.Branch);
            sqlCommand.Parameters.AddWithValue("@id", patient.ID);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }


        public void PatientDelete(int id)
        {
            SqlConnection sqlConnection = new SqlConnection("Server=DESKTOP-PBFD0LU; Initial Catalog=TigrisHosbitalProject; integrated security=true");
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            SqlCommand sqlCommand = new SqlCommand("Delete From PatientTable where ID=@p1", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@p1", id);//paremetryi verdik
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
    }
    
   

}
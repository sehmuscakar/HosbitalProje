using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HosbitalOtomasyon
{
    public class EmployeeDal
    {
        public List<Employee> EmployeeGetAll()
        {
            List<Employee> employees = new List<Employee>();
            SqlConnection sqlConnection = new SqlConnection("Server=DESKTOP-PBFD0LU; Initial Catalog=TigrisHosbitalProject; integrated security=true");
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }

            SqlCommand sqlCommand = new SqlCommand("select * from EmployeeTable", sqlConnection);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Employee employee= new Employee
                {
                    ID = Convert.ToInt32(sqlDataReader["ID"]),
                    Name = sqlDataReader["Name"].ToString(),
                    Surname = sqlDataReader["Surname"].ToString(),
                    Duty = sqlDataReader["Duty"].ToString(),
                };
                employees.Add(employee);

            }
            sqlConnection.Close();

            return employees;

        }

        public void AddEmployee(Employee employee)
        {
            SqlConnection sqlConnection = new SqlConnection("Server=DESKTOP-PBFD0LU; Initial Catalog=TigrisHosbitalProject; integrated security=true");
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            SqlCommand sqlCommand = new SqlCommand("Insert Into EmployeeTable values(@p1,@p2,@p3)", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@p1", employee.Name);
            sqlCommand.Parameters.AddWithValue("@p2", employee.Surname);
            sqlCommand.Parameters.AddWithValue("@p3", employee.Duty);
            sqlCommand.ExecuteNonQuery();//değişiklikleri kaydediyor
            sqlConnection.Close();//bağlantıyı kapatıyor
        }

        public void EmployeeUpdate(Employee employee)
        {
            SqlConnection sqlConnection = new SqlConnection("Server=DESKTOP-PBFD0LU; Initial Catalog=TigrisHosbitalProject; integrated security=true");
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            SqlCommand sqlCommand = new SqlCommand("Update EmployeeTable set Name=@p1,Surname=@p2,Duty=@p3 where Id=@id", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@p1", employee.Name);
            sqlCommand.Parameters.AddWithValue("@p2", employee.Surname);
            sqlCommand.Parameters.AddWithValue("@p3", employee.Duty);
            sqlCommand.Parameters.AddWithValue("@id", employee.ID);
         
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public void EmployeeDelete(int id)
        {
            SqlConnection sqlConnection = new SqlConnection("Server=DESKTOP-PBFD0LU; Initial Catalog=TigrisHosbitalProject; integrated security=true");
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            SqlCommand sqlCommand = new SqlCommand("Delete From EmployeeTable where ID=@p1", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@p1", id);//paremetryi verdik
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
    }
}

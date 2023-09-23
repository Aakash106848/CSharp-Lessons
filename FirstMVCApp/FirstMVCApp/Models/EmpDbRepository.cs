using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.Data.SqlClient;
using System.Data;

namespace FirstMVCApp.Models
{
    public class EmpDbRepository
    {
        public static List<CreateEmp>GetEmpList() 
        {
            List<CreateEmp> emplist = new List<CreateEmp>();
            using (SqlConnection cn = SqlHelper.CreateConnection()) 
            {
                if (cn.State != System.Data.ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand selectempcmd = cn.CreateCommand();
                string selectAllEmps = "Select * from emptbl_x";
                selectempcmd.CommandText = selectAllEmps;
                SqlDataReader empdr = selectempcmd.ExecuteReader();
                while (empdr.Read()) 
                {
                    CreateEmp emp = new CreateEmp
                    {
                        eno = empdr.GetInt32(0),
                        name = empdr.GetString(1),
                        salary = empdr.GetDecimal(2),
                        city = empdr.GetString(3)
                    };
                    emplist.Add(emp);
                }
            }
            return emplist;
        }
        public static CreateEmp GetEmpById(int id)
        {
            CreateEmp? empFound = null;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != System.Data.ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand selectempcmd = cn.CreateCommand();
                string selectEmps = "Select * from emptbl_x where eno=@id";
                selectempcmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                selectempcmd.CommandText = selectEmps;
                SqlDataReader empdr = selectempcmd.ExecuteReader();
                while (empdr.Read())
                {
                    empFound = new CreateEmp
                    {
                        eno = empdr.GetInt32(0),
                        name = empdr.GetString(1),
                        salary = empdr.GetDecimal(2),
                        city = empdr.GetString(3)
                    };
                }
            }
            return empFound;
        }
        public static int AddNewEmployee(CreateEmp newEmp) 
        {
            int query_result = 0;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand insertEmpcmd = cn.CreateCommand();
                String insertNewEmpQuery = "insert into emptbl_x values( @id,@name,@salary,@city )";
                insertEmpcmd.Parameters.Add("@id", SqlDbType.Int).Value = newEmp.eno;
                insertEmpcmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = newEmp.name;
                insertEmpcmd.Parameters.Add("@city", SqlDbType.NVarChar).Value = newEmp.city;
                insertEmpcmd.Parameters.Add("@salary", SqlDbType.Decimal).Value = newEmp.salary;
                insertEmpcmd.CommandText = insertNewEmpQuery;
                query_result = insertEmpcmd.ExecuteNonQuery();
            }
            return query_result;
            
        }
        public static int UpdateEmp(CreateEmp ModifiedEmp) 
        {
            int query_result = 0;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand updateEmpcmd = cn.CreateCommand();
                String updateEmpQuery = "Update emptbl_x set name=@name, salary=@salary, city=@city where eno=@id";
                updateEmpcmd.Parameters.Add("@id", SqlDbType.Int).Value = ModifiedEmp.eno;
                updateEmpcmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = ModifiedEmp.name;
                updateEmpcmd.Parameters.Add("@city", SqlDbType.NVarChar).Value = ModifiedEmp.city;
                updateEmpcmd.Parameters.Add("@salary", SqlDbType.Decimal).Value = ModifiedEmp.salary;
                updateEmpcmd.CommandText = updateEmpQuery;
                query_result = updateEmpcmd.ExecuteNonQuery();
            }
            return query_result;
        }
        public static  int DeleteEmp(int id) 
        {
            int query_result = 0;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand deleteEmpcmd = cn.CreateCommand();
                String deleteEmpQuery = "Delete from emptbl_x where eno=@id";
                deleteEmpcmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                deleteEmpcmd.CommandText = deleteEmpQuery;
                query_result = deleteEmpcmd.ExecuteNonQuery();
            }
            return query_result;
            
        }
    }
}

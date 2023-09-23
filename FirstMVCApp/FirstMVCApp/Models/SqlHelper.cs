using Microsoft.Data.SqlClient;

namespace FirstMVCApp.Models
{
    public class SqlHelper
    {
        //Factory method
        public static SqlConnection CreateConnection() 
        {   
            var connstring = @"server=200411LTP2750\SQLEXPRESS;database=testdb;integrated security=true;Encrypt=false;";
            SqlConnection sqlcn = new SqlConnection(connstring);
            return sqlcn;
        }
    }
}

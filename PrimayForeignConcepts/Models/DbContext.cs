using System.Data;
using System.Data.SqlClient;

namespace PrimayForeignConcepts.Models
{
    public class DbContext
    {
        String db = "Data Source=.;Initial Catalog=demo;Integrated Security=True";
        public bool AddEmployee(Employee emp)
        {

            try
            {
                SqlConnection con = new SqlConnection(db);
                con.Open();
                SqlCommand cmd = new SqlCommand("spAddEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmployeeName", emp.EmployeeName);
                cmd.Parameters.AddWithValue("@DepartmentId", emp.DepartmentId);

                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            { 
            
            }
            
          
            return false;
        }
    }
}

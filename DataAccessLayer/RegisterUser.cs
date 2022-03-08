using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using BusinessLogicObject;

namespace DataAccessLayer
{
    public class RegisterUser
    {
        SqlConnection _con = null;
        SqlCommand _cmd = null;
        SqlDataReader _dr = null;
        string _connectionString = null;
        int rowAffected = 0;
        public RegisterUser()
        {
            /*_connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;*/
            _connectionString = "Data source = SUYCOKHWDSK129;Initial Catalog = adoSamples; integrated security=true;";
            _con = new SqlConnection(_connectionString);
            _con.Open();
        }
        public void Add(User data)
        {
            try
            {
                _cmd = new SqlCommand("CreateUser", _con);
                _cmd.CommandType = System.Data.CommandType.StoredProcedure;
                _cmd.Parameters.AddWithValue("@id", data.id);
                _cmd.Parameters.AddWithValue("@firstName", data.firstName);
                _cmd.Parameters.AddWithValue("@lastName", data.lastName);
                _cmd.Parameters.AddWithValue("@email", data.email);
                _cmd.Parameters.AddWithValue("@password", data.password);

                rowAffected = _cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                _con.Close();
            }




            
        }

        
    }
}

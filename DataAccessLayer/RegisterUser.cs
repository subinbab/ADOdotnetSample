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
        internal SqlConnection _con = null;
        internal SqlCommand _cmd = null;
        internal SqlDataReader _dr = null;
        internal string _connectionString = null;
        internal int rowAffected = 0;
        public RegisterUser()
        {
            /*_connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;*/
            _connectionString = "Data source = DESKTOP-OFQARBL\\SQLEXPRESS;Initial Catalog = adoSamples; integrated security=true;";
            _con = new SqlConnection(_connectionString);
            _con.Open();
        }
        public void Add(User data)
        {
            try
            {
                register rg = new register();
                rg.addUser(data);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                _con.Close();
            }
            
        }
        public bool Auth(UserLogin data)
        {
            try
            {
                Authenticate auth = new Authenticate();
                if (auth.Auth(data))
                {
                    return true;
                }
                return false;
            }
            catch(Exception ex)
            {
                return false;
            }
            finally
            {
                _con.Close();
            }
            
        }

        
    }
}

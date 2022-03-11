using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.user;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer.Message
{
    internal class Messages :UserBaseModel
    {
        

        Messages msg = null;
        public Messages(string connectionString)
        {
            /*_connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            _con = new SqlConnection(_connectionString);*/
            _connectionString = connectionString;
        }
        public  string GetMessage(int messageId)
        {
            try
            {
                /*_con.Open();*/
                _cmd = new SqlCommand("GetMessage", _con);
                _cmd.CommandType = System.Data.CommandType.StoredProcedure;
                _cmd.Parameters.AddWithValue("@messageId", messageId);
                _cmd.Parameters.Add("@message", System.Data.SqlDbType.VarChar);
                _cmd.Parameters["@message"].Direction = ParameterDirection.Output;

                _cmd.ExecuteNonQuery();
                string message = Convert.ToString(_cmd.Parameters["@message"].Value);
                return message;
            }
            catch (Exception ex)
            {

                return "Site in service";
            }
            finally
            {
                _con.Close();
            }
            
        }
    }
}

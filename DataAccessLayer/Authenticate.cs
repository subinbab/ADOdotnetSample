using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicObject;

/*namespace DataAccessLayer
{
    internal class Authenticate
    {
        RegisterUser reg = null;
        public Authenticate()
        {
            reg = new RegisterUser();
            
        }
        public bool Auth(UserLogin data)
        {
            try
            {
                reg._cmd = new SqlCommand("Authenticate", reg._con);
                reg._cmd.CommandType = System.Data.CommandType.StoredProcedure;
                reg._cmd.Parameters.AddWithValue("@userName", data.userName);
                reg._cmd.Parameters.AddWithValue("@password", data.password);

                *//*SqlParameter outputparam = new SqlParameter();
                outputparam.ParameterName = "@check";
                outputparam.Direction = System.Data.ParameterDirection.Output;
                outputparam.SqlDbType = System.Data.SqlDbType.Int;
                reg._cmd.Parameters.Add(outputparam);*//*


                reg._cmd.Parameters.Add("@firstName", SqlDbType.VarChar, 150);
                reg._cmd.Parameters["@firstName"].Direction = ParameterDirection.Output;
                reg._cmd.Parameters.Add("@lastName", SqlDbType.VarChar, 150);
                reg._cmd.Parameters["@lastName"].Direction = ParameterDirection.Output;
                reg._cmd.Parameters.Add("@email", SqlDbType.VarChar, 150);
                reg._cmd.Parameters["@email"].Direction = ParameterDirection.Output;
                reg._cmd.Parameters.Add("@check", SqlDbType.Bit);
                reg._cmd.Parameters["@check"].Direction = ParameterDirection.Output;

                reg.rowAffected = reg._cmd.ExecuteNonQuery();
                int check = Convert.ToInt32(reg._cmd.Parameters["@check"].Value);
                *//*int check = Convert.ToInt32(outputparam.Value);*//*


                if (check==1)
                {
                    return true;
                }
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
*/
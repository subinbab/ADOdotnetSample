using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicObject;

namespace DataAccessLayer
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
                reg._cmd.Parameters.AddWithValue("@email", data.userName);
                reg._cmd.Parameters.AddWithValue("@password", data.password);

                SqlParameter outputparam = new SqlParameter();
                outputparam.ParameterName = "@check";
                outputparam.Direction = System.Data.ParameterDirection.Output;
                outputparam.SqlDbType = System.Data.SqlDbType.Int;
                reg._cmd.Parameters.Add(outputparam);

                int check = Convert.ToInt32(outputparam.Value);

                reg.rowAffected = reg._cmd.ExecuteNonQuery();
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

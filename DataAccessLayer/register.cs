using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicObject;

/*namespace DataAccessLayer
{
    internal class register
    {
        RegisterUser reg = null;
        public register()
        {
            reg = new RegisterUser();
        }
        public void addUser(User data)
        {
            try
            {
                reg._cmd = new SqlCommand("CreateUser", reg._con);
                reg._cmd.CommandType = System.Data.CommandType.StoredProcedure;
                reg._cmd.Parameters.AddWithValue("@id", data.id);
                reg._cmd.Parameters.AddWithValue("@firstName", data.firstName);
                reg._cmd.Parameters.AddWithValue("@lastName", data.lastName);
                reg._cmd.Parameters.AddWithValue("@email", data.email);
                reg._cmd.Parameters.AddWithValue("@password", data.password);

                reg.rowAffected = reg._cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
*/
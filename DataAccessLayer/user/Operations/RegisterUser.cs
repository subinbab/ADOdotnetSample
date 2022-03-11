using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicObject;
using DataAccessLayer.Message;

namespace DataAccessLayer.user.Operations
{
    internal class RegisterUser : UserBaseModel
    {
        Messages msg = null;
        public RegisterUser(string _connectionString)
        {
            _cmd = new SqlCommand();
            _con = new SqlConnection(_connectionString);
            _userAccountModel = new BusinessLogicObject.User.UserAccountModel();
            _userLoginModel = new UserLoginModel();
            _userRegisterModel = new UserRegisterModel();
            msg = new Messages(_connectionString);

        }
        internal  string RegisterUserMethod(UserRegisterModel userRegisterModel)
        {
            try
            {
                _con.Open();
                _cmd = new SqlCommand("CreateUser",_con);
                _cmd.CommandType = System.Data.CommandType.StoredProcedure;
                _cmd.Parameters.AddWithValue("@id", _userRegisterModel.id);
                _cmd.Parameters.AddWithValue("@firstName", _userRegisterModel.firstName);
                _cmd.Parameters.AddWithValue("@lastName", _userRegisterModel.lastName);
                _cmd.Parameters.AddWithValue("@email", _userRegisterModel.email);
                _cmd.Parameters.AddWithValue("@password", _userRegisterModel.password);

                _cmd.Parameters.Add("@message", System.Data.SqlDbType.Int);
                _cmd.Parameters["@message"].Direction = System.Data.ParameterDirection.Output;

                _rowAffected = _cmd.ExecuteNonQuery();
                int messageId = Convert.ToInt32(_cmd.Parameters["@message"].Value);
                return msg.GetMessage(messageId);
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

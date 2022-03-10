using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicObject;

namespace DataAccessLayer.user.Operations
{
    internal class RegisterUser : UserBaseModel
    {
        public RegisterUser()
        {
            _cmd = new SqlCommand();
            _con = new SqlConnection(_connectionString);
            _userAccountModel = new BusinessLogicObject.User.UserAccountModel();
            _userLoginModel = new UserLoginModel();
            _userRegisterModel = new UserRegisterModel();

        }
        internal  int RegisterUserMethod(UserRegisterModel userRegisterModel)
        {
            try
            {
                _cmd = new SqlCommand("CreateUser",_con);
                _cmd.CommandType = System.Data.CommandType.StoredProcedure;
                _cmd.Parameters.AddWithValue("@id", _userRegisterModel.id);
                _cmd.Parameters.AddWithValue("@firstName", _userRegisterModel.firstName);
                _cmd.Parameters.AddWithValue("@lastName", _userRegisterModel.lastName);
                _cmd.Parameters.AddWithValue("@email", _userRegisterModel.email);
                _cmd.Parameters.AddWithValue("@password", _userRegisterModel.password);

                _rowAffected = _cmd.ExecuteNonQuery();
                return _rowAffected;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
    }
}

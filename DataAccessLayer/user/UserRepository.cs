using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicObject;
using BusinessLogicObject.User;
using DataAccessLayer.Message;
using DataAccessLayer.user.Operations;

namespace DataAccessLayer.user
{
    public class UserRepository : IUserRepository 
    {
        internal string _connectionString = null;
        RegisterUser _register = null;
        

        public UserRepository()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            _register = new RegisterUser(_connectionString);
            
        }
        public UserAccountModel LoginUser(UserLoginModel userLoginModel)
        {
            throw new NotImplementedException();
        }

        public string RegisterUser(UserRegisterModel userRegisterModel)
        {
            return _register.RegisterUserMethod(userRegisterModel);
        }
    }
}

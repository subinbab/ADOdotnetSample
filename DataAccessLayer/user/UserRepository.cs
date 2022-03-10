using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicObject;
using BusinessLogicObject.User;

namespace DataAccessLayer.user
{
    public class UserRepository : IUserRepository 
    {
        internal string _connectionString = null;

        public UserRepository()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }
        public UserAccountModel LoginUser(UserLoginModel userLoginModel)
        {
            throw new NotImplementedException();
        }

        public int RegisterUser(UserRegisterModel userRegisterModel)
        {
            return RegisterUser(userRegisterModel);
        }
    }
}

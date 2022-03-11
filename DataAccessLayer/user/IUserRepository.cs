using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicObject;
using BusinessLogicObject.User;

namespace DataAccessLayer.user
{
    public interface IUserRepository
    {
        string RegisterUser(UserRegisterModel userRegisterModel);
        UserAccountModel LoginUser(UserLoginModel userLoginModel);
    }
}

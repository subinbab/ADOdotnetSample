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
        int RegisterUser(UserRegisterModel userRegisterModel);
        UserAccountModel LoginUser(UserLoginModel userLoginModel);
    }
}

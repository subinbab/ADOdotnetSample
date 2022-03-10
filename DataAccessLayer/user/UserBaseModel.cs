using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicObject;
using BusinessLogicObject.User;

namespace DataAccessLayer.user
{
    internal abstract class UserBaseModel
    {
        internal SqlConnection _con = null;
        internal SqlCommand _cmd = null;
        internal SqlDataReader _dr = null;
        internal string _connectionString = null;
        internal int _rowAffected = 0;
        internal UserLoginModel _userLoginModel = null;
        internal UserRegisterModel _userRegisterModel = null;
        internal UserAccountModel _userAccountModel = null;
    }
}

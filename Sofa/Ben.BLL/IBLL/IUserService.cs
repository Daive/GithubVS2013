using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Ben.Entity;

namespace Ben.BLL.IBLL
{
    public interface IUserService
    {
        bool Exist(string userName);
        User Add(User user);
        ClaimsIdentity CreateiIdentity(User user, string authenticationType);


    }
}

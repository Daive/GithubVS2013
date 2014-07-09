using System.Security.Claims;
using Ben.BLL.IBLL;
using Ben.DAL.DAL;
using Ben.DAL.IDAL;
using Ben.Entity;
using Microsoft.AspNet.Identity;


namespace Ben.BLL.BLL
{
    public class UserService : IUserService
    {
        public readonly IBaseRepository<User> _userRepository;

        public UserService()
        {
            _userRepository = new BaseRepository<User>();
        }

        public bool Exist(string userName)
        {
            return _userRepository.Exist(u => u.UserName == userName);
        }

        public User Add(User user)
        {
            return _userRepository.Add(user);
        }

        public ClaimsIdentity CreateiIdentity(User user, string authenticationType)
        {
            var _identity = new ClaimsIdentity(DefaultAuthenticationTypes.ApplicationCookie);
            _identity.AddClaim(new Claim(ClaimTypes.Name,user.UserName));
            _identity.AddClaim(new Claim(ClaimTypes.NameIdentifier,user.UserID.ToString()));
            _identity.AddClaim(new Claim("http://schemas.microsoft.com/accesscontrolservice/2010/07/claims/identityprovider", "ASP.NET Identity"));
            _identity.AddClaim(new Claim("DisplayName",user.DisplayName));
            return _identity;
        }
    }
}
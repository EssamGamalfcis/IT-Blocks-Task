using Domain;
using Repository;
using System;
using System.Linq;

namespace Services

{
    public class UserService : IUserService
    {
        public IGenericRepository<User> iuserRepository;

        public UserService(IGenericRepository<User> _iuserRepository)
        {
            this.iuserRepository = _iuserRepository;
        }

      

        public User Login(string username, string password)
        {
            return iuserRepository.FindBy(s => s.UserLoginId.Equals(username) && s.UserLoginPasswrod.Equals(password)).Where(a=>a.DeleteFlag!=1).FirstOrDefault();

        }
    }
}

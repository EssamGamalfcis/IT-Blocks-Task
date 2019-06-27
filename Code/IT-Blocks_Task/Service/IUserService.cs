using Domain;
using Repository;
using System;
using System.Linq;
namespace Services

{
   public interface IUserService
    {
        User Login(string username, string password);
    }
}

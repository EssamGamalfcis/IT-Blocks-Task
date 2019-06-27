using Domain;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services

{
    public class AuthorAdminService : IAuthorAdminService
    {
        IGenericRepository<User> User;
        IGenericRepository<Book> Book;

        public AuthorAdminService(IGenericRepository<User> _User, IGenericRepository<Book> _Book)
        {
            User = _User;
            Book = _Book;
        }

        public void Create(User user)
        {
            User.Add(user);
        }
        public void Delete(int Id)
        {
            var user = GetAuthorById(Id);
            user.DeleteFlag = 1;
            User.Update(user);
        }

        public void Edit(User user)
        {
            User.Update(user);
        }
       
        public List<User> GetAll()
        {
            return User.GetAll().Where(a=>a.DeleteFlag!=1 && a.RoleId!=1).ToList();
        }

        public int GetAllBooksByAuthordId(int id)
        {
           return Book.FindBy(a => a.AuthorId == id).Where(a => a.DeleteFlag != 1).Count();
        }

        public User GetAuthorById(int Id)
        {
            return User.FindBy(a => a.UserId == Id && a.RoleId != 1 && a.DeleteFlag != 1).FirstOrDefault();
        }

       
    }
}

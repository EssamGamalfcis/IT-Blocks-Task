using Domain;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Services

{
   public interface IAuthorAdminService
    {
        List<User> GetAll();
        User GetAuthorById(int Id);
        void Edit(User book);
        void Delete(int Id);
        void Create(User book);
        int GetAllBooksByAuthordId(int id);
    }
}

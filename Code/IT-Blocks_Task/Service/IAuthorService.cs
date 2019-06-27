using Domain;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Services

{
   public interface IAuthorService
    {
        List<Book> GetAllBooksByID(int id);
        Book GetBookByID(int id);
    }
}

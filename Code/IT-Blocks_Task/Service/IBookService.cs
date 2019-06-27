using Domain;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Services

{
   public interface IBookService
    {
        List<Book> GetAll();
        List<User> GetAllAuthor();
        Book GetBookById(int Id);
        int LoanCount(int Id);
        Book Search(string BookName);
        void Edit(Book book);
        void Delete(int Id);
        void Create(Book book);
    }
}

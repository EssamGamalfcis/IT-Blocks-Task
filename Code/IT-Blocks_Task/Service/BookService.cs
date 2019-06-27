using Domain;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services

{
    public class BookService : IBookService
    {
        IGenericRepository<Book> Book;
        IGenericRepository<User> User;
        IGenericRepository<BookLoan> BookLoan;

        public BookService(IGenericRepository<Book> _Book , IGenericRepository<User> _User , IGenericRepository<BookLoan> _BookLoan)
        {
           Book = _Book;
           User = _User;
           BookLoan = _BookLoan;
    }

        public void Create(Book book)
        {
            Book.Add(book);
        }

        public void Delete(int Id)
        {
            var book = GetBookById(Id);
            book.DeleteFlag = 1;
            Book.Update(book);
        }

        public void Edit(Book book)
        {
            Book.Update(book);
        }

        public List<Book> GetAll()
        {
            return Book.Include(a => a.Author).Where(a=>a.DeleteFlag!=1).ToList();
        }

        public List<User> GetAllAuthor()
        {
            return User.GetAll().Where(a => a.DeleteFlag != 1 && a.RoleId != 1).ToList();
             
        }

        public Book GetBookById(int Id)
        {
            return Book.Include(a=>a.Author).Where(a => a.BookId == Id && a.DeleteFlag!=1).FirstOrDefault();
        }

        public int LoanCount(int Id)
        {
            return BookLoan.FindBy(a => a.BookId == Id).Where(a=>a.DeleteFlag!=1).Count();
        }

        public Book Search(string BookName)
        {
            return Book.Include(a => a.Author).Where(a => a.BookName.Equals(BookName) && a.DeleteFlag != 1).FirstOrDefault();
        }
    }
}

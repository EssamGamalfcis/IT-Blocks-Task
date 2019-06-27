using Domain;
using Microsoft.EntityFrameworkCore;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services

{
    public class LoanService : ILoanService
    {
        IGenericRepository<BookLoan> BookLoan;
        IGenericRepository<Book> Book;
        IGenericRepository<Loan> Loan;

        public LoanService(IGenericRepository<BookLoan> _BookLoan, IGenericRepository<Loan> _Loan, IGenericRepository<Book> _Book)
        {
            BookLoan = _BookLoan;
            Loan = _Loan;
            Book = _Book;
        }

        public List<BookLoan> GetAll()
        {
            return BookLoan.Include(b => b.Book).Include(L => L.Loan).Where(a=>a.DeleteFlag !=1).ToList();
        }



        public void Create(BookLoan bookloan)
        {
            BookLoan.Add(bookloan);
            var book = GetBookById(bookloan.BookId);
            book.BookAmount = book.BookAmount - 1;
            Book.Update(book);
        }
       

        public void Edit(BookLoan bookloan)
        {
            BookLoan.Update(bookloan);
        }

        public BookLoan GetBookLoanById(int id)
        {
            return BookLoan.Include(a=>a.Book).Include(a=>a.Loan).Where(a => a.BlId==id && a.DeleteFlag != 1).FirstOrDefault();
        }

        public List<Book> GetAllBooks()
        {
            return Book.GetAll().Where(a=>a.DeleteFlag!=1).ToList();
        }

        public List<Loan> GetAllLoans()
        {
            return Loan.GetAll().ToList();
        }

        public void Delete(BookLoan bookloan)
        {
            bookloan.DeleteFlag = 1;
            BookLoan.Update(bookloan);
            var book = GetBookById(bookloan.BookId);
            book.BookAmount = book.BookAmount + 1;
            Book.Update(book);
        }

        public Book GetBookById(int id)
        {
            return Book.FindBy(a => a.BookId == id).Where(a=>a.DeleteFlag!=1).FirstOrDefault();
        }
    }
}

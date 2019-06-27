using Domain;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Services

{
   public interface ILoanService
    {
        
        List<BookLoan> GetAll();
        void Create(BookLoan bookloan);
        void Edit(BookLoan bookloan);
        BookLoan GetBookLoanById(int id);
        List<Book> GetAllBooks();
        List<Loan> GetAllLoans();
        void Delete(BookLoan bookloan);
        Book GetBookById(int id);

    }
}

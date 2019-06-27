using Domain;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services

{
    public class AuthorService : IAuthorService
    {
        public IGenericRepository<Book> iBookRepository;

        public AuthorService(IGenericRepository<Book> _iBookRepository)
        {
            this.iBookRepository = _iBookRepository;
        }

        public List<Book> GetAllBooksByID(int id)
        {
           return iBookRepository.FindBy(a => a.AuthorId == id).Where(a=>a.DeleteFlag!=1).ToList();
        }

        public Book GetBookByID(int id)
        {
            return iBookRepository.Include(a=>a.Author).Where(a => a.BookId == id && a.DeleteFlag!=1).FirstOrDefault();
        }
    }
}

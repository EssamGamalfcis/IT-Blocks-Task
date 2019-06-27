using System;
using System.Collections.Generic;

namespace Domain
{
    public partial class Book
    {
        public Book()
        {
            BookLoan = new HashSet<BookLoan>();
        }

        public int BookId { get; set; }
        public string BookName { get; set; }
        public string BookDescription { get; set; }
        public int BookAmount { get; set; }
        public int AuthorId { get; set; }
        public int? DeleteFlag { get; set; }

        public virtual User Author { get; set; }
        public virtual ICollection<BookLoan> BookLoan { get; set; }
    }
}

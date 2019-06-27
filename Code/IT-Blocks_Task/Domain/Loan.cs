using System;
using System.Collections.Generic;

namespace Domain
{
    public partial class Loan
    {
        public Loan()
        {
            BookLoan = new HashSet<BookLoan>();
        }

        public int LoanId { get; set; }
        public string LoanPFname { get; set; }
        public string LoanPLname { get; set; }

        public virtual ICollection<BookLoan> BookLoan { get; set; }
    }
}

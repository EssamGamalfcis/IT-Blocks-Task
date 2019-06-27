using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public partial class BookLoan
    {
        public int BlId { get; set; }
        public int BookId { get; set; }
        public int LoanId { get; set; }
        public int? DeleteFlag { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime LoanDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]

        public DateTime LoanReturnDate { get; set; }

        public virtual Book Book { get; set; }
        public virtual Loan Loan { get; set; }
    }
}

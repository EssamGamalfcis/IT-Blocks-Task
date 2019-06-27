using System;
using System.Collections.Generic;

namespace Domain
{
    public partial class User
    {
        public User()
        {
            Book = new HashSet<Book>();
        }

        public int UserId { get; set; }
        public string UserFname { get; set; }
        public string UserLname { get; set; }
        public string UserLoginId { get; set; }
        public string UserLoginPasswrod { get; set; }
        public int RoleId { get; set; }
        public int? DeleteFlag { get; set; }

        public virtual Role Role { get; set; }
        public virtual ICollection<Book> Book { get; set; }
    }
}

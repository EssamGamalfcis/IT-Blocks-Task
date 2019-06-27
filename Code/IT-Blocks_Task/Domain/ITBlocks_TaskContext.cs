using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Domain
{
    public partial class ITBlocks_TaskContext : DbContext
    {
        public ITBlocks_TaskContext()
        {
        }

        public ITBlocks_TaskContext(DbContextOptions<ITBlocks_TaskContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Book> Book { get; set; }
        public virtual DbSet<BookLoan> BookLoan { get; set; }
        public virtual DbSet<Loan> Loan { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-51CBLQL\\SQLEXPRESS;Database=IT-Blocks_Task;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Book>(entity =>
            {
                entity.Property(e => e.BookId).HasColumnName("Book_Id");

                entity.Property(e => e.AuthorId).HasColumnName("Author_Id");

                entity.Property(e => e.BookAmount).HasColumnName("Book_Amount");

                entity.Property(e => e.BookDescription)
                    .HasColumnName("Book_Description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BookName)
                    .IsRequired()
                    .HasColumnName("Book_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeleteFlag).HasColumnName("Delete_Flag");

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.Book)
                    .HasForeignKey(d => d.AuthorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Book_User");
            });

            modelBuilder.Entity<BookLoan>(entity =>
            {
                entity.HasKey(e => e.BlId);

                entity.ToTable("Book_Loan");

                entity.Property(e => e.BlId).HasColumnName("BL_Id");

                entity.Property(e => e.BookId).HasColumnName("Book_Id");

                entity.Property(e => e.DeleteFlag).HasColumnName("Delete_Flag");

                entity.Property(e => e.LoanDate).HasColumnType("date");

                entity.Property(e => e.LoanId).HasColumnName("Loan_Id");

                entity.Property(e => e.LoanReturnDate).HasColumnType("date");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.BookLoan)
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Book_Loan_Book");

                entity.HasOne(d => d.Loan)
                    .WithMany(p => p.BookLoan)
                    .HasForeignKey(d => d.LoanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Book_Loan_Loan");
            });

            modelBuilder.Entity<Loan>(entity =>
            {
                entity.Property(e => e.LoanId).HasColumnName("Loan_Id");

                entity.Property(e => e.LoanPFname)
                    .IsRequired()
                    .HasColumnName("Loan_P_FName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LoanPLname)
                    .IsRequired()
                    .HasColumnName("Loan_P_LName")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.RoleId).HasColumnName("Role_Id");

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasColumnName("Role_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId).HasColumnName("User_Id");

                entity.Property(e => e.DeleteFlag).HasColumnName("Delete_Flag");

                entity.Property(e => e.RoleId).HasColumnName("Role_Id");

                entity.Property(e => e.UserFname)
                    .HasColumnName("User_FName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserLname)
                    .HasColumnName("User_LName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserLoginId)
                    .IsRequired()
                    .HasColumnName("User_Login_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserLoginPasswrod)
                    .IsRequired()
                    .HasColumnName("User_Login_PASSWROD")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_Role");
            });
        }
    }
}

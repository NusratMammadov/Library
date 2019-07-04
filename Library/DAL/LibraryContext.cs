using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Library.Models;

namespace Library.DAL
{
    class LibraryContext:DbContext
    {
        public LibraryContext() : base("LibraryContext")
        {

        }

        public DbSet <Books> Books { get; set; }
        public DbSet<Customer> BCustomer { get; set; }

        public DbSet<OrderItems> OrderItems { get; set; }

        public DbSet<User> Users { get; set; }


    }
}

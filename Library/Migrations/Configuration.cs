namespace Library.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Library.Models;


    internal sealed class Configuration : DbMigrationsConfiguration<Library.DAL.LibraryContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Library.DAL.LibraryContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            var books = new List<Books>
            {

                new Books {Name="Heyatin Mena Axtarisi",Count=10,Price=7},
                new Books {Name="Rich Dad and Poor Dad",Count=5,Price=7},
                new Books {Name="Mein Kampf",Count=10,Price=7},
                new Books {Name="",Count=10,Price=7},
            };

            context.Books.AddRange(books);
            context.SaveChanges();


        }
    }
   }


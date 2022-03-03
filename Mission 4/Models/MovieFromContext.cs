using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission_4.Models
{
    public class MovieFromContext : DbContext
    //inheritance is used from :
    {

        //Constructor
        public MovieFromContext(DbContextOptions<MovieFromContext> options) : base (options)
        {
            //Blank, but only temporary
        }

        public DbSet<FormResponse> Responses { get; set; }
        public DbSet<Category> CategoryEntry { get; set; }

        //Seeding the data
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                    new Category { CategoryID = 1, CategoryName = "Action" },
                    new Category { CategoryID = 2, CategoryName = "Adventure" },
                    new Category { CategoryID = 3, CategoryName="Comedy"},
                    new Category { CategoryID = 4, CategoryName = "Cop / Detective" },
                    new Category { CategoryID = 5, CategoryName = "Documentary" },
                    new Category { CategoryID = 6, CategoryName= "Drama"},
                    new Category { CategoryID = 7, CategoryName = "Drama Comedy" },
                    new Category { CategoryID = 8, CategoryName = "Family" },
                    new Category { CategoryID = 9, CategoryName = "Fantasy" },
                    new Category { CategoryID = 10, CategoryName = "Historical Epic" },
                    new Category { CategoryID = 11, CategoryName = "Heist" },
                    new Category { CategoryID = 12, CategoryName = "Horror" },
                    new Category { CategoryID = 13, CategoryName = "Kids" },
                    new Category { CategoryID = 14, CategoryName = "Musical" },
                    new Category { CategoryID = 15, CategoryName = "Mystery" },
                    new Category { CategoryID = 16, CategoryName = "Parody" },
                    new Category { CategoryID = 17, CategoryName = "Period Piece" },
                    new Category { CategoryID = 18, CategoryName = "Romance" },
                    new Category { CategoryID = 19, CategoryName = "Romantic Comedy" },                
                    new Category { CategoryID = 20, CategoryName = "Spaghetti Western" },
                    new Category { CategoryID = 21, CategoryName = "Sports" },
                    new Category { CategoryID = 22, CategoryName = "Superhero" },
                    new Category { CategoryID = 23, CategoryName = "Television" },
                    new Category { CategoryID = 24, CategoryName = "Thriller" },
                    new Category { CategoryID = 25, CategoryName = "Undeclared" },
                    new Category { CategoryID = 26, CategoryName = "VHS" },
                    new Category { CategoryID = 27, CategoryName = "Western" },
                    new Category { CategoryID = 28, CategoryName = "War" }
                );

            mb.Entity<FormResponse>().HasData(
                new FormResponse
                {
                    FormId = 1,
                    Title = "Ferris Bueller's Day Off",
                    Director = "John Hughes",
                    CategoryId = 3,
                    Year = 1986,
                    Rating = "PG13",
                    Edited = false,
                    LentTo = null,
                    Notes = null
                },
                new FormResponse
                {
                    FormId = 2,
                    Title = "Jojo Rabbit",
                    Director = "Taika Waititi",
                    CategoryId = 7,
                    Year = 2019,
                    Rating = "PG13",
                    Edited = false,
                    LentTo = null,
                    Notes = null
                },
                new FormResponse
                {
                    FormId = 3,
                    Title = "Yesterday",
                    Director = "Danny Boyle",
                    CategoryId = 3,
                    Year = 2019,
                    Rating = "PG13",
                    Edited = false,
                    LentTo = null,
                    Notes = null
                }
           );
        }
    }
}

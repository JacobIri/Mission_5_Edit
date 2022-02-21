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

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<FormResponse>().HasData(
                new FormResponse
                {
                    FormId = 1,
                    Title = "Ferris Bueller's Day Off",
                    Director = "John Hughes",
                    Category = "Comedy",
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
                    Category = "Comedy/Drama",
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
                    Category = "Comedy",
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

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesMovie.Data;
using System;
using System.Linq;

namespace RazorPagesMovie.Models
{
    public class SeedData
    {
        public static void Initialize (IServiceProvider serviceProvider){
            using (var context = new RazorPagesMovieContext(
                serviceProvider.GetRequiredService<DbContextOptions<RazorPagesMovieContext>>())) {
                
                // Does any movies exist in database ?
                if (context.Movie.Any())
                {
                    // Database has already been seeded.
                    return;
                }

                // Movies does not exist in database.
                context.Movie.AddRange(
                    new Movie {
                        Title = "Superman III",
                        ReleaseDate = DateTime.Parse("1989-5-17"),
                        Genre = "SciFi / Fantasy",
                        Price = 6.99M
                    },

                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Price = 3.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(serviceProvider.GetRequiredService<DbContextOptions<MvcMovieContext>>()))
            {
                if (context.Movie.Any())
                {
                    return;
                }

                context.Movie.AddRange(
                    new Movie {
                        Title = "Superman III",
                        Rating = "R",
                        ReleaseDate = DateTime.Parse("1989-6-17"),
                        Genre = "Action",
                        Price = 9.99M
                    },
                    new Movie
                    {
                        Title = "Rio Bravo 2",
                        Rating = "PG",
                        ReleaseDate = DateTime.Parse("1957-4-15"),
                        Genre = "Western",
                        Price = 4.99M
                    },
                    new Movie
                    {
                        Title = "Mythbusters The Movie",
                        Rating = "R",
                        ReleaseDate = DateTime.Parse("2005-1-1"),
                        Genre = "Science",
                        Price = 11.21M
                    },
                    new Movie
                    {
                        Title = "Rio Bravo",
                        Rating = "PG",
                        ReleaseDate = DateTime.Parse("1954-4-15"),
                        Genre = "Western",
                        Price = 3.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}

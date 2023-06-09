﻿
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieList.Models;

namespace MovieList.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options)
            : base(options)
        { }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
                new Movie {
                    MovieId = 4,
                    Name = "Superman",
                    Year = 2010,
                    Rating = 5,
                    GenreId = "D"
                },
                new Movie {
                    MovieId = 2,
                    Name = "Batman Begins",
                    Year = 2020,
                    Rating = 3,
                    GenreId = "A"
                },
                new Movie {
                    MovieId = 3,
                    Name = "Up",
                    Year = 2015,
                    Rating = 4,
                    GenreId = "R"
                }
            );
            modelBuilder.Entity<Genre>().HasData(
                new Genre { GenreId = "A", Name = "Action" },
                new Genre { GenreId = "C", Name = "Comedy" },
                new Genre { GenreId = "D", Name = "Animation" },
                new Genre { GenreId = "H", Name = "SuperHero" },
                new Genre { GenreId = "M", Name = "Musical" },
                new Genre { GenreId = "R", Name = "RomCom" },
                new Genre { GenreId = "S", Name = "SciFi" }
            );
        }
    }
}
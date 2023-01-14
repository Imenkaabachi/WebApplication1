using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;

namespace WebApplication1.Models.Domain
{

    public class CinemaContext : DbContext
    {
   
        private static CinemaContext instance = null;
        private int c = 0;

        public CinemaContext(DbContextOptions o) : base(o)
        {
            c++;
        }
        static public CinemaContext Instantiate_CinemaContext()
        {
            if (instance == null)
            {
                var optionBuilder = new DbContextOptionsBuilder<CinemaContext>();
                optionBuilder.UseSqlite($"Data Source=DB.db");
                instance = new CinemaContext(optionBuilder.Options);
            }

            return instance;
        }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<MovieGenre> MovieGenre { get; set; }

        public DbSet<Movie> Movie { get; set; }

    }
}

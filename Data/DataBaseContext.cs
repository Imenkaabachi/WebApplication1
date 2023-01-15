using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using WebApplication1.Models;


namespace WebApplication1.Data
{

    public class DataBaseContext : DbContext
    {

        private static DataBaseContext instance = null;
        private int c = 0;

        public DataBaseContext(DbContextOptions o) : base(o)
        {
            c++;
        }
        static public DataBaseContext Instantiate_DataBaseContext()
        {
            if (instance == null)
            {
                var optionBuilder = new DbContextOptionsBuilder<DataBaseContext>();
                optionBuilder.UseSqlite($"Data Source=DB.db");
                instance = new DataBaseContext(optionBuilder.Options);
            }

            return instance;
        }

        public DbSet<Genre> Genre { get; set; }

        public DbSet<MovieGenre> MovieGenre { get; set; }

        public DbSet<Movie> Movie { get; set; }

    }
}
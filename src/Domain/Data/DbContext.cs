using Microsoft.EntityFrameworkCore;
using Movies.Domain.Models;

namespace Movies.Domain.Data
{
    internal sealed class MoviesDbContext : DbContext
    {
        private readonly string _dbConnString;

        public MoviesDbContext(string dbConnString)
        {
            _dbConnString = dbConnString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_dbConnString);
        }

        public DbSet<Movie> Movies { get; set; }

    }
}

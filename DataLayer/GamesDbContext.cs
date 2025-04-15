using BusinessLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class GamesDbContext : DbContext
    {
        public static GamesDbContext dbContext;
        public DbSet<User> Users { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Genre> Genres { get; set; }

        public GamesDbContext(DbContextOptions options)
            : base(options) { }
        public GamesDbContext() : base() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("Server=127.0.0.1;Database=GamesDb;Uid=root;Pwd=root");
                base.OnConfiguring(optionsBuilder);
            }
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Movie_Core.Entities.Concrete;
using Movie_DataAccess.SeedData.EntitySeedData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_DataAccess.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            Database.Migrate();
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<TvSeries> TvSeries { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Comment> Comments { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new MovieSeedData());
            modelBuilder.ApplyConfiguration(new TvSeriesSeedData());
            modelBuilder.ApplyConfiguration(new UserSeedData());
            modelBuilder.ApplyConfiguration(new CommentSeedData());
        }
    }
}

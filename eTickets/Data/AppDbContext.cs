using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data
{
    public class AppDbContext : DbContext // AppDbContext class inheriting from DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}
        protected override void OnModelCreating(ModelBuilder modelBuilder) // Override OnModelCreating method
        {
            modelBuilder.Entity<Actor_Movie>() // Configuring composite primary key for Actor_Movie entity
                .HasKey(am => new
                {
                    am.ActorId,
                    am.MovieId
                });
            modelBuilder.Entity<Actor_Movie>().HasOne(am => am.Movie).WithMany(m => m.Actor_Movies).HasForeignKey(am => am.MovieId); // Configuring relationship between Actor_Movie and Movie
            modelBuilder.Entity<Actor_Movie>().HasOne(am => am.Actor).WithMany(a => a.Actor_Movies).HasForeignKey(am => am.ActorId); // Configuring relationship between Actor_Movie and Movie
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Movie> Movies { get; set; } // DbSet for Movie entity
        public DbSet<Actor> Actors { get; set; } // DbSet for Actor entity
        public DbSet<Producer> Producers { get; set; } // DbSet for Producer entity
        public DbSet<Cinema> Cinemas { get; set; } // DbSet for Cinema entity
        public DbSet<Actor_Movie> Actors_Movies { get; set; } // DbSet for Actor_Movie entity
    }

}

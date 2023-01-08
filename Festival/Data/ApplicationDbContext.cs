using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Festival.Models;


namespace Festival.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { 
        }

        public DbSet<Artiest> Artiesten { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Dag> Dagen { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Artiest>().ToTable("Artiest");
            modelBuilder.Entity<Song>().ToTable("Song");
            modelBuilder.Entity<Genre>().ToTable("Genre");
            modelBuilder.Entity<Dag>().ToTable("Dag");



            //artiestsong

            modelBuilder.Entity<ArtiestSong>().HasKey(p => new { p.ArtiestId, p.SongId });

            modelBuilder.Entity<ArtiestSong>()
                .HasOne(p => p.Artiest)
                .WithMany(p => p.ArtiestSongs)
                .HasForeignKey(p => p.ArtiestId);
            modelBuilder.Entity<ArtiestSong>()
                .HasOne(p => p.Song)
                .WithMany(p => p.ArtiestSongs)
                .HasForeignKey(p => p.SongId);


        }

    }
}

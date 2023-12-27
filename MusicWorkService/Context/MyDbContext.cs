using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MusicWorkService.Entities;

namespace MusicWorkService.Context;

public partial class MyDbContext : DbContext
{
    public MyDbContext()
    {
    }

    public MyDbContext(DbContextOptions<MyDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Album> Albums { get; set; }

    public virtual DbSet<Genre> Genres { get; set; }

    public virtual DbSet<GenresMusic> GenresMusics { get; set; }

    public virtual DbSet<Music> Musics { get; set; }
    
    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Username=postgres;Database=MusicStuff;Password=Chmonya;Host=localhost;Port=5432");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Album>(entity =>
        {
            entity.HasKey(e => e.IdAlbum).HasName("Albums_pkey");

            entity.Property(e => e.IdAlbum)
                .UseIdentityAlwaysColumn()
                .HasColumnName("idAlbum");
            entity.Property(e => e.IdUser).HasColumnName("idUser");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Photo).HasColumnName("photo");
        });

        modelBuilder.Entity<Genre>(entity =>
        {
            entity.HasKey(e => e.IdGenre).HasName("Product_pkey");

            entity.Property(e => e.IdGenre).HasColumnName("idGenre");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<GenresMusic>(entity =>
        {
            entity.HasKey(e => e.IdGenreMusic).HasName("Sub_pkey");

            entity.HasIndex(e => e.IdGenre, "IX_Subs_idProduct");

            entity.HasIndex(e => e.IdMusic, "IX_Subs_idUser");

            entity.Property(e => e.IdGenreMusic).HasColumnName("idGenreMusic");
            entity.Property(e => e.IdGenre).HasColumnName("idGenre");
            entity.Property(e => e.IdMusic).HasColumnName("idMusic");

            entity.HasOne(d => d.IdGenreNavigation).WithMany(p => p.GenresMusics)
                .HasForeignKey(d => d.IdGenre)
                .HasConstraintName("Sub_IdProduct_fkey");

            entity.HasOne(d => d.IdMusicNavigation).WithMany(p => p.GenresMusics)
                .HasForeignKey(d => d.IdMusic)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("GenresMusics_idMusic_fkey");
        });

        modelBuilder.Entity<Music>(entity =>
        {
            entity.HasKey(e => e.IdMusic).HasName("Theme_pkey");

            entity.Property(e => e.IdMusic).HasColumnName("idMusic");
            entity.Property(e => e.IdAgeConstraint).HasColumnName("idAgeConstraint");
            entity.Property(e => e.IdAlbum).HasColumnName("idAlbum");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Path).HasColumnName("path");
        });
        

        

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.IdUser).HasName("User_pkey");

            entity.HasIndex(e => e.IdRole, "IX_Users_idRole");

            entity.Property(e => e.IdUser).HasColumnName("idUser");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.IdLoginPassword).HasColumnName("idLoginPassword");
            entity.Property(e => e.IdRole).HasColumnName("idRole");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Phone).HasColumnName("phone");
            
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

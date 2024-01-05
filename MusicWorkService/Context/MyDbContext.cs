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
    public virtual DbSet<Entities.LoginPassword> LoginPasswords { get; set; }
    public virtual DbSet<Entities.Album> Albums { get; set; }

    public virtual DbSet<Entities.Genre> Genres { get; set; }

    public virtual DbSet<Entities.GenresMusic> GenresMusics { get; set; }

    public virtual DbSet<Entities.Music> Musics { get; set; }
    
    public virtual DbSet<Entities.User> Users { get; set; }
    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Entities.LoginPassword>(entity =>
        {
            entity.HasKey(e => e.IdLoginPassword).HasName("LoginPassword_pkey");

            entity.ToTable("LoginPassword");

            entity.Property(e => e.IdLoginPassword)
                .UseIdentityAlwaysColumn()
                .HasColumnName("idLoginPassword");
            entity.Property(e => e.Login).HasColumnName("login");
            entity.Property(e => e.Password).HasColumnName("password");
        });

        modelBuilder.Entity<Entities.Album>(entity =>
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
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("Sub_IdProduct_fkey")
                ;

            entity.HasOne(d => d.IdMusicNavigation).WithMany(p => p.GenresMusics)
                .HasForeignKey(d => d.IdMusic)
                .OnDelete(DeleteBehavior.Cascade)
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

            entity.HasOne(x => x.IdAlbumNavigation)
                .WithMany(x => x.Musics)
                .HasForeignKey(x => x.IdAlbum).OnDelete(DeleteBehavior.Cascade);
        });
        

        

        modelBuilder.Entity<Entities.User>(entity =>
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
            
            entity.HasOne(d => d.IdLoginPasswordNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.IdLoginPassword)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Users_idLoginPassword_fkey");
            
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using PlayerService.Entities;

namespace PlayerService.Context;

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

    public virtual DbSet<LoginPassword> LoginPasswords { get; set; }

    public virtual DbSet<Entities.Music> Musics { get; set; }

    public virtual DbSet<Playlist> Playlists { get; set; }

    public virtual DbSet<PlaylistsMusic> PlaylistsMusics { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<User> Users { get; set; }
    
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
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("GenresMusics_idGenre_fkey");

            entity.HasOne(d => d.IdMusicNavigation).WithMany(p => p.GenresMusics)
                .HasForeignKey(d => d.IdMusic)
                .HasConstraintName("GenresMusics_idMusic_fkey");
        });

        modelBuilder.Entity<LoginPassword>(entity =>
        {
            entity.HasKey(e => e.IdLoginPassword).HasName("LoginPassword_pkey");

            entity.ToTable("LoginPassword");

            entity.Property(e => e.IdLoginPassword)
                .UseIdentityAlwaysColumn()
                .HasColumnName("idLoginPassword");
            entity.Property(e => e.Login).HasColumnName("login");
            entity.Property(e => e.Password).HasColumnName("password");
        });

        modelBuilder.Entity<Entities.Music>(entity =>
        {
            entity.HasKey(e => e.IdMusic).HasName("Theme_pkey");

            entity.Property(e => e.IdMusic).HasColumnName("idMusic");
            entity.Property(e => e.IdAgeConstraint).HasColumnName("idAgeConstraint");
            entity.Property(e => e.IdAlbum).HasColumnName("idAlbum");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Path).HasColumnName("path");

            entity.HasOne(d => d.IdAlbumNavigation).WithMany(p => p.Musics)
                .HasForeignKey(d => d.IdAlbum)
                .HasConstraintName("Musics_idAlbum_fkey");
        });

        modelBuilder.Entity<Playlist>(entity =>
        {
            entity.HasKey(e => e.IdPlaylist).HasName("Playlists_pkey");

            entity.Property(e => e.IdPlaylist)
                .UseIdentityAlwaysColumn()
                .HasColumnName("idPlaylist");
            entity.Property(e => e.IdUser).HasColumnName("idUser");
            entity.Property(e => e.IsPublic).HasColumnName("isPublic");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Photo).HasColumnName("photo");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.Playlists)
                .HasForeignKey(d => d.IdUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Playlists_idUser_fkey");
        });

        modelBuilder.Entity<PlaylistsMusic>(entity =>
        {
            entity.HasKey(e => e.IdPlaylistMusic).HasName("PlaylistsMusics_pkey");

            entity.Property(e => e.IdPlaylistMusic)
                .UseIdentityAlwaysColumn()
                .HasColumnName("idPlaylistMusic");
            entity.Property(e => e.IdMusic).HasColumnName("idMusic");
            entity.Property(e => e.IdPlaylist).HasColumnName("idPlaylist");

            entity.HasOne(d => d.IdMusicNavigation).WithMany(p => p.PlaylistsMusics)
                .HasForeignKey(d => d.IdMusic)
                .HasConstraintName("PlaylistsMusics_idMusic_fkey");

            entity.HasOne(d => d.IdPlaylistNavigation).WithMany(p => p.PlaylistsMusics)
                .HasForeignKey(d => d.IdPlaylist)
                .HasConstraintName("PlaylistsMusics_idPlaylist_fkey");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.IdRole).HasName("Role_pkey");

            entity.Property(e => e.IdRole).HasColumnName("idRole");
            entity.Property(e => e.Name).HasColumnName("name");
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

            entity.HasOne(d => d.IdLoginPasswordNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.IdLoginPassword)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Users_idLoginPassword_fkey");

            entity.HasOne(d => d.IdRoleNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.IdRole)
                .HasConstraintName("User_IdRole_fkey");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

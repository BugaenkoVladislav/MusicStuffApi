using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using UserService.Entities;

namespace UserService.Context;

public partial class MyDbContext : DbContext
{
    public MyDbContext()
    {
    }

    public MyDbContext(DbContextOptions<MyDbContext> options)
        : base(options)
    {
    }
    

    public virtual DbSet<LoginPassword> LoginPasswords { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

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
        
        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.IdRole).HasName("Role_pkey");

            entity.Property(e => e.IdRole).HasColumnName("idRole");
            entity.Property(e => e.Name).HasColumnName("name");
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

            entity.HasOne(d => d.IdRoleNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.IdRole)
                .HasConstraintName("User_IdRole_fkey");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

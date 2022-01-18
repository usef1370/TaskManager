using System;
using Cornea.Application.Interfaces.Contexts;
using Cornea.Common.Roles;
using Cornea.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Cornea.Persistence.Contexts
{
    public partial class DataBaseContext : DbContext, IDataBaseContext
    {
        public DataBaseContext()
        {
        }

        public DataBaseContext(DbContextOptions<DataBaseContext> options)
            : base(options)
        {
        }
        public DbSet<AllTasks> AllTasks { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Factors> Factors { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<LoginInfo> LoginInfo { get; set; }
        public DbSet<Projects> Projects { get; set; }
        public DbSet<Roles> Roles { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<AllTasks>(entity =>
            //{
            //    entity.HasOne(d => d.People)
            //        .WithMany(p => p.AllTasks)
            //        .HasForeignKey(d => d.PeopleId)
            //        .HasConstraintName("FK_Tasks_ProfileInfo");

            //    entity.HasOne(d => d.Groups)
            //        .WithMany(p => p.AllTasks)
            //        .HasForeignKey(d => new { d.ProjectId, d.GroupId })
            //        .OnDelete(DeleteBehavior.Cascade)
            //        .HasConstraintName("FK_Tasks_Groups");
            //});

            //modelBuilder.Entity<Groups>(entity =>
            //{
            //    entity.HasKey(e => new { e.ProjectId, e.GroupId });

            //    entity.Property(e => e.Id).ValueGeneratedOnAdd();

            //    entity.HasOne(d => d.Project)
            //        .WithMany(p => p.Groups)
            //        .HasForeignKey(d => d.ProjectId)
            //        .HasConstraintName("FK_Groups_Projects");
            //});

            //modelBuilder.Entity<LoginInfo>(entity =>
            //{
            //    entity.Property(e => e.UserId).ValueGeneratedOnAdd();

            //    entity.HasOne(d => d.Role)
            //        .WithMany(p => p.LoginInfo)
            //        .HasForeignKey(d => d.RoleId)
            //        .HasConstraintName("FK_Roles_LoginInfo");

                //entity.HasOne(d => d.User)
                //    .WithOne(p => p.LoginInfo)
                //    .HasForeignKey<LoginInfo>(d => d.UserId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_ProfileInfo_LoginInfo");
            //});

            //modelBuilder.Entity<ProfileInfo>(entity =>
            //{
            //    entity.HasKey(e => e.UserId)
            //        .HasName("PK_Profile");
            //});

            modelBuilder.Entity<Roles>().HasData(new Roles { RoleId = 1, RoleName = nameof(UserRoles.Manager) });
            modelBuilder.Entity<Roles>().HasData(new Roles { RoleId = 2, RoleName = nameof(UserRoles.Employee) });
            modelBuilder.Entity<Roles>().HasData(new Roles { RoleId = 3, RoleName = nameof(UserRoles.Finance) });

            modelBuilder.Entity<LoginInfo>().HasIndex(u => u.UserName).IsUnique();
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

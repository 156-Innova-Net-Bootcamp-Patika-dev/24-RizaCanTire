﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ResidenceManagement.Domain.Entities.Auths;
using ResidenceManagement.Domain.Entities.Managements;
using System.Collections.Generic;

namespace ResidenceManagement.Infrastructure.Persistence
{
    public class SiteContext : IdentityDbContext<User,Role,int>
    {
        public SiteContext(DbContextOptions<SiteContext> options) : base(options)
        {

        }
        public DbSet<Residence> Residences { get; set; }
        public DbSet<ResidenceType> ResidenceTypes { get; set; }
        public DbSet<UserResidence> UserResidences { get; set; }
        public DbSet<Dues> Dues { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Message> Messages { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);
            SeedUsers(builder);
            SeedRoles(builder);
            SeedResidenceType(builder);
            SeedUserRole(builder);


        }

        private void SeedUsers(ModelBuilder builder)
        {
            var admin = new User()
            {
                Id=1,
                FirstName = "Rıza Can",
                LastName = "Tire",
                Email ="admin@admin.com"
                
            };

            var user = new User()
            {
                Id = 2,
                FirstName = "Ahmet",
                LastName = "Tire",
                Email = "ahmet@admin.com"

            };


            PasswordHasher<User> passwordHasher = new PasswordHasher<User>();
            admin.PasswordHash = passwordHasher.HashPassword(admin, "Admin123");
            user.PasswordHash = passwordHasher.HashPassword(user, "Abcd123");


            builder.Entity<User>().HasData(admin);
            builder.Entity<User>().HasData(user);

        }

        private void SeedRoles(ModelBuilder builder)
        {
            builder.Entity<Role>().HasData(
                new Role() { Id = 1, Name = "Admin", ConcurrencyStamp = "1", NormalizedName = "ADMIN" },
                new Role() { Id = 2, Name = "User", ConcurrencyStamp = "2", NormalizedName = "USER" }
                );
        }

        private void SeedResidenceType(ModelBuilder builder)
        {
            builder.Entity<ResidenceType>().HasData(
                new ResidenceType() { Id = 1, Type = "1+0"},
                new ResidenceType() { Id = 2, Type = "1+1" },
                new ResidenceType() { Id = 3, Type = "2+1" },
                new ResidenceType() { Id = 4, Type = "3+1" },
                new ResidenceType() { Id = 5, Type = "4+1" },
                new ResidenceType() { Id = 6, Type = "5+1" }
                );
        }
        private void SeedUserRole(ModelBuilder builder)
        {
            builder.Entity<UserRole>().HasData(
                new UserRole() { UserId=1,RoleId=1},
                new UserRole() {UserId =2,RoleId=2 }
                
                );
        }
      

    }
}
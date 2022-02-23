﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ResidenceManagement.Infrastructure.Persistence;

namespace ResidenceManagement.Infrastructure.Migrations
{
    [DbContext(typeof(SiteContext))]
    partial class SiteContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.14");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<int>("RoleId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RoleId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUserRole<int>");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ResidenceManagement.Domain.Entities.Auths.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConcurrencyStamp = "1",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = 2,
                            ConcurrencyStamp = "2",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("ResidenceManagement.Domain.Entities.Auths.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CarPlate")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NationalId")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "2649a520-bbef-4069-8ab4-9e3d81b80d9b",
                            Email = "admin@admin.com",
                            EmailConfirmed = false,
                            FirstName = "Rıza Can",
                            LastName = "Tire",
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAEAACcQAAAAEAk5dobtZ6fMroLZyuNPNvj3LGg6PvQG+4oxMdo3R8fd8vHjbrKsQ111LqsNf5gkGA==",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = 2,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0d216dc0-2ea5-4255-bfc6-034b53e3e478",
                            Email = "ahmet@admin.com",
                            EmailConfirmed = false,
                            FirstName = "Ahmet",
                            LastName = "Tire",
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAEAACcQAAAAELQHNgKReSn/4oSDPI//ZaeU3SJZdGFYVpzgykOF/x8WkNxNb5HGmdGcYq1GniHlEQ==",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = 3,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a401f177-7f34-4819-94b1-a2edbc7c7376",
                            Email = "d@d.com",
                            EmailConfirmed = false,
                            FirstName = "Demiralp",
                            LastName = "Tire",
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAEAACcQAAAAEG8ZaeGXbQccIr6RUDKfa8VsT+49bsdFeZ7ub97orDzy9kckf06+GmIPdSQ8e92dLg==",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = 4,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c13289a1-249a-4ca8-9b7d-2e5308c1bdee",
                            Email = "y@y.com",
                            EmailConfirmed = false,
                            FirstName = "Yasemin",
                            LastName = "Tire",
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAEAACcQAAAAEBAB+gkxSfmY+Eveq0g6AOjtSp5kz3WguUb+mMqGVbZCQzA4waC59tREIPjqk4YRAQ==",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = 5,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ebf000a0-c168-434e-8e91-a887781f9477",
                            Email = "h@h.com",
                            EmailConfirmed = false,
                            FirstName = "Hasibe",
                            LastName = "Tire",
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAEAACcQAAAAEEN9by1n+ygWG+kQ4jn2SwCpl/CwPE06eFNz+wigl0voC09aO1OR5NiglmV8ETb79Q==",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false
                        });
                });

            modelBuilder.Entity("ResidenceManagement.Domain.Entities.Managements.Dues", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Fee")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Month")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Dueses");
                });

            modelBuilder.Entity("ResidenceManagement.Domain.Entities.Managements.Invoice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Fee")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Month")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("ResidenceManagement.Domain.Entities.Managements.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsRead")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ReceiverId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SenderId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ReceiverId");

                    b.HasIndex("SenderId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("ResidenceManagement.Domain.Entities.Managements.Residence", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Block")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DoorNumber")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Floor")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsFull")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ResidenceTypeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ResidenceTypeId");

                    b.ToTable("Residences");
                });

            modelBuilder.Entity("ResidenceManagement.Domain.Entities.Managements.ResidenceDues", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("DuesId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsPaid")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserResidenceId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("DuesId");

                    b.HasIndex("UserResidenceId");

                    b.ToTable("ResidenceDues");
                });

            modelBuilder.Entity("ResidenceManagement.Domain.Entities.Managements.ResidenceInvoice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("InvoiceId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsPaid")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserResidenceId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("InvoiceId");

                    b.HasIndex("UserResidenceId");

                    b.ToTable("ResidenceInvoices");
                });

            modelBuilder.Entity("ResidenceManagement.Domain.Entities.Managements.ResidenceType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ResidenceTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Type = "1+0"
                        },
                        new
                        {
                            Id = 2,
                            Type = "1+1"
                        },
                        new
                        {
                            Id = 3,
                            Type = "2+1"
                        },
                        new
                        {
                            Id = 4,
                            Type = "3+1"
                        },
                        new
                        {
                            Id = 5,
                            Type = "4+1"
                        },
                        new
                        {
                            Id = 6,
                            Type = "5+1"
                        });
                });

            modelBuilder.Entity("ResidenceManagement.Domain.Entities.Managements.ResidentType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ResidentType");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Type = "Owner"
                        },
                        new
                        {
                            Id = 2,
                            Type = "Tenant"
                        });
                });

            modelBuilder.Entity("ResidenceManagement.Domain.Entities.Managements.UserResidence", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ResidenceId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ResidentTypeId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ResidenceId");

                    b.HasIndex("ResidentTypeId");

                    b.HasIndex("UserId");

                    b.ToTable("UserResidences");
                });

            modelBuilder.Entity("ResidenceManagement.Domain.Entities.Auths.UserRole", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUserRole<int>");

                    b.HasDiscriminator().HasValue("UserRole");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            RoleId = 1
                        },
                        new
                        {
                            UserId = 2,
                            RoleId = 2
                        },
                        new
                        {
                            UserId = 3,
                            RoleId = 2
                        },
                        new
                        {
                            UserId = 4,
                            RoleId = 2
                        },
                        new
                        {
                            UserId = 5,
                            RoleId = 2
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("ResidenceManagement.Domain.Entities.Auths.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("ResidenceManagement.Domain.Entities.Auths.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("ResidenceManagement.Domain.Entities.Auths.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("ResidenceManagement.Domain.Entities.Auths.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ResidenceManagement.Domain.Entities.Auths.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("ResidenceManagement.Domain.Entities.Auths.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ResidenceManagement.Domain.Entities.Managements.Message", b =>
                {
                    b.HasOne("ResidenceManagement.Domain.Entities.Auths.User", "Receiver")
                        .WithMany("Receiving")
                        .HasForeignKey("ReceiverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ResidenceManagement.Domain.Entities.Auths.User", "Sender")
                        .WithMany("Sending")
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Receiver");

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("ResidenceManagement.Domain.Entities.Managements.Residence", b =>
                {
                    b.HasOne("ResidenceManagement.Domain.Entities.Managements.ResidenceType", "ResidenceType")
                        .WithMany("Residences")
                        .HasForeignKey("ResidenceTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ResidenceType");
                });

            modelBuilder.Entity("ResidenceManagement.Domain.Entities.Managements.ResidenceDues", b =>
                {
                    b.HasOne("ResidenceManagement.Domain.Entities.Managements.Dues", "Dues")
                        .WithMany("ResidenceDuesses")
                        .HasForeignKey("DuesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ResidenceManagement.Domain.Entities.Managements.UserResidence", "UserResidence")
                        .WithMany("ResidenceDuesses")
                        .HasForeignKey("UserResidenceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dues");

                    b.Navigation("UserResidence");
                });

            modelBuilder.Entity("ResidenceManagement.Domain.Entities.Managements.ResidenceInvoice", b =>
                {
                    b.HasOne("ResidenceManagement.Domain.Entities.Managements.Invoice", "Invoice")
                        .WithMany("ResidenceInvoices")
                        .HasForeignKey("InvoiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ResidenceManagement.Domain.Entities.Managements.UserResidence", "UserResidence")
                        .WithMany("ResidenceInvoices")
                        .HasForeignKey("UserResidenceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Invoice");

                    b.Navigation("UserResidence");
                });

            modelBuilder.Entity("ResidenceManagement.Domain.Entities.Managements.UserResidence", b =>
                {
                    b.HasOne("ResidenceManagement.Domain.Entities.Managements.Residence", "Residence")
                        .WithMany("UserResidences")
                        .HasForeignKey("ResidenceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ResidenceManagement.Domain.Entities.Managements.ResidentType", "ResidentType")
                        .WithMany()
                        .HasForeignKey("ResidentTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ResidenceManagement.Domain.Entities.Auths.User", "User")
                        .WithMany("UserResidences")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Residence");

                    b.Navigation("ResidentType");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ResidenceManagement.Domain.Entities.Auths.User", b =>
                {
                    b.Navigation("Receiving");

                    b.Navigation("Sending");

                    b.Navigation("UserResidences");
                });

            modelBuilder.Entity("ResidenceManagement.Domain.Entities.Managements.Dues", b =>
                {
                    b.Navigation("ResidenceDuesses");
                });

            modelBuilder.Entity("ResidenceManagement.Domain.Entities.Managements.Invoice", b =>
                {
                    b.Navigation("ResidenceInvoices");
                });

            modelBuilder.Entity("ResidenceManagement.Domain.Entities.Managements.Residence", b =>
                {
                    b.Navigation("UserResidences");
                });

            modelBuilder.Entity("ResidenceManagement.Domain.Entities.Managements.ResidenceType", b =>
                {
                    b.Navigation("Residences");
                });

            modelBuilder.Entity("ResidenceManagement.Domain.Entities.Managements.UserResidence", b =>
                {
                    b.Navigation("ResidenceDuesses");

                    b.Navigation("ResidenceInvoices");
                });
#pragma warning restore 612, 618
        }
    }
}

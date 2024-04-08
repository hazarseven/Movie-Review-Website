﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Movie_DataAccess.Context.IdentityContext;

#nullable disable

namespace Movie_DataAccess.Context.IdentityContext.Migrations
{
    [DbContext(typeof(AppIdentityDbContext))]
    partial class AppIdentityDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "e3b3b3b3-3b3b-3b3b-3b3b-3b3b3b3b3b3b",
                            Name = "editor",
                            NormalizedName = "EDITOR"
                        },
                        new
                        {
                            Id = "f4f4f4f4-4f4f-4f4f-4f4f-4f4f4f4f4f4f",
                            Name = "member",
                            NormalizedName = "MEMBER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "f4f4f4f4-4f4f-4f4f-4f4f-4f4f4f4f4f4f",
                            RoleId = "e3b3b3b3-3b3b-3b3b-3b3b-3b3b3b3b3b3b"
                        },
                        new
                        {
                            UserId = "e3b3b3b3-3b3b-3b3b-3b3b-3b3b3b3b3b3b",
                            RoleId = "f4f4f4f4-4f4f-4f4f-4f4f-4f4f4f4f4f4f"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Movie_Core.Entities.UserEntities.Concrete.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "f4f4f4f4-4f4f-4f4f-4f4f-4f4f4f4f4f4f",
                            AccessFailedCount = 0,
                            BirthDate = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),

                            ConcurrencyStamp = "20cbef84-d6b1-4d71-9f4e-9f8a688c5fb7",
                            CreatedDate = new DateTime(2024, 4, 8, 16, 38, 2, 872, DateTimeKind.Local).AddTicks(8280),

                            ConcurrencyStamp = "edc2ab55-51a6-43e7-bd25-3b6b5107ddb0",
                            CreatedDate = new DateTime(2024, 4, 8, 14, 43, 6, 735, DateTimeKind.Local).AddTicks(2151),

                            Email = "editor@test.com",
                            EmailConfirmed = false,
                            FirstName = "Editor",
                            LastName = "Editor",
                            LockoutEnabled = false,
                            NormalizedEmail = "EDITOR@TEST.COM",
                            NormalizedUserName = "EDITOR",

                            PasswordHash = "AQAAAAIAAYagAAAAEEqXll5IhijOhhc2xd1fz+DNqWFcqNumZ7lP2ulPQjR0UtFX3f65ABZ08tliYHzIyw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "da5cf07a-8d56-4447-a4cf-6f169b6fd901",

                            PasswordHash = "AQAAAAIAAYagAAAAEBecvEhmCghENWQzVeqrH7m8QwwUoVgm03OCIECUDhzpwvIw9EPfexN+dBC0Bw/XJA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "cbf8045c-bb43-4641-917e-b386a561309b",

                            Status = 1,
                            TwoFactorEnabled = false,
                            UserName = "editor"
                        },
                        new
                        {
                            Id = "e3b3b3b3-3b3b-3b3b-3b3b-3b3b3b3b3b3b",
                            AccessFailedCount = 0,
                            BirthDate = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),

                            ConcurrencyStamp = "891e15d5-856a-4c2f-a707-6c587833ce27",
                            CreatedDate = new DateTime(2024, 4, 8, 16, 38, 2, 976, DateTimeKind.Local).AddTicks(7389),

                            ConcurrencyStamp = "7115d2bd-e672-473b-b670-993827b6ed38",
                            CreatedDate = new DateTime(2024, 4, 8, 14, 43, 6, 775, DateTimeKind.Local).AddTicks(4265),

                            Email = "member@test.com",
                            EmailConfirmed = false,
                            FirstName = "Member",
                            LastName = "Member",
                            LockoutEnabled = false,
                            NormalizedEmail = "MEMBER@TEST.COM",
                            NormalizedUserName = "MEMBER",

                            PasswordHash = "AQAAAAIAAYagAAAAEPWRkpikIQTrGkEcdRr41kB6bkENM5uc9PMTOuZGE6dFIEugQF4L1vUtSnXo94loEw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "b6590a25-2923-42a3-a7ee-97eb195a519d",

                            PasswordHash = "AQAAAAIAAYagAAAAEMEKImS7S+29z2NGuHEgo50jdOYQPqVO2xnCi8trKaknYhWii99RKx7E1SGsSkzW+A==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "ecd18dbb-9e6c-4130-8099-bc8293378d51",

                            Status = 1,
                            TwoFactorEnabled = false,
                            UserName = "member"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Movie_Core.Entities.UserEntities.Concrete.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Movie_Core.Entities.UserEntities.Concrete.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Movie_Core.Entities.UserEntities.Concrete.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Movie_Core.Entities.UserEntities.Concrete.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

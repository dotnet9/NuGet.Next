﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NuGet.Next.MySql;

#nullable disable

namespace NuGet.Next.MySql.Migrations
{
    [DbContext(typeof(MySqlContext))]
    [Migration("20241101182359_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("NuGet.Next.Core.Package", b =>
                {
                    b.Property<int>("Key")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Key"));

                    b.Property<string>("Authors")
                        .IsRequired()
                        .HasMaxLength(4000)
                        .HasColumnType("varchar(4000)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Creator")
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .HasMaxLength(4000)
                        .HasColumnType("varchar(4000)");

                    b.Property<long>("Downloads")
                        .HasColumnType("bigint");

                    b.Property<bool>("HasEmbeddedIcon")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("HasReadme")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("IconUrl")
                        .HasMaxLength(4000)
                        .HasColumnType("varchar(4000)");

                    b.Property<string>("Id")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<bool>("IsPrerelease")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Language")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("LicenseUrl")
                        .HasMaxLength(4000)
                        .HasColumnType("varchar(4000)");

                    b.Property<bool>("Listed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("MinClientVersion")
                        .HasMaxLength(44)
                        .HasColumnType("varchar(44)");

                    b.Property<string>("Modifier")
                        .HasColumnType("longtext");

                    b.Property<string>("NormalizedVersionString")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)")
                        .HasColumnName("Version");

                    b.Property<string>("OriginalVersionString")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)")
                        .HasColumnName("OriginalVersion");

                    b.Property<string>("ProjectUrl")
                        .HasMaxLength(4000)
                        .HasColumnType("varchar(4000)");

                    b.Property<DateTime>("Published")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("ReleaseNotes")
                        .HasColumnType("longtext")
                        .HasColumnName("ReleaseNotes");

                    b.Property<string>("RepositoryType")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("RepositoryUrl")
                        .HasMaxLength(4000)
                        .HasColumnType("varchar(4000)");

                    b.Property<bool>("RequireLicenseAcceptance")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp(6)");

                    b.Property<int>("SemVerLevel")
                        .HasColumnType("int");

                    b.Property<string>("Summary")
                        .HasMaxLength(4000)
                        .HasColumnType("varchar(4000)");

                    b.Property<string>("Tags")
                        .HasMaxLength(4000)
                        .HasColumnType("varchar(4000)");

                    b.Property<string>("Title")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Key");

                    b.HasIndex("Id");

                    b.HasIndex("Id", "NormalizedVersionString")
                        .IsUnique();

                    b.ToTable("Packages");
                });

            modelBuilder.Entity("NuGet.Next.Core.PackageDependency", b =>
                {
                    b.Property<int>("Key")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Key"));

                    b.Property<string>("Id")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("PackageId")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("PackageKey")
                        .HasColumnType("int");

                    b.Property<string>("TargetFramework")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("VersionRange")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Key");

                    b.HasIndex("Id");

                    b.HasIndex("PackageKey");

                    b.ToTable("PackageDependencies");
                });

            modelBuilder.Entity("NuGet.Next.Core.PackageType", b =>
                {
                    b.Property<int>("Key")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Key"));

                    b.Property<string>("Name")
                        .HasMaxLength(512)
                        .HasColumnType("varchar(512)");

                    b.Property<int>("PackageKey")
                        .HasColumnType("int");

                    b.Property<string>("Version")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.HasKey("Key");

                    b.HasIndex("Name");

                    b.HasIndex("PackageKey");

                    b.ToTable("PackageTypes");
                });

            modelBuilder.Entity("NuGet.Next.Core.PackageUpdateRecord", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("OperationDescription")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("OperationIP")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("OperationTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("OperationType")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PackageId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Version")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("PackageId");

                    b.HasIndex("UserId");

                    b.ToTable("PackageUpdateRecords");
                });

            modelBuilder.Entity("NuGet.Next.Core.TargetFramework", b =>
                {
                    b.Property<int>("Key")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Key"));

                    b.Property<string>("Moniker")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PackageId")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("PackageKey")
                        .HasColumnType("int");

                    b.HasKey("Key");

                    b.HasIndex("Moniker");

                    b.HasIndex("PackageKey");

                    b.ToTable("TargetFrameworks");
                });

            modelBuilder.Entity("NuGet.Next.Core.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Avatar")
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = "fe256917-de1c-478e-9a32-272b6b542b15",
                            Avatar = "https://avatars.githubusercontent.com/u/61819790?v=4",
                            Email = "239573049@qq.com",
                            FullName = "token",
                            Password = "8ddc6e6ddb0d97699423852471011a56",
                            PasswordHash = "48e41f7cd9564ebd917ef793ef416a61",
                            Role = "admin",
                            Username = "admin"
                        });
                });

            modelBuilder.Entity("NuGet.Next.Core.UserKey", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(255)");

                    b.Property<DateTimeOffset>("CreatedTime")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Enabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("Key")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("UserKeys");

                    b.HasData(
                        new
                        {
                            Id = "69af12db543d4c18a531e293ec733078",
                            CreatedTime = new DateTimeOffset(new DateTime(2024, 11, 2, 2, 23, 58, 956, DateTimeKind.Unspecified).AddTicks(980), new TimeSpan(0, 8, 0, 0, 0)),
                            Enabled = true,
                            Key = "key-84b76b22f70f46048664fbf2469243a0",
                            UserId = "fe256917-de1c-478e-9a32-272b6b542b15"
                        });
                });

            modelBuilder.Entity("NuGet.Next.Core.PackageDependency", b =>
                {
                    b.HasOne("NuGet.Next.Core.Package", "Package")
                        .WithMany("Dependencies")
                        .HasForeignKey("PackageKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Package");
                });

            modelBuilder.Entity("NuGet.Next.Core.PackageType", b =>
                {
                    b.HasOne("NuGet.Next.Core.Package", "Package")
                        .WithMany("PackageTypes")
                        .HasForeignKey("PackageKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Package");
                });

            modelBuilder.Entity("NuGet.Next.Core.TargetFramework", b =>
                {
                    b.HasOne("NuGet.Next.Core.Package", "Package")
                        .WithMany("TargetFrameworks")
                        .HasForeignKey("PackageKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Package");
                });

            modelBuilder.Entity("NuGet.Next.Core.UserKey", b =>
                {
                    b.HasOne("NuGet.Next.Core.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("NuGet.Next.Core.Package", b =>
                {
                    b.Navigation("Dependencies");

                    b.Navigation("PackageTypes");

                    b.Navigation("TargetFrameworks");
                });
#pragma warning restore 612, 618
        }
    }
}

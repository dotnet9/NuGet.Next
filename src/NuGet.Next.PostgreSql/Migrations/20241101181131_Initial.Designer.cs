﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using NuGet.Next.PostgreSql;

#nullable disable

namespace NuGet.Next.PostgreSql.Migrations
{
    [DbContext(typeof(PostgreSqlContext))]
    [Migration("20241101181131_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.HasPostgresExtension(modelBuilder, "citext");
            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("NuGet.Next.Core.Package", b =>
                {
                    b.Property<int>("Key")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Key"));

                    b.Property<string>("Authors")
                        .IsRequired()
                        .HasMaxLength(4000)
                        .HasColumnType("character varying(4000)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Creator")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasMaxLength(4000)
                        .HasColumnType("character varying(4000)");

                    b.Property<long>("Downloads")
                        .HasColumnType("bigint");

                    b.Property<bool>("HasEmbeddedIcon")
                        .HasColumnType("boolean");

                    b.Property<bool>("HasReadme")
                        .HasColumnType("boolean");

                    b.Property<string>("IconUrl")
                        .HasMaxLength(4000)
                        .HasColumnType("character varying(4000)");

                    b.Property<string>("Id")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("citext");

                    b.Property<bool>("IsPrerelease")
                        .HasColumnType("boolean");

                    b.Property<string>("Language")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("LicenseUrl")
                        .HasMaxLength(4000)
                        .HasColumnType("character varying(4000)");

                    b.Property<bool>("Listed")
                        .HasColumnType("boolean");

                    b.Property<string>("MinClientVersion")
                        .HasMaxLength(44)
                        .HasColumnType("character varying(44)");

                    b.Property<string>("Modifier")
                        .HasColumnType("text");

                    b.Property<string>("NormalizedVersionString")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("citext")
                        .HasColumnName("Version");

                    b.Property<string>("OriginalVersionString")
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)")
                        .HasColumnName("OriginalVersion");

                    b.Property<string>("ProjectUrl")
                        .HasMaxLength(4000)
                        .HasColumnType("character varying(4000)");

                    b.Property<DateTime>("Published")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ReleaseNotes")
                        .HasColumnType("text")
                        .HasColumnName("ReleaseNotes");

                    b.Property<string>("RepositoryType")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("RepositoryUrl")
                        .HasMaxLength(4000)
                        .HasColumnType("character varying(4000)");

                    b.Property<bool>("RequireLicenseAcceptance")
                        .HasColumnType("boolean");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("bytea");

                    b.Property<int>("SemVerLevel")
                        .HasColumnType("integer");

                    b.Property<string>("Summary")
                        .HasMaxLength(4000)
                        .HasColumnType("character varying(4000)");

                    b.Property<string>("Tags")
                        .HasMaxLength(4000)
                        .HasColumnType("character varying(4000)");

                    b.Property<string>("Title")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

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
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Key"));

                    b.Property<string>("Id")
                        .HasMaxLength(128)
                        .HasColumnType("citext");

                    b.Property<string>("PackageId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("PackageKey")
                        .HasColumnType("integer");

                    b.Property<string>("TargetFramework")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("VersionRange")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Key");

                    b.HasIndex("Id");

                    b.HasIndex("PackageKey");

                    b.ToTable("PackageDependencies");
                });

            modelBuilder.Entity("NuGet.Next.Core.PackageType", b =>
                {
                    b.Property<int>("Key")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Key"));

                    b.Property<string>("Name")
                        .HasMaxLength(512)
                        .HasColumnType("citext");

                    b.Property<int>("PackageKey")
                        .HasColumnType("integer");

                    b.Property<string>("Version")
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)");

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

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("OperationDescription")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("OperationIP")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("OperationTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("OperationType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PackageId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Version")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("PackageId");

                    b.HasIndex("UserId");

                    b.ToTable("PackageUpdateRecords");
                });

            modelBuilder.Entity("NuGet.Next.Core.TargetFramework", b =>
                {
                    b.Property<int>("Key")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Key"));

                    b.Property<string>("Moniker")
                        .HasMaxLength(256)
                        .HasColumnType("citext");

                    b.Property<string>("PackageId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("PackageKey")
                        .HasColumnType("integer");

                    b.HasKey("Key");

                    b.HasIndex("Moniker");

                    b.HasIndex("PackageKey");

                    b.ToTable("TargetFrameworks");
                });

            modelBuilder.Entity("NuGet.Next.Core.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("Avatar")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = "0748b328-aa89-468a-ade2-26563302e0cc",
                            Avatar = "https://avatars.githubusercontent.com/u/61819790?v=4",
                            Email = "239573049@qq.com",
                            FullName = "token",
                            Password = "eb36b24cf16145d9bfd985b65a302a85",
                            PasswordHash = "711923e65e054d74911342b81332d0d1",
                            Role = "admin",
                            Username = "admin"
                        });
                });

            modelBuilder.Entity("NuGet.Next.Core.UserKey", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("CreatedTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("Enabled")
                        .HasColumnType("boolean");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Key")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("UserKeys");

                    b.HasData(
                        new
                        {
                            Id = "dacd058775484cd092837b051f9e6098",
                            CreatedTime = new DateTimeOffset(new DateTime(2024, 11, 2, 2, 11, 30, 973, DateTimeKind.Unspecified).AddTicks(7069), new TimeSpan(0, 8, 0, 0, 0)),
                            Enabled = true,
                            Key = "key-e2b6441254bf423a99c2299f4592d9a3",
                            UserId = "0748b328-aa89-468a-ade2-26563302e0cc"
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

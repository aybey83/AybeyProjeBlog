﻿// <auto-generated />
using System;
using Blog.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Blog.Data.Migrations
{
    [DbContext(typeof(BlogContext))]
    [Migration("20191126175706_Page_2")]
    partial class Page_2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Blog.Data.Models.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<string>("Content");

                    b.Property<DateTime>("CreateDate");

                    b.Property<bool>("Deleted");

                    b.Property<int>("Hit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("Blog.Data.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate");

                    b.Property<bool>("Deleted");

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Blog.Data.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BlogId");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<DateTime>("CreateDate");

                    b.Property<bool>("Deleted");

                    b.Property<string>("Email")
                        .HasMaxLength(320);

                    b.Property<string>("Nickname")
                        .HasMaxLength(50);

                    b.Property<int?>("UserId");

                    b.Property<int>("VoteDown");

                    b.Property<int>("VoteUp");

                    b.HasKey("Id");

                    b.HasIndex("BlogId");

                    b.HasIndex("UserId");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("Blog.Data.Models.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate");

                    b.Property<bool>("Deleted");

                    b.Property<string>("Message");

                    b.Property<string>("Name");

                    b.Property<string>("Surname");

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("Blog.Data.Models.Nationality", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code");

                    b.Property<DateTime>("CreateDate");

                    b.Property<bool>("Deleted");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Nationality");
                });

            modelBuilder.Entity("Blog.Data.Models.Page", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .IsRequired();

                    b.Property<DateTime>("CreateDate");

                    b.Property<bool>("Deleted");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.ToTable("Pages");
                });

            modelBuilder.Entity("Blog.Data.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("BirthDate");

                    b.Property<DateTime>("CreateDate");

                    b.Property<bool>("Deleted");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(320);

                    b.Property<int>("Gender");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int?>("NationalityId");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("NationalityId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Blog.Data.Models.Blog", b =>
                {
                    b.HasOne("Blog.Data.Models.Category", "Category")
                        .WithMany("Blogs")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Blog.Data.Models.User", "User")
                        .WithMany("Blogs")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Blog.Data.Models.Comment", b =>
                {
                    b.HasOne("Blog.Data.Models.Blog", "Blog")
                        .WithMany("Comments")
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Blog.Data.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Blog.Data.Models.User", b =>
                {
                    b.HasOne("Blog.Data.Models.Nationality", "Nationality")
                        .WithMany()
                        .HasForeignKey("NationalityId");
                });
#pragma warning restore 612, 618
        }
    }
}

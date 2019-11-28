using Blog.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Blog.Data.Context
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options) : base(options)
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<Blog.Data.Models.Blog> Blogs { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(new Category()
            {
                Id = 1,
                CreateDate = DateTime.UtcNow,
                Deleted = false,
                Name = "Aşk",
                Description = "..."
            });
            modelBuilder.Entity<Category>().HasData(new Category()
            {
                Id = 2,
                CreateDate = DateTime.UtcNow,
                Deleted = false,
                Name = "Meşk",
                Description = "!!!"
            });
            modelBuilder.Entity<Nationality>().HasData(new User()
            {
                Id = 1,
                CreateDate = DateTime.UtcNow,
                Deleted = false,
                Name = "Türkiye",
                Code = "tr"
            });
            modelBuilder.Entity<User>().HasData(new User()
            {
                Id = 1,
                CreateDate = DateTime.UtcNow,
                Deleted = false,
                Name = "Aybey",
                Email = "aybey83@gmail.com",
                BirthDate = new DateTime(1983,12,04),
                Gender = Enums.Gender.Male,
                Password = "12345678",
                Username = "aybey83",
                Surname = "Bayazıt",
                NationalityId = 1
                
            });

            base.OnModelCreating(modelBuilder);


        }
    }
}
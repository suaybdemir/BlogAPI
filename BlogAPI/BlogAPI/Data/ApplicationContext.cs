using System;
using BlogAPI.Models.Domain.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlogAPI.Data
{
    public class ApplicationContext : IdentityDbContext<ApplicationUser>
	{
		public ApplicationContext(DbContextOptions<ApplicationContext> options)
			: base(options)
		{

		}
		public DbSet<ApplicationUser> ApplicationUsers { get; set; }

		public DbSet<Comment>? Comments { get; set; }
		public DbSet<Member>? Members { get; set; }
		public DbSet<Post>? Post { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}


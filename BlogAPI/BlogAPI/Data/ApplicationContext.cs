using System;
using BlogAPI.Models.Domain.Concrete;
using Microsoft.EntityFrameworkCore;

namespace BlogAPI.Data
{
    public class ApplicationContext : DbContext
	{
		public ApplicationContext(DbContextOptions options)
			: base(options)
		{

		}
		public DbSet<Comment>? Comments { get; set; }
		public DbSet<Member>? Members { get; set; }
		public DbSet<Post>? Post { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}


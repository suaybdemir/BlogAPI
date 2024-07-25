using System;
using BlogAPI.Models;
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
		public DbSet<BlogAPI.Models.Post>? Post { get; set; }
	}
}


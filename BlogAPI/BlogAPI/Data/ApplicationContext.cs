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
        public DbSet<BlogAPI.Models.Domain.Concrete.SubComment>? SubComment { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SubComment>()
               .HasOne(sc => sc.Comment)
               .WithMany(c => c.SubComment)
               .HasForeignKey(sc => sc.CommentId)
               .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Comment>()
               .HasOne(c => c.Post)
               .WithMany(p => p.Comments)
               .HasForeignKey(c => c.PostId)
               .OnDelete(DeleteBehavior.Restrict);

        }

        
    }
}


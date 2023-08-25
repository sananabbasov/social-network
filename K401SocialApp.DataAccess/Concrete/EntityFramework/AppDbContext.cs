using System;
using K401SocialApp.Core.Configurations;
using K401SocialApp.Core.Entities.Concrete;
using K401SocialApp.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace K401SocialApp.DataAccess.Concrete.EntityFramework
{
	public class AppDbContext : DbContext
	{
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(DatabaseConfiguration.ConntectionString);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<AppUserRole> UserRoles { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<FriendList> FriendLists { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Reaction> Reactions { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<FriendList>()
                .HasKey(x => x.Id);
            builder.Entity<FriendList>()
                .HasOne(cs => cs.User)
                .WithMany(c => c.FriendLists)
                .HasForeignKey(cs => cs.FriendId)
                .OnDelete(DeleteBehavior.Restrict);


            builder.Entity<Comment>()
                .HasOne(x=>x.User)
                .WithMany()
                .HasForeignKey(a=>a.UserId)
                .OnDelete(DeleteBehavior.Restrict);


            builder.Entity<Reaction>()
                .HasOne(x => x.User)
                .WithMany()
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Restrict);

        }

    }
}


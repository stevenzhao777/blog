
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using blog.Domain;

namespace blog.Data
{
    public class blogContext: DbContext
    {
        public blogContext(DbContextOptions<blogContext> options) 
            :base(options)
        { }
        public DbSet<User> Users { get; set; }
        public DbSet<UserInfo> UserInfo { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .ToTable("users");
            modelBuilder.Entity<User>()
                .Property(u => u.UserId)
                .HasColumnName("user_id");
            modelBuilder.Entity<User>()
                .Property(u => u.UserName)
                .HasColumnName("user_name");
            modelBuilder.Entity<User>()
                .Property(u => u.Passcode)
                .HasColumnName("passcode");

            modelBuilder.Entity<UserInfo>()
                .ToTable("user_info");
            modelBuilder.Entity<UserInfo>()
                .Property(u => u.UserInfoId)
                .HasColumnName("user_info_id");
            modelBuilder.Entity<UserInfo>()
                .Property(u => u.Address)
                .HasColumnName("address");
            modelBuilder.Entity<UserInfo>()
                .Property(u => u.PhoneNumber)
                .HasColumnName("phone_number");
            modelBuilder.Entity<UserInfo>()
                .Property(u => u.EmailAddress)
                .HasColumnName("email_address");

            modelBuilder.Entity<Blog>().ToTable("blogs");
            modelBuilder.Entity<Comment>().ToTable("comments");

            modelBuilder.Entity<FollowerFollowee>()
                .HasOne(from => from.Follower)
                .WithMany(to => to.Followees)
                .HasForeignKey(from => from.FollowerId);
            modelBuilder.Entity<FollowerFollowee>()
                .HasOne(from => from.Followee)
                .WithMany(to => to.Followers)
                .HasForeignKey(from => from.FolloweeId);
        }
    }
}

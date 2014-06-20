using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Strawberry.Web.Models;
using System.Data.Entity.Infrastructure;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Strawberry.Web.DataAccessLayer
{
        
    public class MyContext : IdentityDbContext<ApplicationUser>
    {
        public MyContext() : base("MyContext") { }

        public DbSet<Group> Groups { get; set; }
        public DbSet<MyTask> Tasks { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Ignore external login tables
            modelBuilder.Ignore<IdentityUserLogin>();
            modelBuilder.Ignore<IdentityUserClaim>();

            // One-to-one applicationUser->UserProfile
            modelBuilder.Entity<ApplicationUser>()
                .HasRequired<UserProfile>(a => a.UserProfile);

            modelBuilder.Entity<UserProfile>()
                .HasOptional<ApplicationUser>(u => u.Account);

            // one-to-many task->assignment
            modelBuilder.Entity<Assignment>()
                .HasRequired<MyTask>(t => t.Task)
                .WithMany(t => t.Assignments).HasForeignKey(t => t.TaskId)
                .WillCascadeOnDelete(true);

            // one-to-one assignment->userProfile
            modelBuilder.Entity<Assignment>()
                .HasRequired<UserProfile>(a => a.User);

            // one-to-many group->assignment
            modelBuilder.Entity<Assignment>()
                .HasOptional<Group>(g => g.Group)
                .WithMany(g => g.Assignments).HasForeignKey(g => g.GroupId)
                .WillCascadeOnDelete(true); 
        }

        
        
    }
}
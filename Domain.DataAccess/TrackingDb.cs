using Domain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace Domain.DataAccess
{
    public class TrackingDb : IdentityDbContext<User>
    {
        public DbSet<Project> Projects { get; set; }
        public DbSet<TaskProject> Tasks { get; set; }
        public DbSet<PersonalStatic> PersonalStatics { get; set; }

        public TrackingDb(DbContextOptions<TrackingDb> options) : base(options)
        {
            Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}

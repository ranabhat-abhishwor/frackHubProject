using FrackerHub.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FrackerHub.Repositories
{
    public class AppDbContext: IdentityDbContext<User, Role, int>
    {
        //needed for migration purpose
        public AppDbContext()
        {
                
        }

        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }
        public DbSet<Asset> Assets { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Item> Items { get; set; }
        public DbSet<ItemType> ItemTypes { get; set; }
        public DbSet<UserItem> UserItems { get; set; }



        //public DbSet<Status_definitions> Status_definition { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"data source=.; initial catalog=FrackHub; integrated security = True;");
            }

            base.OnConfiguring(optionsBuilder);
        }
    }
}

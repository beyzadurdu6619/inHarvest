using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
namespace DataAccessLayer.Contexts
{
    public class AgricultureContext:IdentityDbContext
    {
       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-78IUAHN;initial Catalog=Agriculture;integrated Security=true;TrustServerCertificate=true");
        }
        public DbSet<EntityLayer.Concreate.Address> Addresses { get; set; }
        public DbSet<EntityLayer.Concreate.Contact> Contacts { get; set; }
        public DbSet<EntityLayer.Concreate.Image> Images { get; set; }
        public DbSet<EntityLayer.Concreate.Announcement> Announcements { get; set; }
        public DbSet<EntityLayer.Concreate.Services> Services { get; set; }
        public DbSet<EntityLayer.Concreate.Team> Teams { get; set; }
        public DbSet<EntityLayer.Concreate.SocialMedia> SocialMedias { get; set; }
        public DbSet<EntityLayer.Concreate.About> Abouts { get; set; }
        public DbSet<EntityLayer.Concreate.Admin> Admins { get; set; }
    }
}

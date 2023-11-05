using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PhotoPortfolio.Areas.adminpanel.Models;
using System.Data.Common;
using System.Reflection.Metadata;

namespace PhotoPortfolio.Models
{
    public class AppDbContext : IdentityDbContext<AppUser, AppRole, string>
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt){}


        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Footer> Footers { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<GalleryCategory> GalleryCategories { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<HomePage> HomePages { get; set; }
        public DbSet<Pages> Pages { get; set; }

    }
}

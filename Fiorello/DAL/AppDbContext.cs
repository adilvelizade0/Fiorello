using Fiorello.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace Fiorello.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Expert> Experts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        
        public DbSet<Say> Says { get; set; }

    }
}
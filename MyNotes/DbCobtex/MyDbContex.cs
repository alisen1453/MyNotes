
using Microsoft.EntityFrameworkCore;
using MyNotes.Models;

namespace MyNotes.DbCobtex
{
    public class MyDbContex : DbContext

    {
        public MyDbContex(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryNote> categoryNotes { get; set; }


    }
}

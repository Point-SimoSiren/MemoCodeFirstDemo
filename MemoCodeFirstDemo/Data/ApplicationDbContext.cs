using MemoCodeFirstDemo.Models;
using Microsoft.EntityFrameworkCore;


namespace MemoCodeFirstDemo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Memo> Memos { get; set; }
    }
}

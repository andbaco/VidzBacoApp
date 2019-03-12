using Microsoft.EntityFrameworkCore;
using VidzBaco.API.Models;

namespace VidzBaco.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
        public DbSet<Value> Values {get; set; }
    }
}
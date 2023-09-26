using BacBo.Models;
using Microsoft.EntityFrameworkCore;

namespace BacBo.Database;

public class BacBoContext : DbContext
{
    public BacBoContext()
    {
    }

    public BacBoContext(DbContextOptions options) : base(options) { }

    public DbSet<BacBoResult> BacBoResults { get; set; }
    public DbSet<RouletteResult> RouletteResults { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Filename=db.db");
    }
}

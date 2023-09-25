using Microsoft.EntityFrameworkCore;

namespace BacBo.Database;

public class BacBoContextFactory
{
    public BacBoContext CreateDbContext()
    {
        var optionsBuilder = new DbContextOptionsBuilder<BacBoContext>();
        optionsBuilder.UseSqlite("Filename=db.db");

        return new BacBoContext(optionsBuilder.Options);
    }
}
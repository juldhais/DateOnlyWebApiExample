using Microsoft.EntityFrameworkCore;

namespace DateOnlyWebApiExample;

public sealed class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
{
    public DbSet<Person> Person { get; set; }
}

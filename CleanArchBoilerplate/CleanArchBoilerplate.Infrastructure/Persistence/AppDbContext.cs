using CleanArchBoilerplate.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArchBoilerplate.Infrastructure.Persistence;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<ExampleEntity> ExampleEntities => Set<ExampleEntity>();
}

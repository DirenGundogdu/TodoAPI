using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using TodoAPI.Models;

namespace TodoAPI.AppDataContext;

public class TodoDbContext :  DbContext
{
    private readonly DbSettings _dbsettings;

    public TodoDbContext(IOptions<DbSettings> dbSettings)
    {
        _dbsettings = dbSettings.Value;
    }
    
    public DbSet<Todo> Todos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
     optionsBuilder.UseSqlServer(_dbsettings.ConnectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Todo>()
            .ToTable("TodoAPI")
            .HasKey(x => x.Id);
    }
}
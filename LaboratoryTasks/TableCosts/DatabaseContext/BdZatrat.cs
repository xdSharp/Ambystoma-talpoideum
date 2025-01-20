using Microsoft.EntityFrameworkCore;
using IbragimovLaba5.Entity;

namespace IbragimovLaba5.DatabaseContext;

public class BdZatrat : DbContext
{
    public DbSet<TransactionEntity> Transactions { get; set; } = null!;


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TransactionEntity>(transactionTableConfig =>
        {
            transactionTableConfig.HasKey(t => t.Id);
            transactionTableConfig.HasIndex(t => t.Title).IsUnique();
        });
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string dbPath = Path.Combine(FileSystem.Current.AppDataDirectory, "BdZatrat.bd");
        optionsBuilder.UseSqlite($"Filename={dbPath}");
    }
}

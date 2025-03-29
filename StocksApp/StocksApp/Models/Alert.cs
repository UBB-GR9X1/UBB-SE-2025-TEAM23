using Microsoft.EntityFrameworkCore;

//namespace StocksApp.Models 
//{
//    public class Alert
//    {
//        public string Name { get; set; } = string.Empty;
//        public double UpperBound { get; set; }
//        public double LowerBound { get; set; }
//        public bool IsOn { get; set; }
//    }
//}
public class StocksAppContext : DbContext
{
    public DbSet<Alert> Alerts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer(@"Server=DESKTOP-4O0PI57\SQLEXPRESS;Database=StocksAppDB;Trusted_Connection=True;TrustServerCertificate=True;");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Alert>().ToTable("Alerts");
    }

}

public class Alert
{
    public int AlertId { get; set; }  // Changed from AlertID to AlertId
    public string Name { get; set; }
    public bool ToggleOnOff { get; set; }
    public int UpperBound { get; set; }
    public int LowerBound { get; set; }
}

using Microsoft.EntityFrameworkCore;
using RestorauntTrueCost.Shared.Entities;

namespace RestorauntTrueCost.Server.Models.DatabaseContext;

public partial class RestorauntDbContext : DbContext
{
    public RestorauntDbContext(DbContextOptions<RestorauntDbContext> options)
        : base(options)
    {
        Database.EnsureCreated();
    }

    public virtual DbSet<MenuPosition> MenuPositions { get; set; }

    public virtual DbSet<PositionType> PositionTypes { get; set; }

    public virtual DbSet<Review> Reviews { get; set; }

    public virtual DbSet<Section> Sections { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Table> Tables { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderToPosition> OrderToPositions { get; set; }

    public virtual DbSet<TableOrder> TableOrders { get; set; }

    public virtual DbSet<OrderPeriod> OrderPeriods { get; set; }

    public virtual DbSet<CartToPosition> CartToPositions { get; set; }

    public virtual DbSet<OrderStatus> OrderStatus { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseLazyLoadingProxies();

        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.UseSerialColumns();

        modelBuilder.Entity<MenuPosition>().Property(m => m.Id).UseIdentityColumn();
        modelBuilder.Entity<Section>().Property(s => s.Id).UseIdentityColumn();
        modelBuilder.Entity<PositionType>().Property(p => p.Id).UseIdentityColumn();
        modelBuilder.Entity<Review>().Property(p => p.Id).UseIdentityColumn();
        modelBuilder.Entity<User>().Property(u => u.Id).UseIdentityColumn();
        modelBuilder.Entity<Table>().Property(t => t.Id).UseIdentityColumn();
        modelBuilder.Entity<Order>().Property(o => o.Id).UseIdentityColumn();
        modelBuilder.Entity<TableOrder>().Property(t => t.Id).UseIdentityColumn();
        modelBuilder.Entity<OrderPeriod>().Property(o => o.Id).UseIdentityColumn();
        modelBuilder.Entity<OrderToPosition>().Property(o => o.Id).UseIdentityColumn();
        modelBuilder.Entity<CartToPosition>().Property(o => o.Id).UseIdentityColumn();
        modelBuilder.Entity<OrderStatus>().Property(o => o.Id).UseIdentityColumn();

        modelBuilder.Entity<Table>()
            .HasIndex(t => t.TableNum)
            .IsUnique();
    }
}

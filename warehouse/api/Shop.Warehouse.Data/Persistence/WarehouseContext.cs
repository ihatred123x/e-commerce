using Microsoft.EntityFrameworkCore;
using Shop.Warehouse.Data.Persistence.Models;

namespace Shop.Warehouse.Data.Persistence
{
    public class WarehouseContext : DbContext
    {

        #region DbSet

        public DbSet<Catalog> Catalogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Courier> Couriers { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<ShippingLabel> ShippingLabels { get; set; }
        public DbSet<ShippingType> ShippingTypes { get; set; }
        #endregion

        #region Constructor

        public WarehouseContext(DbContextOptions<WarehouseContext> options)
            : base(options)
        {

        }

        #endregion


        #region Override Members

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        #endregion
    }
}
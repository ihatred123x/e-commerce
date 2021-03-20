using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Warehouse.Data.Persistence.Models
{
    [Table(nameof(Inventory))]
    public class Inventory
    {
        [Key]
        public Guid Id { get; set; }
        public Guid CatalogId { get; set; }
        [ForeignKey(nameof(CatalogId))]
        public Catalog Catalog { get; set; }
        [DefaultValue(0)]
        public int Stock { get; set; }
        [DefaultValue(0)]
        public int Ordered { get; set; }
    }
}
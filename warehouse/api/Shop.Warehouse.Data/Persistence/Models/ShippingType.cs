using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Warehouse.Data.Persistence.Models
{
    [Table(nameof(ShippingType))]
    public class ShippingType
    {
        [Key]
        public Guid Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Warehouse.Data.Persistence.Models
{
    [Table(nameof(ShippingLabel))]
    public class ShippingLabel
    {
        [Key]
        public Guid Id { get; set; }
        public Guid CourierId { get; set; }
        [ForeignKey(nameof(CourierId))]
        public Courier Courier { get; set; }
        [MaxLength(250)]
        public string Destination { get; set; }
        [MaxLength(250)]
        public string Consignee { get; set; }
        public Guid ShippingTypeId  {get; set; }
        [ForeignKey(nameof(ShippingTypeId))]
        public ShippingType ShippingType { get; set; }

    }
}
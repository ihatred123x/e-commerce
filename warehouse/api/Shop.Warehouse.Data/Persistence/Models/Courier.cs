using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Warehouse.Data.Persistence.Models
{
    [Table(nameof(Courier))]
    public class Courier
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
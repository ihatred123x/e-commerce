using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Warehouse.Data.Persistence.Models
{
    [Table(nameof(Catalog))]
    public class Catalog
    {
        [Key]
        public Guid Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(150)]
        public string Description { get; set; }
        public ICollection<Category> Categories { get; set; }
    }
}
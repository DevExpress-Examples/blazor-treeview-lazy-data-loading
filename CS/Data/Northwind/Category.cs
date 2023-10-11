using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace DataMappings.Data.Northwind {
    public partial class Category {
        public Category() {
            Products = new HashSet<Product>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }

        [NotMapped]
        public bool HasProducts { get; set; } = true;

        public virtual ICollection<Product> Products { get; set; }
    }
}

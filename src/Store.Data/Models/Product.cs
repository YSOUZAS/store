using System;

namespace Store.Data.Models
{
    public class Product : NamedEntity
    {
        public Product(string name) : base(name)
        {
        }

        public string Description { set; get; }
        public string Image { set; get; }
        public decimal Price { set; get; }
        public bool Active { set; get; }


        /* EF Relation */
        public Guid SupplierId { get; set; }
        public Supplier Supplier { get; set; }
    }
}

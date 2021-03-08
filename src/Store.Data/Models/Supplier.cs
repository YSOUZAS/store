using Store.Data.Enums;
using System.Collections.Generic;

namespace Store.Data.Models
{
    public class Supplier : NamedEntity
    {
        public Supplier() : base(string.Empty)
        {

        }

        public Supplier(string name) : base(name)
        {
        }

        public string Document { set; get; }
        public SupplierType Type { set; get; }
        public Address Address { set; get; }
        public bool Active { get; set; }


        /* EF Relation */
        public IEnumerable<Product> Products { get; set; }
    }
}

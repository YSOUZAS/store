using Store.Data.Enums;
using System.Collections.Generic;

namespace Store.Data.Models
{
    public class Supplier : NamedEntity
    {
        public Supplier(string name, string document, SupplierType type, Address address, bool active) : base(name)
        {
            Document = document;
            Type = type;
            Address = address;
            Active = active;
        }

        public string Document { set; get; }
        public SupplierType Type { set; get; }
        public Address Address { set; get; }
        public bool Active { get; set; }


        /* EF Relation */
        public IEnumerable<Product> Products { get; set; }
    }
}

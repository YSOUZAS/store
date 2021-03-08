using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.App.ViewModels
{
    public class SupplierViewModel
    {
        public string Document { set; get; }
        //public SupplierType Type { set; get; }
        //public Address Address { set; get; }
        public bool Active { get; set; }


        /* EF Relation */
        // public IEnumerable<Product> Products { get; set; }
    }
}

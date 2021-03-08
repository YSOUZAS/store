using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.App.ViewModels
{
    public class AddressViewModel
    {
        public string Patio { set; get; }
        public string Number { set; get; }
        public string Additional { set; get; }
        public string ZipCode { set; get; }
        public string Neighborhood { set; get; }
        public string City { set; get; }
        public string State { set; get; }


        /* EF Relation */
        public Guid SupplierId { get; set; }
       // public Supplier Supplier { get; set; }
    }
}

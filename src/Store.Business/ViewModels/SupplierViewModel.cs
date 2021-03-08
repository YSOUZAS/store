using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Store.Business.ViewModels
{
    public class SupplierViewModel
    {
        [Key]
        public Guid Id { set; get; }

        [Required(ErrorMessage = "{0} is required.")]
        [StringLength(200, ErrorMessage = "The {0} field must be between {2} and {1} characters", MinimumLength = 2)]
        public string Name { set; get; }

        [Required(ErrorMessage = "{0} is required.")]
        [StringLength(14, ErrorMessage = "The {0} field must be between {2} and {1} characters", MinimumLength = 2)]
        public string Document { set; get; }
        public int Type { set; get; }
        public AddressViewModel Address { set; get; }
        public bool Active { get; set; }

        public IEnumerable<ProductViewModel> Products { get; set; }

        [ScaffoldColumn(false)]
        public DateTime CreateAt { get; set; }

        [ScaffoldColumn(false)]
        public DateTime UpdateAt { get; set; }

    }
}

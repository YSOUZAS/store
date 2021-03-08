using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;

namespace Store.Business.ViewModels
{
    public class AddressViewModel
    {
        [Key]
        public Guid Id { set; get; }

        [Required(ErrorMessage = "{0} is required.")]
        [StringLength(200, ErrorMessage = "The {0} field must be between {2} and {1} characters", MinimumLength = 2)]
        public string Patio { set; get; }

        [Required(ErrorMessage = "{0} is required.")]
        [StringLength(50, ErrorMessage = "The {0} field must be between {2} and {1} characters", MinimumLength = 2)]
        public string Number { set; get; }

        [Required(ErrorMessage = "{0} is required.")]
        [StringLength(250, ErrorMessage = "The {0} field must be between {2} and {1} characters", MinimumLength = 2)]
        public string Additional { set; get; }

        [Required(ErrorMessage = "{0} is required.")]
        [StringLength(8, ErrorMessage = "The {0} field must be between {2} and {1} characters", MinimumLength = 8)]
        public string ZipCode { set; get; }

        [Required(ErrorMessage = "{0} is required.")]
        [StringLength(100, ErrorMessage = "The {0} field must be between {2} and {1} characters", MinimumLength = 2)]
        public string Neighborhood { set; get; }

        [Required(ErrorMessage = "{0} is required.")]
        [StringLength(100, ErrorMessage = "The {0} field must be between {2} and {1} characters", MinimumLength = 2)]
        public string City { set; get; }

        [Required(ErrorMessage = "{0} is required.")]
        [StringLength(100, ErrorMessage = "The {0} field must be between {2} and {1} characters", MinimumLength = 2)]
        public string State { set; get; }


        [ScaffoldColumn(false)]
        public DateTime CreateAt { get; set; }

        [ScaffoldColumn(false)]
        public DateTime UpdateAt { get; set; }

        [HiddenInput]
        public Guid SupplierId { get; set; }
        //public SupplierViewModel Supplier { get; set; }
    }
}

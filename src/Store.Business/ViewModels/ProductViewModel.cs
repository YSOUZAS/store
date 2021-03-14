using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store.Business.ViewModels
{
    public class ProductViewModel : BaseViewModel
    {
        [Required(ErrorMessage = "{0} is required.")]
        [StringLength(200, ErrorMessage = "The {0} field must be between {2} and {1} characters", MinimumLength = 2)]
        public string Name { set; get; }

        [Required(ErrorMessage = "{0} is required.")]
        [StringLength(1000, ErrorMessage = "The {0} field must be between {2} and {1} characters", MinimumLength = 2)]
        public string Description { set; get; }

        public IFormFile UploadImage { set; get; }

        public string Image { set; get; }

        [Required(ErrorMessage = "{0} is required.")]
        public decimal Price { set; get; }

        public bool Active { set; get; }

        [Required(ErrorMessage = "{0} is required.")]
        [DisplayName("Supplier")]
        public Guid SupplierId { get; set; }

        public SupplierViewModel Supplier { get; set; }

        [NotMapped]
        public IEnumerable<SupplierViewModel> Suppliers { get; set; }

        [ScaffoldColumn(false)]
        public DateTime CreateAt { get; set; }

        [ScaffoldColumn(false)]
        public DateTime UpdateAt { get; set; }

    }
}

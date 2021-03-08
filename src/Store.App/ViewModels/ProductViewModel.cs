using System;
using System.ComponentModel.DataAnnotations;

namespace Store.App.ViewModels
{
    public class ProductViewModel
    {
        [Key]
        public Guid Id { set; get; }

        [Required(ErrorMessage = "{0} is required.")]
        [StringLength(200, ErrorMessage = "The {0} field must be between {2} and {1} characters", MinimumLength = 2)]
        public string Name { set; get; }

        [Required(ErrorMessage = "{0} is required.")]
        [StringLength(200, ErrorMessage = "The {0} field must be between {2} and {1} characters", MinimumLength = 2)]
        public string Description { set; get; }

        [Required(ErrorMessage = "{0} is required.")]
        [StringLength(200, ErrorMessage = "The {0} field must be between {2} and {1} characters", MinimumLength = 2)]
        public string Image { set; get; }
        public decimal Price { set; get; }
        public bool Active { set; get; }
        public SupplierViewModel Supplier { get; set; }

        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
    }
}

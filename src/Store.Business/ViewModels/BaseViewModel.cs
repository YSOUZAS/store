using System;
using System.ComponentModel.DataAnnotations;

namespace Store.Business.ViewModels
{
    public abstract class BaseViewModel
    {
        [Key]
        public Guid Id { get; set; }
    }
}

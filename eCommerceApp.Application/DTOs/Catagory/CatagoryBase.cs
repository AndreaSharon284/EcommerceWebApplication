
using System.ComponentModel.DataAnnotations;

namespace eCommerceApp.Application.DTOs.Catagory
{
    public class CategoryBase
    {
        [Required]
        public string? Name { get; set; }
    }
}


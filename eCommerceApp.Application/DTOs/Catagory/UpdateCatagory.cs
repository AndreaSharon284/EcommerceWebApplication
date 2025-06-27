using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace eCommerceApp.Application.DTOs.Catagory
{
    public class UpdateCategory : CategoryBase
    {
        [Required]
        public  Guid Id { get; set; }
    }
}



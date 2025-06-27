using eCommerceApp.Application.DTOs.Catagory;
using eCommerceApp.Application.DTOs.Product;

namespace eCommerceApp.Application.DTOs.Category;

    public class GetCategory : CategoryBase
    {
        public Guid Id { get; set; }
        public ICollection<GetProduct>? Products { get; set; } = [];
    }



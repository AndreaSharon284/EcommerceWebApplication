using System.ComponentModel.DataAnnotations;
using eCommerceApp.Application.DTOs.Catagory;
using eCommerceApp.Application.DTOs.Category;

namespace eCommerceApp.Application.DTOs.Product;

public class GetProduct : ProductBase
{
    [Required(ErrorMessage = "")]
    public Guid Id { get; set; }
    public GetCategory? Category { get; set; } 
}
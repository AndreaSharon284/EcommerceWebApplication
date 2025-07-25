using eCommerceApp.Application.DTOs;
using eCommerceApp.Application.DTOs.Catagory;
using eCommerceApp.Application.DTOs.Product;
using eCommerceApp.Domain.Entities;

namespace eCommerceApp.Application.Services.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<GetProduct>> GetAllAsync();
        Task<ServiceResponse> AddAsync(CreateProduct product);
        Task<ServiceResponse> UpdateAsync(UpdateProduct product);
        Task<ServiceResponse> DeleteAsync(Guid id);
        Task<GetProduct> GetByIdAsync(Guid id);
    }
    
}


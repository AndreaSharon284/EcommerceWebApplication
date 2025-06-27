using eCommerceApp.Application.DTOs;
using eCommerceApp.Application.DTOs.Catagory;
using eCommerceApp.Application.DTOs.Category;

namespace eCommerceApp.Application.Services.Interfaces;

public interface ICatagoryService
{
        Task<IEnumerable<GetCategory>> GetAllAsync();
        Task<ServiceResponse> AddAsync(CreateCategory category);
        Task<ServiceResponse> UpdateAsync(UpdateCategory category);
        Task<ServiceResponse> DeleteAsync(Guid id);
        Task<GetCategory> GetByIdAsync(Guid id);
}
using System.Security.Claims;
using eCommerceApp.Domain.Identity;

namespace eCommerceApp.Domain.Interfaces.Authentication
{
    public interface IRoleManagement
    {
        Task<string?> GetUserRole(string userEmail);
        Task<bool> AddUserToRole(AppUser user, string roleName);
    }
}


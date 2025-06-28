using eCommerceApp.Application.DTOs;
using eCommerceApp.Application.DTOs.Identity;
using eCommerceApp.Application.Services.Interfaces.Authentication;

namespace eCommerceApp.Application.Services.Implementations.Authentication;

public class AuthenticationService : IAuthenticationService
{
    public Task<ServiceResponse> CreateUser(CreateUser user)
    {
        throw new NotImplementedException();
    }

    public Task<LoginResponse> LoginUser(LoginUser user)
    {
        throw new NotImplementedException();
    }

    public Task<LoginResponse> ReviveToken(string refreshToken)
    {
        throw new NotImplementedException();
    }
}
#nullable disable

using Application.Dtos.Account;
using Application.Interfaces.Services;

namespace Infrastructure.Identity.Services;

public class UserService : IUserService
{
    public Task<LoginResponseDto> LoginUserAsync(LoginDto loginDto)
    {
        throw new NotImplementedException();
    }

    public Task<RegisterResponseDto> RegisterUserAsync(RegisterDto registerDto)
    {
        throw new NotImplementedException();
    }
}

using Application.Dtos.Account;

namespace Application.Interfaces.Services;

public interface IUserService
{
    Task<RegisterResponseDto> RegisterUserAsync(RegisterDto registerDto);
    Task<LoginResponseDto> LoginUserAsync(LoginDto loginDto);
}

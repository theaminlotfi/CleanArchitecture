#nullable disable

namespace Application.Dtos.Account;

public record LoginResponseDto(bool Flag, string Message = null, string Token = null);

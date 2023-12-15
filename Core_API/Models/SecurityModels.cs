namespace Core_API.Models
{
    public class RegisterUser
    {
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? ConfirmPassword { get; set; }
    }

    public class LoginUser
    {
        public string? UserName { get; set; }
        public string? Password { get; set; }
    }

    public class RoleInfo
    {
        public string? RoleName { get; set; }
    }

    public class UserInRole
    {
        public string? UserName { get; set; }
        public string? RoleName { get; set; }
    }

    public record SecurityResponse
    {
        public string? Token { get; set; }
        public bool IsSuccess { get; set; }
    }
}

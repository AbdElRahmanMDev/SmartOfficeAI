namespace SmartOfficeAI.Features.UserManagment.RegisterUser.DTOs
{
    public class CreateUserResult
    {
        public Guid Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
    }
}

namespace SmartOfficeAI.Features.UserManagment.ReviewUser
{
    public record ReviewUserRequest(Guid UserId, string Action, Guid? NewRole = null);

}

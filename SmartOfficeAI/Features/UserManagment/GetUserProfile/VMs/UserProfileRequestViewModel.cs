using FluentValidation;

namespace SmartOfficeAI.Features.UserManagment.GetUserProfile.VMs
{
    public record UserProfileRequestViewModel(Guid Id);



    public class UserProfileRequestViewModelValidator : AbstractValidator<UserProfileRequestViewModel>
    {
        public UserProfileRequestViewModelValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
        }
    }
}

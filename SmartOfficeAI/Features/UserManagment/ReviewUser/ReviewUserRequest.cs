using FluentValidation;

namespace SmartOfficeAI.Features.UserManagment.ReviewUser
{
    public record ReviewUserRequest(Guid UserId, string Action, Guid? NewRole = null);

    public class ReviewUserRequestValidator : AbstractValidator<ReviewUserRequest>
    {
        public ReviewUserRequestValidator()
        {
            RuleFor(x => x.UserId)
                .NotEmpty()
                .WithMessage("UserId is required.");

            RuleFor(x => x.Action)
                .NotEmpty()
                .WithMessage("Action is required.")
                .Must(action => action == "Approve" || action == "Reject")
                .WithMessage("Action must be either 'Approve' or 'Reject'.");
        }
    }

}

using MediatR;
using SmartOfficeAI.Common.Views;
using SmartOfficeAI.Entities.Common;
using SmartOfficeAI.Errors;
using SmartOfficeAI.Features.Common;
using SmartOfficeAI.Persistance.Data;

namespace SmartOfficeAI.Features.UserManagment.ReviewUser.Command
{
    public record ReviewUserCommand(Guid UserId, string Action, Guid? NewRole = null)
      : IRequest<RequestResult<string>>;


    public class ReviewUserCommandHandler : RequestHandlerBase<ReviewUserCommand, RequestResult<string>>
    {
        private readonly Repository<User> _userRepo;
        private readonly Repository<Role> _roleRepo;
        public ReviewUserCommandHandler(RequestHandlerBaseParameters parameters, Repository<User> repository, Repository<Role> role) : base(parameters)
        {
            _userRepo = repository;
            _roleRepo = role;
        }

        public override async Task<RequestResult<string>> Handle(ReviewUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _userRepo.Get(x => x.Id == request.UserId).FirstOrDefaultAsync();
            if (user == null)
                return RequestResult<string>.Failure(UserErrors.UserNotFound, "User not found");

            switch (request.Action.ToLower())
            {
                case "approve":
                    user.status = RequestStatus.Active;
                    break;

                case "reject":
                    user.status = RequestStatus.Rejected;
                    break;

                case "modifyrole":

                    var role = await _roleRepo.Get(r => r.Id == request.NewRole).FirstOrDefaultAsync();
                    if (role == null)
                        return RequestResult<string>.Failure(RoleErrors.RoleNotFound, "Role not found.");
                    user.RoleId = role.Id;
                    user.status = RequestStatus.Active;
                    break;
                default:
                    return RequestResult<string>.Failure(new Abstraction.Error("Invalid action", "InValid.Action", StatusCodes.Status400BadRequest), "Invalid action.");

            }
            await _userRepo.SaveChangesAsync();
            // TODO: Send email notification to user about approval/rejection/role change
            return RequestResult<string>.Success($"User {request.Action} successful.", "User Status Updated");

        }
    }

}

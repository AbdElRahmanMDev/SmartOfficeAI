using Mapster;
using Microsoft.AspNetCore.Mvc;
using SmartOfficeAI.Common.Views;
using SmartOfficeAI.Features.Common;
using SmartOfficeAI.Features.UserManagment.GetUserProfile.Query;
using SmartOfficeAI.Features.UserManagment.GetUserProfile.VMs;

namespace SmartOfficeAI.Features.UserManagment.GetUserProfile
{
    public class GetUserProfileEndpoint : EndpointBase<UserProfileRequestViewModel, UserProfileResponseViewModel>
    {
        public GetUserProfileEndpoint(EndpointBaseParameters<UserProfileRequestViewModel> dependencyCollection) : base(dependencyCollection)
        {
        }

        [HttpGet("api/user/profile")]
        public async Task<EndPointResponse<UserProfileResponseViewModel>> GetDisabilityById([FromQuery] UserProfileRequestViewModel request)
        {
            var validationResult = await ValidateRequestAsync(request);
            if (!validationResult.IsSuccess) return validationResult;

            var userProfile = await _mediator.Send(new GetUserProfileByIdQuery(request.Id));

            return userProfile.IsSuccess ?
                    EndPointResponse<UserProfileResponseViewModel>.Success(userProfile.Data.Adapt<UserProfileResponseViewModel>(), userProfile.Message) :
                    EndPointResponse<UserProfileResponseViewModel>.Failure(userProfile.ErrorCode, userProfile.Message);
        }

    }
}

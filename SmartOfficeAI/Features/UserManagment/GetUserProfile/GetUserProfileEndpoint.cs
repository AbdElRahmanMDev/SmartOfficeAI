using Microsoft.AspNetCore.Mvc;
using SmartOfficeAI.Features.Common;
using SmartOfficeAI.Features.UserManagment.GetUserProfile.Query;
using SmartOfficeAI.Features.UserManagment.GetUserProfile.VMs;

namespace SmartOfficeAI.Features.UserManagment.GetUserProfile
{
    public class GetUserProfileEndpoint : EndpointBase<UserProfileRequestViewModel, IActionResult>
    {
        public GetUserProfileEndpoint(EndpointBaseParameters<UserProfileRequestViewModel> dependencyCollection) : base(dependencyCollection)
        {
        }

        [HttpGet("api/user/profile")]
        public async Task<IActionResult> GetDisabilityById([FromQuery] UserProfileRequestViewModel request)
        {
            var validationResult = await ValidateRequestAsync(request);
            if (!validationResult.IsSuccess)
                return BadRequest(validationResult);

            var result = await _mediator.Send(new GetUserProfileByIdQuery(request.Id));

            if (result.IsSuccess)
                return Ok(result.Data);

            var statusCode = result.ErrorCode.StatusCode ?? StatusCodes.Status400BadRequest;
            return StatusCode(statusCode, result.ErrorCode);
        }

    }
}

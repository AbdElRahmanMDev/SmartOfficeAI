using Mapster;
using Microsoft.AspNetCore.Mvc;
using SmartOfficeAI.Features.Common;
using SmartOfficeAI.Features.UserManagment.ReviewUser.Command;

namespace SmartOfficeAI.Features.UserManagment.ReviewUser
{
    public class ReviewUserEndpoint : EndpointBase<ReviewUserRequest, IActionResult>
    {
        public ReviewUserEndpoint(EndpointBaseParameters<ReviewUserRequest> dependencyCollection) : base(dependencyCollection)
        {
        }

        [HttpPost("api/role/review")]
        public async Task<IActionResult> Review(ReviewUserRequest request)
        {

            var validationResult = await ValidateRequestAsync(request);
            if (!validationResult.IsSuccess)
                return BadRequest(validationResult);

            var command = request.Adapt<ReviewUserCommand>();
            var result = await _mediator.Send(command);



            if (result.IsSuccess)
                return Ok(result.Data);

            var statusCode = result.ErrorCode.StatusCode ?? StatusCodes.Status400BadRequest;
            return StatusCode(statusCode, result.ErrorCode);
        }
    }
}

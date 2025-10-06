using MediatR;

namespace SmartOfficeAI.Features.Common
{
    public class RequestHandlerBaseParameters
    {
        public IMediator Mediator => _mediator;

        private readonly IMediator _mediator;

        public RequestHandlerBaseParameters(IMediator mediator
          )
        {
            _mediator = mediator;

        }
    }
}

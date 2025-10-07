//using MediatR;
//using SmartOfficeAI.Common.Views;
//using SmartOfficeAI.Entities;
//using SmartOfficeAI.Features.Common;
//using SmartOfficeAI.Features.UserManagment.RegisterUser.DTOs;
//using SmartOfficeAI.Persistance.Data;

//namespace SmartOfficeAI.Features.UserManagment.RegisterUser.Command
//{
//    public record RegisterUserCommand(
//        string Name,
//        string Email,
//        string Department,
//        Guid RoleId,
//        string Password
//    ) : IRequest<RequestResult<CreateUserResult>>;


//    public class RegisterUserCommandHandler : RequestHandlerBase<RegisterUserCommand, RequestResult<CreateUserResult>>
//    {
//        private readonly Repository<User> _repository;

//        public RegisterUserCommandHandler(RequestHandlerBaseParameters parameters, Repository<User> repository) : base(parameters)
//        {
//            _repository = repository;
//        }

//        public override Task<RequestResult<CreateUserResult>> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
//        {
//            var user = new User()
//            {
//                FullName = request.Name,
//                Email = request.Email,
//                Department = request.Department,
//                RoleId = request.RoleId,
//                PasswordHash = request.Password

//            };


//            return Task.FromResult(RequestResult<CreateUserResult>.Success(new CreateUserResult(user)));


//        }
//    }


//}

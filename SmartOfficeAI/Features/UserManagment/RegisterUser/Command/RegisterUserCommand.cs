using Mapster;
using MediatR;
using Microsoft.AspNetCore.Identity;
using SmartOfficeAI.Common.Views;
using SmartOfficeAI.Entities.Common;
using SmartOfficeAI.Errors;
using SmartOfficeAI.Features.Common;
using SmartOfficeAI.Features.UserManagment.RegisterUser.DTOs;
using SmartOfficeAI.Persistance.Data;

namespace SmartOfficeAI.Features.UserManagment.RegisterUser.Command
{
    public record RegisterUserCommand(
        string FullName,
        string Email,
        string Department,
        Guid RoleId,
        string Password
    ) : IRequest<RequestResult<CreateUserResult>>;


    public class RegisterUserCommandHandler : RequestHandlerBase<RegisterUserCommand, RequestResult<CreateUserResult>>
    {
        private readonly Repository<User> _userRepository;
        private readonly IPasswordHasher<User> _passwordHasher;
        private readonly Repository<Role> _roleRepository;

        public RegisterUserCommandHandler(RequestHandlerBaseParameters parameters, Repository<User> repository, IPasswordHasher<User> passwordHasher, Repository<Role> roleRepository) : base(parameters)
        {
            _userRepository = repository;
            _passwordHasher = passwordHasher;
            _roleRepository = roleRepository;

        }

        public async override Task<RequestResult<CreateUserResult>> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        {
            var exists = await _userRepository.AnyAsync(u => u.Email == request.Email);
            if (exists)
                return RequestResult<CreateUserResult>.Failure(UserErrors.DuplicateEmail, "Email already registered.");

            var role = await _roleRepository.GetByIdAsync(request.RoleId);
            if (role == null)
                return RequestResult<CreateUserResult>.Failure(RoleErrors.RoleNotFound, "Role not found.");

            var user = request.Adapt<User>();

            user.PasswordHash = _passwordHasher.HashPassword(user, request.Password);
            user.status = RequestStatus.Pending;




            await _userRepository.AddAsync(user);
            await _userRepository.SaveChangesAsync();

            //Send Email to Admin


            // Return result
            var result = new CreateUserResult
            {
                Id = user.Id,
                Email = user.Email,
                Status = user.status.ToString()
            };

            return RequestResult<CreateUserResult>.Success(result, "Account created with Pending status. Waiting for admin approval.");




        }
    }


}

using Mapster;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SmartOfficeAI.Common.Enums;
using SmartOfficeAI.Common.Views;
using SmartOfficeAI.Entities;
using SmartOfficeAI.Features.Common;
using SmartOfficeAI.Persistance.Data;

namespace SmartOfficeAI.Features.UserManagment.GetUserProfile.Query
{
    public record GetUserProfileByIdQuery(Guid Id) : IRequest<RequestResult<UserProfileDto>>;


    public record UserProfileDto(string FullName, string Email, string Position, string LanguageLanguagePreference);

    public class GetUserProfileByIdQueryValidator : RequestHandlerBase<GetUserProfileByIdQuery, RequestResult<UserProfileDto>>
    {
        private readonly Repository<User> _repository;
        public GetUserProfileByIdQueryValidator(RequestHandlerBaseParameters parameters, Repository<User> repository) : base(parameters)
        {
            _repository = repository;
        }

        public override async Task<RequestResult<UserProfileDto>> Handle(GetUserProfileByIdQuery request, CancellationToken cancellationToken)
        {
            var user = await _repository.Get(x => x.Id == request.Id).ProjectToType<UserProfileDto>().FirstOrDefaultAsync();

            if (user is null)
            {
                return RequestResult<UserProfileDto>.Failure(ErrorCode.UserNotFound, "user not found");
            }
            return RequestResult<UserProfileDto>.Success(user, "user data retrieved successfully ");


            throw new NotImplementedException();
        }
    }



}

using System;
using Domain.UserProfile;
using Microsoft.FSharp.Core;

namespace Application.UserProfile
{
    public class UserProfileService : IUserProfileService
    {
        private readonly IUserProfileRepository _userProfileRepository;

        public UserProfileService(IUserProfileRepository userProfileRepository)
        {
            _userProfileRepository = userProfileRepository;
        }

        public FSharpResult<UserAddressOutput, string> GetUserAddress(long userId)
        {
            return _userProfileRepository.GetUserAddress(userId);
        }
    }
}

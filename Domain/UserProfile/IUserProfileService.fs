namespace Domain.UserProfile

type IUserProfileService =
    abstract member GetUserAddress : userId:int64 -> Result<UserAddressOutput, string>
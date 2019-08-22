namespace Domain.UserProfile

type IUserProfileRepository =
    abstract member GetUserAddress : userId:int64 -> Result<UserAddressOutput, string>
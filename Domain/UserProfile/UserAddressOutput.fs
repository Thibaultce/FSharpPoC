namespace Domain.UserProfile

type UserAddressOutput =
    {
        UserId: int64;
        StreetName: string;
        StreetNumber: int;
        City: string;
        Country: string;
    }
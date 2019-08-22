namespace Persistence.UserProfile

open FSharp.Data
open Persistence

type GetAddressQuery = 
    SqlCommandProvider<"
        SELECT 
            UserId,
            StreetName,
            StreetNumber,
            City,
            Country
        FROM [User]
        WHERE UserId = @ParamUserId
    ", DbAccess.connectionString, SingleRow = true>
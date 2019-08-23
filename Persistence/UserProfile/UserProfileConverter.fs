namespace Persistence.UserProfile

open Domain.UserProfile

module UserProfileConverter =

    let fromGetUserAddressToModel (r: GetAddressQuery.Record) : UserAddressOutput =
        {
            UserId = r.UserId
            StreetName = r.StreetName
            StreetNumber = r.StreetNumber
            City = 
                match r.City with
                | Some c -> c
                | None -> "No city"
            Country = r.Country
        }

    let fromGetUsersToModel (r: GetUsersQuery.Record) : UserOutput =
        {
            UserId = r.UserId
            FirstName = r.FirstName
            LastName = r.LastName
        }
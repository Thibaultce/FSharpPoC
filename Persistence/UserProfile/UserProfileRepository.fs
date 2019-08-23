namespace Persistence.UserProfile

open Domain.UserProfile
open Persistence

type UserProfileRepository () =

    interface IUserProfileRepository with

        member x.GetUsers = 
            let result = 
                GetUsersQuery.Create(DbAccess.connectionString).Execute()
                |> Seq.map UserProfileConverter.fromGetUsersToModel
                |> Seq.toList
            match result with  
            | [] -> Error "No user in Database"
            | _ -> Ok result

        member x.GetUserAddress (userId) =
            let result = GetAddressQuery.Create(DbAccess.connectionString).Execute(userId)
            match result with 
            | Some r -> Ok (UserProfileConverter.fromGetUserAddressToModel r)
            | None -> Error ("No user found for userId : " + string userId)

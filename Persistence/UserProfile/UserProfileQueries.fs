namespace Persistence.UserProfile

open FSharp.Data
open Persistence

type GetAddressQuery = 
    
    SqlCommandProvider<const(SqlFile<"SQL\UserProfile\GetAddressQuery.sql">.Text), DbAccess.connectionString, SingleRow = true>
﻿namespace Persistence.UserProfile

open FSharp.Data
open Persistence

type GetAddressQuery =     
    SqlCommandProvider<const(SqlFile<"SQL/UserProfile/GetAddressQuery.sql">.Text), DbAccess.connectionString, SingleRow = true>

type GetUsersQuery =     
    SqlCommandProvider<const(SqlFile<"SQL/UserProfile/GetUsersQuery.sql">.Text), DbAccess.connectionString>
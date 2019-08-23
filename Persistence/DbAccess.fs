namespace Persistence

open System.Configuration

module DbAccess =

    [<Literal>]
    let connectionString = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=fsharppoc;"
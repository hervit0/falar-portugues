open FSharp.Data.Sql
open FSharp.Data.Sql

// let [<Literal>] resolutionPath = __SOURCE_DIRECTORY__ + @"..\..\files\sqlite" 
let [<Literal>] resolutionPath = @"C:\Projects\Libs\Npgsql"
// let [<Literal>] connectionString = "Data Source=" + __SOURCE_DIRECTORY__ + @"\northwindEF.db;Version=3"
let [<Literal>] databaseVendor = Sql.Common.DatabaseProviderTypes.POSTGRESQL
let [<Literal>] connectionString = "Host=localhost;Database=test;Username=test;Password=test"


let [<Literal>] individualsAmount = 1000
let [<Literal>] owner = "public, admin, references"


// type sql =
//     SqlDataProvider<
//         dbVendor,
//         connString,
//         "",         //ConnectionNameString can be left empty 
//         resPath,
//         indivAmount,
//         useOptTypes,
//         owner>

type sql = SqlDataProvider<
              ConnectionString = connectionString,
              DatabaseVendor = databaseVendor,
              ResolutionPath = resolutionPath,
              IndividualsAmount = individualsAmount,
              UseOptionTypes = true >
let ctx = sql.GetDataContext()

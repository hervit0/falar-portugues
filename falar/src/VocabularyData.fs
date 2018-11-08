module VocabularyData

open FSharp.Data
// open FSharp.Data.JsonExtensions

// let value () =
//   JsonValue.Load(__SOURCE_DIRECTORY__ + "../data/vocabulary.json")

let value () =
  let data = CsvFile.Load(__SOURCE_DIRECTORY__ + "/../data/vocabulary.csv").Cache()
  printfn "%A" data.Rows
  for row in data.Rows do
    printfn "Wow: (%s, %s)" (row.GetColumn "English") (row.GetColumn "Portuguese")

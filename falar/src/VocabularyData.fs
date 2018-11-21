module VocabularyData

open FalarType
open FSharp.Data

let getWorld (world : CsvRow) : World =
  {
    World.English = world.GetColumn "English";
    World.Portuguese = world.GetColumn "Portuguese"
  }

let get : seq<World> =
  CsvFile.Load(__SOURCE_DIRECTORY__ + "/../data/vocabulary.csv").Cache().Rows
  |> Seq.map getWorld


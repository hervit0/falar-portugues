module VocabularyData

open FSharp.Data

let get : seq<World.World> =
  CsvFile.Load(__SOURCE_DIRECTORY__ + "/../data/vocabulary.csv").Cache().Rows
  |> Seq.map (fun world -> {World.English = world.GetColumn "English"; World.Portuguese = world.GetColumn "Portuguese"})


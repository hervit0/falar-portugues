module ResultExporter

open FSharp.Data
open FalarType

let fileName =
  "test-" + System.DateTime.UtcNow.ToString("yyyyMMdd-HHmmss") + ".csv"

let toCsvRow (guess : Guess) : string =
  sprintf "%s;%s;%s;%s" guess.Portuguese guess.English guess.Answer guess.Correctness

let toCsv (guesses : seq<Guess>) =
  guesses |> Seq.map(toCsvRow) |> Seq.append(["f;f;f;d"]) |> String.concat("\n")

let saveCsv (guesses : seq<Guess>) : unit =
  let streamWriter = new System.IO.StreamWriter(__SOURCE_DIRECTORY__ + "/../output/" + fileName)
  guesses |> toCsv |> streamWriter.Write
  streamWriter.Close()



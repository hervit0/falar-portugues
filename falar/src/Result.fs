module Result

open FSharp.Data
open FalarType

let fileName =
  "test-" + System.DateTime.UtcNow.ToString("yyyyMMdd-HHmmss") + ".csv"

let toCsvRow guess =
  sprintf "%s;%s;%s;%s" guess.Portuguese guess.English guess.Answer guess.Correctness

let saveCsv (guesses : seq<Guess>) =
  let streamWriter = new System.IO.StreamWriter(__SOURCE_DIRECTORY__ + "/../output/" + fileName)
  guesses |> Seq.map(toCsvRow) |> Seq.append(["f;f;f;d"]) |> String.concat("\n") |> streamWriter.Write
  streamWriter.Close()



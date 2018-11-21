module Result

open FalarType

let convertCorrectness (correctness : bool) : string =
  match correctness with
  | true -> "-"
  | _ -> "X"

let updateGuesses (guesses : seq<Guess>) (world : World) (answer : string) (correctness : bool) : seq<Guess> =
  let guess =
    {
      Portuguese = world.Portuguese
      English = world.English
      Answer = answer
      Correctness = correctness |> convertCorrectness
    }

  Seq.append guesses [guess]



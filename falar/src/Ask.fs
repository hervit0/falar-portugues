module Ask

open FalarType

let init : Language =
    printfn "Select choice:"
    printfn "1. Translate from English to Portuguese (Default)"
    printfn "2. Translate from Portuguese to English"

    match System.Console.ReadLine() with
    | "1" -> Language.Portuguese
    | "2" -> Language.English
    | "3" -> Language.Both
    | _ -> Language.Portuguese

let display' (totalWorlds : int) (languageChoice : Language) (exercise : Exercise) (world : World) : Exercise =
    let worldTobeGuessed, correctAnswer =
      match languageChoice with
      | English -> (world.Portuguese, world.English)
      | _ -> (world.English, world.Portuguese)

    printfn "\n Progression: %i / %i" (totalWorlds - exercise.RemainingWorlds + 1) totalWorlds
    printfn "Give the translation for: %s" worldTobeGuessed
    let answer = System.Console.ReadLine()
    let correctness = answer = correctAnswer

    let result =
      match correctness with
      | true -> "\n=> Well done!"
      | _ -> sprintf "\n=> Nope, you meant: %s" correctAnswer
    printfn "%s" result

    let updatedGuesses = Result.updateGuesses exercise.Guesses world answer correctness

    match exercise.RemainingWorlds with
    | 1 -> ResultExporter.saveCsv updatedGuesses
    | _ -> ()

    { exercise with RemainingWorlds = exercise.RemainingWorlds - 1; Guesses = updatedGuesses }

let start (languageChoice : Language) (vocabularyData : seq<World>) : Exercise =
    printfn "\n Starting the exercise"
    let totalWorlds = Seq.length vocabularyData
    let display = display' totalWorlds languageChoice
    let initialExerciseState = { RemainingWorlds = totalWorlds; Guesses = Seq.empty }

    vocabularyData
    |> Seq.sortBy (fun _ -> System.Random().Next ())
    |> Seq.fold display initialExerciseState

module Ask

type Language =
  | Portuguese
  | English
  | Both

let init : Language =
    printfn "Select choice:"
    printfn "1. Translate from English to Portuguese (Default)"
    printfn "2. Translate from Portuguese to English"

    match System.Console.ReadLine() with
    | "1" -> Portuguese
    | "2" -> English
    | "3" -> Both
    | _ -> Portuguese

// let rec go =
//     let argument = System.Console.ReadLine()
//     printfn "%A" argument
//     go ()

let display' (totalWorlds : int) (languageChoice : Language) (index : int) (world : World.World) : unit =
    let worldTobeGuessed, correctAnswer =
      match languageChoice with
      | English -> (world.Portuguese, world.English)
      | _ -> (world.English, world.Portuguese)

    printfn "\n Progression: %i / %i" (index + 1) totalWorlds
    printfn "Give the translation for: %s" worldTobeGuessed
    let answer = System.Console.ReadLine()

    let result =
      match answer = correctAnswer with
      | true -> "Well done!"
      | _ -> sprintf "Nope, you meant: %s" correctAnswer
    printfn "%s" result

let start (languageChoice : Language) (vocabularyData : seq<World.World>) : unit =
    printfn "\n Starting the exercise"
    let totalWorlds = Seq.length vocabularyData
    let display = display' totalWorlds languageChoice

    vocabularyData
    |> Seq.sortBy (fun _ -> System.Random().Next ())
    |> Seq.iteri display

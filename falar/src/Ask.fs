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

let rec go =
    let argument = System.Console.ReadLine()
    printfn "%A" argument
    // go ()

let display' (totalWorlds : int) (index : int) (world : World.World) =
    printfn "Progression: %A" (index / totalWorlds)
    printfn "%A" world.Portuguese
    let answer = System.Console.ReadLine()
    printfn "%A" answer

let start languageChoice vocabularyData =
    printfn "Starting the exercise"
    // printfn "%A" vocabularyData
    let totalWorlds = Seq.length vocabularyData
    let display = display' totalWorlds

    vocabularyData
    |> Seq.iteri display

// let q = seq [{Portuguese = "um"; English = "one";}; {Portuguese = "dois"; English = "two";}]

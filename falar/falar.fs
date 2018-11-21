module Falar

[<EntryPoint>]
let main argv =
    ResultExporter.saveCsv
    let languageChoice = Ask.init
    printfn "Choosen:"
    printfn "%A" languageChoice
    // let argument = System.Console.ReadLine()

    let vocabularyData = VocabularyData.get

    Ask.start languageChoice vocabularyData
    // printfn "%A" argv
    0 // return an integer exit code

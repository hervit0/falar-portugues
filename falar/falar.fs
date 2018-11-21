module Falar

[<EntryPoint>]
let main _argv =
    let languageChoice = Ask.init
    printfn "\n Choosen: %A" languageChoice

    let vocabularyData = VocabularyData.get

    Ask.start languageChoice vocabularyData
    0 // return an integer exit code

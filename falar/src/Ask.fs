module Ask

let rec go () =
    VocabularyData.value ()

    let argument = System.Console.ReadLine()
    printfn "%A" argument
    go ()

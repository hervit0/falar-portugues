module Ask

let rec go () =
    let argument = System.Console.ReadLine()
    printfn "%A" argument
    go ()

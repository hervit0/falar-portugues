module Falar

[<EntryPoint>]
let main argv =
    printfn "Start typing!"
    Ask.go ()
    // printfn "%A" argv
    0 // return an integer exit code

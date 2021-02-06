// Learn more about F# at http://fsharp.org

open System

let add<'T> x y =
    printfn "%A" (x + y)

let generic_stuff() = 
    //add<float> 5.5 4.2
    //add<int> 2 3
    add<string> "x" "y"

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    generic_stuff()
    0 // return an integer exit code




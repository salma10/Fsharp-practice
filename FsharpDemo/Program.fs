// Learn more about F# at http://fsharp.org

open System

let list_stuff() = 
    let list1 = [1;2;3;4]

    list1 |> List.iter (printfn "Num : %i")

    printfn "%A" list1

    let list2 = 5::6::7::8::[]
    printfn "%A" list2

    let list3 = [1..5]
    let list4 = ['a'..'g']
    printfn "%A" list3
    printfn "%A" list4
   
[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    list_stuff()
    0 // return an integer exit code




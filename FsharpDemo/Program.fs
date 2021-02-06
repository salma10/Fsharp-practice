// Learn more about F# at http://fsharp.org

open System

let map_stuff() = 
    let customers = 
        Map.empty.
            Add("Bob", 100.23).
            Add("Bob2", 10.23)

    printfn "Customers %i" customers.Count

    let cust = customers.TryFind "Bob"
    match cust with
    | Some x -> printf "Balance : %.2f" x
    | None -> printfn "Not found"

    printfn "Customers : %A" customers

    printfn "Bobs balance : %.2f" customers.["Bob"]

    if customers.ContainsKey "Bob" then
        printfn "Bob found"
    
    let cust2 = Map.remove "Bob" customers

    printfn "Count : %i" cust2.Count

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    map_stuff()
    0 // return an integer exit code




// Learn more about F# at http://fsharp.org

open System

let tuple_stuff() = 
   let avg(x, y, z) : float = 
    let sum = x + y + z
    sum / 4.0
   
   printfn "Avg : %f" (avg (1.0, 2.0, 3.0))

   let my_data = ("derek", 42, 6.24)

   let (name, age, _) = my_data

   printfn "Name : %s" name
   
[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    tuple_stuff()
    0 // return an integer exit code




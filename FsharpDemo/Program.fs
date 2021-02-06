// Learn more about F# at http://fsharp.org

open System
type customer =
    { Name : string;
      Balance : float
    }
let record_stuff() = 
    let bob = { Name = "Bob naz"; Balance = 102.23}
    printfn "%s owes us %.2f" bob.Name bob.Balance
   
[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    record_stuff()
    0 // return an integer exit code




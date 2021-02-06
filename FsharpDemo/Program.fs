// Learn more about F# at http://fsharp.org

open System
type Animal = class
    val Name : string
    val Height : float
    val Weight : float

    new (name, height, weight) =
        {Name = name; Height = height; Weight =  weight}
    member x.Run =
        printfn "%s Runs" x.Name
end

type Dog (name, height, weight) = 
    inherit Animal(name, height, weight)
   
    member x.Bark =
        printfn "%s Barks" x.Name

let class_stuff() = 
    let spot = new Animal ("Spot", 9.0, 19.0)
    spot.Run
    let boer = new Dog ("Boer", 9.0, 19.0)
    boer.Run
    boer.Bark

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    class_stuff()
    0 // return an integer exit code




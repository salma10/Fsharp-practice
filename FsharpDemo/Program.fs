// Learn more about F# at http://fsharp.org

open System
type emotion = 
| joy =0
| fear = 1
| anger = 2
let option_stuff() = 
    let divide x y =
        match y with
        | 0 -> None
        | _ -> Some(x/y)

    if(divide 5 0).IsSome then
        printfn "5 / 0 = %A" ((divide 5 0).Value)
    elif (divide 5 0).IsNone then
        printfn "Cant divide by zero"
    else
        printfn "Something happened"
   
[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    option_stuff()
    0 // return an integer exit code




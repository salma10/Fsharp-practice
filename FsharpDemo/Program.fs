// Learn more about F# at http://fsharp.org

open System

let cond_stuff() = 
    let age = 8

    if age < 5 then
        printfn "Pre "
    elif age = 5 then
        printfn "Kn"
    elif (age > 5) && (age <= 18) then
        let grade = age - 5
        printfn "Go to dam %i" grade
    else
        printfn "Go to dam"
   
[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    cond_stuff()
    0 // return an integer exit code




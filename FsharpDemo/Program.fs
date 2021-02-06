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


    let grade : string = 
        match age with
        | age when age < 5 -> "Preschool"
        | 5 -> "Kin"
        | age when ((age > 5) && (age <= 18)) -> (age - 5).ToString()
        | _ -> "College"

    printfn "Grade : %s" grade
   
[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    cond_stuff()
    0 // return an integer exit code




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

    let list5 = List.init 5 (fun i -> i * 2)
    printfn "%A" list5

    let list6 = [for a in 1..5 do yield( a * a)]
    printfn "%A" list6

    let list7 = [for a in 1..5 do if a % 2 = 0 then yield a]
    printfn "%A" list7

    let list8 = [for a in 1..5 do yield! [a..a+2]]
    printfn "%A" list8

    printfn "Length : %i" list8.Length
    printfn "Empty : %b" list8.IsEmpty
    printfn "Index 2 : %i" (list8.Item(2))
    printfn "Head : %i" (list8.Head)
    printfn "Tail : %A" (list8.Tail)

    let list9 = list3 |> List.filter (fun i -> i % 2 = 0)
    let list10 = list9 |> List.map (fun i -> ( i * i ))
    printfn "list9 : %A" list9
    printfn "list10 : %A" list10
    printfn "Sort : %A" (List.sort ([5;4;3]))
    printfn "Sum : %i" (List.fold (fun sum elem -> sum + elem) 0 [1;2;3])

   
[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    list_stuff()
    0 // return an integer exit code




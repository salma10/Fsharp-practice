// Learn more about F# at http://fsharp.org

open System

let seq_stuff() = 
    let seq1 = seq { 1 .. 100 }
    let seq2 = seq { 0 .. 2 .. 100 }
    let seq3 = seq { 50 .. 1}

    printfn "%A" seq1
    printfn "%A" seq2
    printfn "%A" seq3

    Seq.toList seq2|> List.iter (printfn "Num : %i")

    let is_prime n =
        let rec check i =
            i > n/2 || (n % i <> 0 && check (i + 1))
        check 2

    let prime_seq = seq { for n in 1..500 do if is_prime n then yield n}
    printfn "%A" prime_seq
   
[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    seq_stuff()
    0 // return an integer exit code




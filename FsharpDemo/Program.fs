// Learn more about F# at http://fsharp.org

open System
type emotion = 
| joy =0
| fear = 1
| anger = 2
let enum_stuff() = 
  let my_feeling = emotion.joy

  match my_feeling with
  | joy -> printfn "Joy"
  | fear -> printfn "fear"
  | anger -> printfn "Angry"
   
[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    enum_stuff()
    0 // return an integer exit code




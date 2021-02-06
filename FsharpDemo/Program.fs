// Learn more about F# at http://fsharp.org

open System
type Rectangle = struct
    val Length : float
    val Width : float

    new (length, width) =
        {Length = length; Width = width}
end

let exp_stuff() = 
    let area( shape : Rectangle) =
        shape.Width * shape.Length

    let react = new Rectangle(5.0, 6.0)

    let rect_area = area react
    printfn "Area : %.2f" rect_area

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    exp_stuff()
    0 // return an integer exit code




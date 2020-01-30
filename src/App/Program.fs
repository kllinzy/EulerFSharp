open System
open Library
open Euler

[<EntryPoint>]
let main argv =
    // argv
    // |> Array.map Euler.
    // |> Array.iter (printfn "%s")

    //Euler.Problem1.answer
    //printfn "%s" Euler.Problem1.answer
    let p =  Euler.Problem3.findFactors (int64 argv.[0])
    p
    |>Array.iter(printfn "%i")
    0 // return an integer exit code
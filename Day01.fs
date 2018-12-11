module AdventOfCode2018.Day01

open System
open System.IO
open System.Collections.Generic

let input = Path.Combine(__SOURCE_DIRECTORY__, "Day01.txt") |> System.IO.File.ReadAllLines

let runPart2() =
    let set = HashSet()

    let result =
        Seq.initInfinite(fun i -> input |> Array.item (i % input.Length))
        |> Seq.map int
        |> Seq.scan (fun x acc -> acc + x) 0
        |> Seq.find(fun x -> not <| set.Add x)
    printfn "%i" Int64.MaxValue
    printfn "%i" result

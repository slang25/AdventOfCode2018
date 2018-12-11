module AdventOfCode2018.Day05

open System
open System.IO

let input = Path.Combine(__SOURCE_DIRECTORY__, "Day05.txt") |> System.IO.File.ReadAllText

let runPart1() =
    
    let flipCase c = match Char.IsUpper(c) with | true -> Char.ToLower(c) | false -> Char.ToUpper(c)
    
    let addChar (agg:char list) (c:char) =
        match agg with
        | head::tail when head = flipCase c -> tail
        | agg -> c::agg

    let result = input.ToCharArray() |> Array.fold addChar []
    
    printfn "%i" result.Length

let runPart2() =
    
    let flipCase c = match Char.IsUpper(c) with | true -> Char.ToLower(c) | false -> Char.ToUpper(c)
    
    let addChar filterChar (agg:char list) (c:char) =
        if (c = filterChar || c = flipCase filterChar) then agg else
        match agg with
        | head::tail when head = flipCase c -> tail
        | agg -> c::agg

    let tryWithFilter c =
        input.ToCharArray() |> Array.fold (addChar c) [] |> List.length 
    
    let min = [|'a'..'z'|] |> Array.map tryWithFilter |> Array.min
    
    printfn "%i" min
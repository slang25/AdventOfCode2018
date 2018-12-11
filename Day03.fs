module AdventOfCode2018.Day03

open System
open System.IO
open System.Collections.Generic
open System.Text.RegularExpressions

let input = Path.Combine(__SOURCE_DIRECTORY__, "Day03.txt") |> System.IO.File.ReadAllLines

type Claim = { id:int; left:int; top:int; width:int; height:int }

let runPart1() =
    
    let grid = Array2D.zeroCreate 1000 1000
    let parseRow (row:string) =
        let regex = Regex """^#(\d*) @ (\d*),(\d*): (\d*)x(\d*)$"""
        let result = regex.Match row
        let id = result.Groups.Item 1 |> fun x -> x.Value |> int
        let left = result.Groups.Item 2 |> fun x -> x.Value |> int
        let top = result.Groups.Item 3 |> fun x -> x.Value |> int
        let width = result.Groups.Item 4 |> fun x -> x.Value |> int
        let height = result.Groups.Item 5 |> fun x -> x.Value |> int
        { id=id; left=left; top=top; width=width; height=height }
    let parsedRows = input |> Array.map parseRow
    
    parsedRows |> Seq.iter (fun row ->
           for x in row.left .. (row.left + row.width-1) do
               for y in row.top .. (row.top + row.height-1) do
                   grid.[x,y] <- grid.[x,y] + 1
    )
    let mutable count = 0
    grid |> Array2D.iter (fun cell -> if cell > 1 then count <- count+1)
    printfn "%i" count

let runPart2() =
    
    let grid = Array2D.create 1000 1000 []
    let parseRow (row:string) =
        let regex = Regex """^#(\d*) @ (\d*),(\d*): (\d*)x(\d*)$"""
        let result = regex.Match row
        let id = result.Groups.Item 1 |> fun x -> x.Value |> int
        let left = result.Groups.Item 2 |> fun x -> x.Value |> int
        let top = result.Groups.Item 3 |> fun x -> x.Value |> int
        let width = result.Groups.Item 4 |> fun x -> x.Value |> int
        let height = result.Groups.Item 5 |> fun x -> x.Value |> int
        { id=id; left=left; top=top; width=width; height=height }
    let parsedRows = input |> Array.map parseRow
    
    let set = HashSet()
    parsedRows |> Seq.iter (fun row ->
           set.Add row.id |> ignore
           for x in row.left .. (row.left + row.width-1) do
               for y in row.top .. (row.top + row.height-1) do
                   grid.[x,y] <- row.id::grid.[x,y]
    )
    
    grid |> Array2D.iter (fun cell -> if cell.Length > 1 then cell |> List.iter (fun id -> set.Remove id |> ignore))
    printfn "%i" (set |> Seq.head)
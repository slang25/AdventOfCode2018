module AdventOfCode2018.Day02

open System
open System.IO

let input = Path.Combine(__SOURCE_DIRECTORY__, "Day02.txt") |> System.IO.File.ReadAllLines

let runPart1() =
    

    let charCounts =
        input
        |> Seq.map(fun x ->
               let grouped =
                   x.ToCharArray()
                   |> Array.countBy id
                   |> Array.map snd

               let contains2 =
                   if (grouped |> Array.contains 2) then 1
                   else 0

               let contains3 =
                   if (grouped |> Array.contains 3) then 1
                   else 0

               (contains2,contains3))

    let checksum =
        (charCounts
         |> Seq.map fst
         |> Seq.sum)
        * (charCounts
           |> Seq.map snd
           |> Seq.sum)

    printfn "%i" checksum

let runPart2() =
    let similarity (s1: string) (s2: string) =
        let zipped = Array.zip (s1.ToCharArray()) (s2.ToCharArray())
        zipped
        |> Seq.sumBy(fun x ->
               if (fst x) = (snd x) then 1
               else 0)

    let compare (previous: (string * int * string) list) value =
        let newEntry =
            match previous with
            | [] -> value,0,""
            | _ ->
                previous
                |> Seq.map
                       (fun (previousValue,_,_) ->
                       value,(similarity previousValue value),previousValue)
                |> Seq.maxBy(fun (_,x,_) -> x)
        newEntry :: previous

    let (s1,_,s2) =
        input
        |> Seq.fold compare []
        |> Seq.maxBy(fun (_,x,_) -> x)

    let result =
        Seq.map2 (fun c1 c2 ->
            if c1 = c2 then Some(c1)
            else None) (s1.ToCharArray()) (s2.ToCharArray())
        |> Seq.choose id
        |> Array.ofSeq
        |> String

    printfn "%s" result

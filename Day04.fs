module AdventOfCode2018.Day04

open System
open System.IO
open System.Collections.Generic
open System.Text.RegularExpressions

//let input = Path.Combine(__SOURCE_DIRECTORY__, "Day04.txt") |> System.IO.File.ReadAllLines

let input = """[1518-11-01 00:00] Guard #10 begins shift
[1518-11-01 00:05] falls asleep
[1518-11-01 00:25] wakes up
[1518-11-01 00:30] falls asleep
[1518-11-01 00:55] wakes up
[1518-11-01 23:58] Guard #99 begins shift
[1518-11-02 00:40] falls asleep
[1518-11-02 00:50] wakes up
[1518-11-03 00:05] Guard #10 begins shift
[1518-11-03 00:24] falls asleep
[1518-11-03 00:29] wakes up
[1518-11-04 00:02] Guard #99 begins shift
[1518-11-04 00:36] falls asleep
[1518-11-04 00:46] wakes up
[1518-11-05 00:03] Guard #99 begins shift
[1518-11-05 00:45] falls asleep
[1518-11-05 00:55] wakes up"""

type ElfAction =
    | BeginsShift of guardNum : int
    | FallsAsleep
    | WakesUp

let runPart1() =
    let input = input.Split "\n" |> Array.map (fun row ->
        let date = row.[1..16] |> DateTime.Parse
        let actionText = row.[19..]
        let elfAction = match actionText with
                        | "wakes up" -> WakesUp
                        | "falls asleep" -> FallsAsleep
                        | s when s.StartsWith("Guard") -> BeginsShift (s.[7..9] |> int)
                        | _ -> failwith "Unexpected input text"
        
        (date,elfAction)
    )
    
    let sorted = input |> Array.sortBy fst
    
    let folder (agg,currentGuard,currentWakeTime:DateTime,totalMinutes) row =
        let time,action = row
        match action with
        | BeginsShift guard -> (agg,guard,DateTime.MinValue,0)
        | WakesUp -> (agg,currentGuard,time,totalMinutes)
        | FallsAsleep ->
            let timeSlept = (time-currentWakeTime).TotalMinutes |> System.Math.Round |> int
            (agg,currentGuard,DateTime.MinValue,totalMinutes+timeSlept)
    
    let processed = sorted |> Array.fold folder ([], 0, DateTime.MinValue, 0)
    
    let map = Map.empty
    
    ()

let runPart2() =
    
    ()
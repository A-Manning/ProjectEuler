(*

A Manning


Learn more about F# at http://fsharp.net

I'm not so happy with this solution... Long runtime and not sufficiently general. 
3 minute runtime is kind of acceptable for the hardware I'm running, but could be better! 
Could be improved by using Seq.Unfold to generate an infinite sequence of triangle numbers. 
Really should have used List.distinct to eliminate square triangle numbers - 
List.distinct is not avaliable until F# 4.0 though, and thus the only solution is List.toSeq |> Seq.distinct
conversion to seq is an intensive process, and is highly inefficient
Efficiency could be improved using prime factorisation methods to find the number of factors rather than trial division. 

*)
#time
let triangle n = (n*(n+1L))/2L // rule for the triangle numbers, triangle n = n = (n*(n+1))/2
// assume an interval for the solution
let list = List.map triangle [3000L .. 60000L ]
let numberofFactors n = 
    let sqroot = int64 ((sqrt (double n))+1.0)
    let tempList = [1L..sqroot]
    let lowFactorsList = List.filter(fun x -> n%x = 0L) tempList
    let highFactorsList = List.map(fun x -> n/x) lowFactorsList
    List.append lowFactorsList highFactorsList
         |> List.length 

let numFactList = List.map numberofFactors list
let ind = List.findIndex (fun x -> x >= 500) numFactList
let ans = List.nth list ind
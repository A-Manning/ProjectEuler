(*

A Manning

Learn more about F# at http://fsharp.net

This solution is really easy in F#, and really efficient too. 

*)

let square x = x*x
let listTo x = [1..x]
let squares l= l |> List.map square
let sumOfSquares x = listTo x |> squares |> List.sum
let squareOfSum x = listTo x |> List.sum |> square
let answer x = squareOfSum x - sumOfSquares x

answer 100
(*

A Manning

Learn more about F# at http://fsharp.net

Fast, clean, only 3 lines. Great success. 
The problem is stored in a text file called problem13.txt. 

*)
open System.IO
open System.Numerics

//ls is a sequence of lines of the file
let ls = seq { yield! File.ReadLines(@"C:\Users\A Manning\Documents\Work\Project Euler\Problem 13\problem13.txt") }
let map x = BigInteger.Parse(ls |> Seq.nth (x-1)) // map x gives the xth line of the file as a BigInteger
let ans = List.map map [1..100] |> List.sum // Sums the numbers , gives the answer


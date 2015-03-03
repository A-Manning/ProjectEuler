(*

A Manning

Only two lines of code...really shows the power of F#. 

*)
open System.Numerics
let s = string (BigInteger.Pow((BigInteger 2),1000)) // s is the string value of 2^1000
s.ToCharArray() |> Array.map(fun x -> (int x)-(48)) |> Array.sum // makes s a char array, changes char vals to integers, sums them
(*

A Manning

Learn more about F# at http://fsharp.net

Again, the algorithm here is very different from the Java implementation. 
In F#, creating a list of fibonacci numbers is easy. 
It is also easy to filter for even numbers.
It is also easy to sum them.
Whilst not as fast as my Java solution, This is nevertheless a useful coding excercise. 
The answer will be printed in the interactive output or REPL when this code is run. 
*)

let n = 4000000//Initialise n
//Generate the fibonacci sequence, with one element greater than n
let fib = Seq.unfold (fun state ->
    if (snd state > n) then None
    else Some(fst state + snd state, (snd state, fst state + snd state))) (1,1)
let fibToN = fib |> Seq.take ((fib |> Seq.length)-1) //fibToN is the fib. sequence with no elements greater than n
let isEven x = x%2 = 0 //boolean function that returns true if x is even
let evenFib = fibToN |> Seq.toList |> List.filter isEven //evenFib is the even fib.s under n
let sum = evenFib |> List.sum //sum is the sum over evenFib
printf "%d" sum
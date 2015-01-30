(*

A Manning

Learn more about F# at http://fsharp.net

This program runs in reasonable time. Project Euler solutions should run in under 1 minute. This /should/ too. 
This program doesn't because I am using old hardware, and have very little RAM
This program also suffers from the inefficiency of evaluating Seq elements
This should be fixed in F# 4.0, where I will be able to use a List instead. 

The #time gives a performance readout in the REPL or F# interactive. 
I got the following; 
Real: 00:01:45.521, CPU: 00:01:43.859

Evidently, with the right hardware , this should run in the correct time. 
I am aware that the Sieve of Eristothenes is not the most efficient possible solution.
The Sieve of Atkins is a major improvement but would take a longer time to implement.
Possibly a long time to understand too!

This method is, however, orders of magnitude faster than simply generating the primes by test division. 

*)
#time // gives a performance readout in REPL or F# interactive
let divides x y = x% y <>  0L || x= y // returns true if x is not divisible by y, or x is equal y. 
let s = {2L..2000000L}//list of numbers 2 to 2,000,000

//The Sieve of Eristothenes
let primegen seq = //filters a sorted sequence for coprime elements. because we have a full sequence, this will return primes. 
    let rec filter seq index = //recursive method to filter a sequence
        let div = seq  |> Seq.nth index //takes a number as a divisor
        let seq2 = seq |> Seq.filter (fun elem -> divides elem div)//removes all elements divisible by the divisor
        if  div <= 1414L // if the divisor is greater than sqrt 2,000,000, we are done. 
            then filter seq2 (index + 1)//filters the list with the next prime divisor
        else seq2
    filter seq 0 //filters the sequence, starting at the first element

s |> primegen |> Seq.sum //generates the answer

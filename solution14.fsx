(*

A Manning

This runs in just over a second, and is very simple and readable. A good problem overall. 

*)

#time
let seqLength n = // Finds the length of a Collatz sequence for some n
    let rec seq x (l:int64) = 
            if x = 1L
                then (l + 1L)
            elif x%2L = 0L
                then seq (x/2L) (l+1L)
            else 
                seq ((3L*x)+1L) (l+1L)
    seq n 0L
// Inefficient to test low L, but minimally increases time. Improves simplicity though. 
let list2 = List.map seqLength [1L..1000000L] // list2 is now a list of the sequence lengths for each index
let max = list2 |> List.max  // finds the largest sequence
let ans = List.findIndex (fun x -> x = max) list2 // finds the index of the largest sequence, which is the answer

(*

A Manning

Learn more about F# at http://fsharp.net

This problem was easily solved after doing a little algebraic manipulation on it. Interestingly enough, It suffices to only generate listB1! 
However I did not prove that this /must/ be the case, so I have solved the problem generally anyway. 

Efficiency is not a concern here - The algorithm is very fast. 

All in all, a great problem!

*)

let listB0 = [1..500]//Candidate values of B
// let listC0 = [1..998]//Candidate Values of C // This line of code was unnecessary in the end.
// I was able to prove that C must be an integer and C^2 must be a composite of some integer squares A^2 and B^2;
// Thus , evaluating candidate values of C was unnecessary.
let square x = x*x
// I did some maths and found that A = 1000((b-500)/(b-1000)); 
// A is an integer, so we can find only the values of A that satisfy this for some B
// Note also that C>B and C>A is implicit so we need only check that B>A
let isBCandidate (x:int) = // Checks for values of B that satisfy this condition
    let dub : double = double x
    let q = dub * 1000.0
    let r = q - 500000.0
    let s = dub - 1000.0
    if ((r/s)%1.0) = 0.0 && (r/s) <> 0.0 && (r/s) < dub //A cannot be zero since then B^2 = C^2 so B=C but B<C so this is absurd. 
        then true 
    else false
let listB1 = List.filter isBCandidate listB0
//will generate A candidates from a B candidate
let generateACandidate (x:int) =
    (1000*x - 500000)/(x-1000)

(*

The following code would check that A^2 + B^2 = C^2 for an integer C, and pair A and B; 
This is actually unnecessary, as my calculation previously forces C to be an integer and A^2+B^2 to be equal to some integer squared
I have thus left this code as a comment. One can freely verify that and A candidate and B candidate from listB1 satisfy this. 

let listC1 = List.map square listC0 //C^2 candidates

let contains x = List.exists ((=)x) //checks if a list contains x
let isA2B2C2 x = //checks if there is some C^2 candidate such that A^2 + B^2 = C^2 for some pair A and B
    let C2 = (square x + square (generateACandidate x) )
    listC1 |> contains C2

let listB2 = List.filter isA2B2C2 listB1
*)

let isAnswer B = //Checks if an answer B, and it's paired A and C, satisfy the conditions of the problem
    let A = generateACandidate B
    let C2 = (square B + square(A)) //A^2 + B^2 = C^2 
    let C :int  = int (sqrt (double C2))
    printfn("%d") C
    if ((A+B+C) = 1000)
        then true
    else false

let b = List.head (List.filter isAnswer listB1) //finds b (This relies on the statement in the problem that there is only one such number b)
let a = generateACandidate b //finds a
let c = 1000 - (a+b) //finds c

let answer = a*b*c 


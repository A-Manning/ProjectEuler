(*

A Manning

Learn more about F# at http://fsharp.net

This was the first time I've solved a problem in F# before Java.
The efficiency of this program suffers from recursion, and the Sieve of Eristophanes as a prime generator. 
This program is highly impractical for large n , though for the question runtime is very fast ( < 1 second)

*)
let makelist x = [2..(x)]
let divides x y = x%y = 0
let rec sieve = function // Sieve of Eristophanes
    | (p::xs) -> p :: sieve [ for x in xs do if x % p > 0 then yield x ]
    | []      -> []
let primes x = sieve [2..x]

// returns the least prime factor of a number
let firstprime x = 
    let prime = primes x
    let isprime number = List.exists (fun elem -> elem = number) prime
    makelist x |> List.filter(divides x) |> List.filter isprime |> List.head

// returns the prime factors of a number x
let primefacts x = 
    let prime = primes x
    let isprime number = List.exists (fun elem -> elem = number) prime
    let primediv a b = a/b = 1 
    let rec facts x = 
        let a = firstprime x
        let alist = [a]
        let modlist = [(x/a)]
        if (primediv x a = true)
           then alist
        elif (isprime (x/a) = true) 
           then List.append alist modlist
        else List.append alist (facts (x/a))
    facts x

//now that we can find the prime factorisation of a number, we must find a way to compare the prime factorisations
let rec remove n lst =  // removes n from a list, only once
    match lst with
    | h::tl when h = n -> tl
    | h::tl -> h :: (remove n tl)
    | []    -> []

let compare a b = //compares prime factorisations, returns a combination of them eg (2,2,3,4) + (2,3,3,4) -> (2,2,3,3,4)
    let rec comp a b =
        let isin n = List.exists (fun elem -> elem = n) b
        let ahead = List.head a 
        let atail = List.tail a
        let Lahead = [ahead]
        if  isin (ahead) = true && List.length a <> 1 
            then (List.append Lahead (comp atail (remove ahead b))) |> List.sort
        elif isin (ahead) = true && List.length a = 1
            then b
        elif List.length a <> 1 
            then (List.append Lahead (comp atail b)) |> List.sort
        else List.append Lahead b |> List.sort
    comp a b

//returns the prime factorisation of the answer
let getanswerlist n = 
    let rec get n = 
        if n = 2
            then [2]
        else compare (primefacts n) (get (n-1))
    get n

//multiplies all of the elements of a list together
let listmult l= 
    let rec mult l= 
        if List.length l <> 1
            then (List.head l) * mult (List.tail l)
        else List.head l
    mult l

let answer x = getanswerlist x |> listmult //computes the answer

answer 20

            
//Tail Recursion is Fast! This took 0.093 secs. 
open System.Numerics
let fibNDigits N = 
    let rec find (m:BigInteger) (x:BigInteger) (i:int) = 
        if x.ToString().Length = N
            then i
        else find x (m+x) (i+1)
    find (bigint 1) (bigint 1) 2

fibNDigits 1000
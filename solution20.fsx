open System.Numerics
let rec factorial (x:BigInteger) = 
        if (x = bigint 2)
            then x
        else x * (factorial (x- bigint 1))

let fact100 = factorial (bigint 100)
fact100.ToString().ToCharArray() 
|> Array.map(fun x -> (int(x) - 48))     
|> Array.sum                                                                                                                                                                                                                                                     
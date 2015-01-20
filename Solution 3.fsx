(*

A Manning


This solution technically works, and is superior in runtime to my first Java attempt. The memory usage is, however, huge. 
This is because recursion is ineficcient, I'm running it in an interactive console, and I have very little RAM.
Nevertheless, the program works and is a nice example of functional programming. 25 Lines is not bad at all. 
This excercise also taught me a lot about type casting, recursion, and boolean logic in F#. 
It is also the first time I have intentionally attempted a functional approach to a problem. 
My improved java solution is also possible in F# but I felt that a functional approach would be more interesting. 
Others have solved the problem differently but their programs are incorrect and fail for the case of n=15. 
There are other numbers that will cause this error as well. 
It is mere coincidence that a square root test yields the correct answer. 


*)

let makeList x  = [2L..(x-1L)]
let divides x y = x%y = 0L
let isprime n =
    let rec check i =
        i > n/2L || (n % i <> 0L && check (i + 1L))
    check 2L
let findFirstPrimeFactor x = 
    let rec find y list = 
        if divides y (list |> List.head) &&  list |> List.head |> isprime 
            then List.head(list)
        elif list |> List.length = 1 then 1L
        else find y (list |> List.tail)
    find x (makeList x)

let findLargestPrime x n = 
    let rec findPrime x n = 
        if findFirstPrimeFactor x = 1L && x <> n
            then x
        elif findFirstPrimeFactor x = 1L && x = n
            then 1L
        else findPrime (x / (findFirstPrimeFactor x)) n
    findPrime x n

let n = 600851475143L
printfn("%d") (findFirstPrimeFactor n)
findLargestPrime n n
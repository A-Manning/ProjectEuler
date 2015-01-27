(*

A Manning

Learn more about F# at http://fsharp.net

This is relatively efficient. Runtime is less than a second, Just slightly slower than Java because of the recursion. 
Much clearer than Java. I'm rather happy with this solution. 

Run this in F# Interactive or a REPL!

*)


let prepal = [101..799] // assumes that the answer is six digits and generates all candidates for palindromes
let palindromise x = //takes a 3 digit number, returns a 6 digit palindrome eg 123 -> 321123
    let a = x + ((x%10)*100000)
    let b = a + (((x%100)-(x%10))*(1000))
    let c = b + (((x%1000)-(x%100))*(10))
    c
let is6Digit x =  x > 100000 && x <999999// Eliminates numbers like 001100    
// List of 6 digit palindromes , sorted high to low to improve efficiency
let pal = prepal |> List.map palindromise |> List.filter is6Digit |> List.sortBy (fun x -> -x) 
//checks if x is a multiple of two three digit numbers
let isDiv x = Seq.exists (fun i -> x%i = 0 && x/i > 100 && x/i < 999 ) [101..999] 
// finds the first number that is a multiple of two three digit numbers in a list
let findfirst list = 
    let rec first list = 
        if List.head list |> isDiv = true 
            then List.head list
        else first (List.tail list)
    first list
//finds the answer
findfirst pal 
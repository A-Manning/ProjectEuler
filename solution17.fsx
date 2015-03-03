(*

A Manning

This problem is greatly simplified with pattern matching

*)

let matchToWord (x:int) = // gives a pattern match for numbers to strings
    match x with
    | 0 -> ""      | 1 -> "one"  | 2 -> "two" | 3 -> "three"
    | 4 -> "four"  | 5 -> "five" | 6 -> "six" | 7 -> "seven"
    | 8 -> "eight" | 9 -> "nine"
    | 10 -> "ten"       | 11 -> "eleven" | 12 -> "twelve" | 13 -> "thirteen"
    | 14 -> "fourteen"  | 15 -> "fifteen"   | 16 -> "sixteen" | 17 -> "seventeen"
    | 18 -> "eighteen"  | 19 -> "nineteen"
    | 20 -> "twenty"    | 30 -> "thirty"  | 40 -> "forty"  | 50 -> "fifty" 
    | 60 -> "sixty"     | 70 -> "seventy" | 80 -> "eighty" | 90 -> "ninety"
    | _ -> ""

let rec matchToWord2 x = //gets the string representation of a number
    if x < 21 //if x is explicitly matched
        then matchToWord x
    elif x <100 // if x is some (n)ty-(m) eg (twen)ty(four)
        then matchToWord (x-x%10) + matchToWord (x%10)
    elif x < 1000 && (x%100) <> 0 //if x is of the form "n hundred and m"
        then matchToWord ((x-x%100)/100) + "hundredand" + matchToWord2 (x%100)
    elif x < 1000 //if x is of the form "n hundred"
        then matchToWord (x/100) + "hundred"
    elif x = 1000
        then "onethousand"
    else ""
 
let answer = List.map matchToWord2 [1..1000] |> List.map String.length |> List.sum
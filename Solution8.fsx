(*

A Manning

Learn more about F# at http://fsharp.net

Reasonably efficiency. Solved at the same time as Java, since the solutions are so similar.
This is, however, purely functional. My Java solution is not. 

In F# 3.0, Lists, Arrays, and Sequences do not have all of the take, rev, toChar methods. 
Until F# 4.0 comes out, we must use a sequence, and perform awkward conversions. 

This is more or less the same as my java solution, but longer/uglier because of all the type conversion. 
On the bright side, taking a string input looks much better!
F# 4.0, to be included in Visual Studio 2015, will fix this. 


*)

// Store the problem as a string
let s =  "73167176531330624919225119674426574742355349194934"+
         "96983520312774506326239578318016984801869478851843"+
         "85861560789112949495459501737958331952853208805511"+
         "12540698747158523863050715693290963295227443043557"+
         "66896648950445244523161731856403098711121722383113"+
         "62229893423380308135336276614282806444486645238749"+
         "30358907296290491560440772390713810515859307960866"+
         "70172427121883998797908792274921901699720888093776"+
         "65727333001053367881220235421809751254540594752243"+
         "52584907711670556013604839586446706324415722155397"+
         "53697817977846174064955149290862569321978468622482"+
         "83972241375657056057490261407972968652414535100474"+
         "82166370484403199890008895243450658541227588666881"+
         "16427171479924442928230863465674813919123162824586"+
         "17866458359124566529476545682848912883142607690042"+
         "24219022671055626321111109370544217506941658960408"+
         "07198403850962455444362981230987879927244284909188"+
         "84580156166097919133875499200524063689912560717606"+
         "05886116467109405077541002256983155200055935729725"+
         "71636269561882670428252483600823257530420752963450"

let charToInt (x:char) =  //converts a character to an int64
    let i : int64 = int64 x 
    i - 48L

let multThirteen seq= //takes the first 13 elements of a sequence
    seq |> Seq.take 13
    


let rec multList list =  //multiplies all of the elements in a list
        if List.length list = 1
            then List.head list
        else List.head list * multList (List.tail list)

let arblist = [1..988]//a list of numbers 1-988 (because there are 988 possible sequence products)

// Takes the first n+12 values of a sequence, and reverses them.
// If this is used as input to multThirteen and then multList, we have an enumerated sequence product. 
let maptomult13 (n:int) seq = 
    seq |> Seq.take (n+12) |> Seq.toList |> List.rev |> List.toSeq 

// gives the xth sequence product
let compute13 (x:int) = maptomult13 x s |> multThirteen |> Seq.toList |> List.map charToInt |>  multList 

let answer s = //gives the largest sequence product for a sequence input
    let ansList =  arblist |> List.map compute13
    List.max ansList

// Makes s into a character array, then turns it into a character sequence. Then computes thee answer.
answer (s.ToCharArray() |> Array.toSeq)
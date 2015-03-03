(*

A Manning

Arrays are mutable in F# by default, and I took full advantage of this. This code could easily be remade without it. 
According to the #time command, this code runs in 00:00:00.000. Can't beat that! 
As an aside, I originally tried to answer this with a pure recursive method, but the runtime was O(n^2) where n is the size of the array
This code, however, is MUCH faster, running so fast the #time command can't log it. 

*)

#time
// initialises array of 21 zeroes. 
//these will represent every corner in the grid, with the number being the number of paths to get to [0,0]
//my grid is oriented differently. I start at the bottom right corner and end up at the top left. 
let emptyArray2D = Array2D.create 21 21 0L
let init1 x = emptyArray2D.[0,(x-1)] <- 1L //evidently if we are on the top row, we can only move left, so there is one path for these corners 
let init2 x = emptyArray2D.[(x-1),0] <- 1L //similarly, we can only move up if we are on the left edge, so there is only one path
for i in 1..21 do // updates the array to reflect this condition
    init1 i
    init2 i
emptyArray2D.[0,0] <- 0L // except if we are at [0,0]! then we are done, so there are no paths to [0,0]
let arr2D = emptyArray2D // our array is now initialised and not empty so we might as well update the name

// the number of paths from any point (x,y) is the number of paths from the corner above plus the number from the corner to the left
let generate x y = 
    arr2D.[(x-1),(y-1)] <- arr2D.[(x-2),(y-1)] + arr2D.[(x-1),(y-2)]

let generateRC n = //generates row and column n 
    for i in 2..(n-1) do // to generate [n,n] we must already have both [n,n-1] and [n-1,n] so we do not generate this in the loop
        generate n i
        generate i n 
    generate n n 

let generateFinalArr = //generates the final array
    for i in 2..21 do
        generateRC i 

let answer = arr2D.[20,20] // the answer is the number of paths from the bottom right corner. 


open System.IO
let ls = seq { yield! File.ReadLines(@"C:\Users\Ashley\Documents\Work\Project Euler\Problem 18\problem18.txt")}

let map (array: char array) i = 
    let x = int array.[(2*(i-1))]
    let y = int array.[((2*i)-1)]
    ((x-48)*10) + (y-48)
let map2 (array: char array) = 
    let x = ((Array.length array)) 
    let y = x/2
    Array.map (map array) [|1..y|] 
let method1 (s:string) = s.ToCharArray() |> Array.filter(fun x -> string (x) <> " ")
let ls2 = Seq.map method1 ls //ls2 is now a sequence of character arrays without spaces
let ls3 = Seq.map map2 ls2  // ls3 is now a sequence of integer arrays. 
let toConstDim (array: int array) = 
    let l = Array.length array
    let d = Seq.last ls3 |> Array.length
    let newArrOfZeros = Array.zeroCreate (d - l)
    Array.append array newArrOfZeros
let ls4 = Seq.map toConstDim ls3
let arr2D = Seq.toArray ls4
let init x y =
               if y <> 14 
                  then 
                    let temp1 = arr2D.[x+1].[y]
                    let temp2 = arr2D.[x+1].[y+1]
                    let max = List.max [temp1;temp2]
                    (arr2D.[x].[y] + max)
               else 
                  arr2D.[x].[y] + arr2D.[x+1].[y]
let initline x = 
    for i in 0..14 do
    arr2D.[x].[i] <- init x i

let initArr =
    for i in 0..13 do
    initline(13 - i)

let answer = arr2D.[0].[0]
    

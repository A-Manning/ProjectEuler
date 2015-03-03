open System.IO
let replaceCommasWithLineBreaks (x:char) =  //Replaces commas with line breaks
    match x with 
    |',' -> '\n'
    |_ -> x

let data = File.ReadAllText("C:\\Users\\Ashley\\Documents\\Work\\Project Euler\\Problem 22\\names.txt") // opens the text file
let newdata = data.ToCharArray() |> Array.map replaceCommasWithLineBreaks |> System.String.Concat // newdata now contains one name per line
File.WriteAllText("C:\\Users\\Ashley\\Documents\\Work\\Project Euler\\Problem 22\\newnames.txt" , newdata)// creates the newdata file
let dataseq = seq{ yield! File.ReadLines("C:\\Users\\Ashley\\Documents\\Work\\Project Euler\\Problem 22\\newnames.txt")}//read newdata
let removequotes (x:string) = x.ToCharArray() |> Array.filter(fun x -> int(x) > 64 && int(x) < 91) |> System.String.Concat
let nameSequence = Seq.map removequotes dataseq |> Seq.sort //nameSequence is now an indexed sequence of names without quotation marks

let getNumericalValue (x:string) = x.ToCharArray() |> Array.map(fun x -> (int (x) - 64)) |> Array.sum // gets the numerical value of a string
let namevals = Seq.map getNumericalValue nameSequence 
Seq.map(fun x -> x* (namevals |> Seq.nth (x-1))) [1..(namevals |> Seq.length)] |> Seq.sum

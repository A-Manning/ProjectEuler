// Learn more about F# at http://fsharp.net
// This code will print the sum of all multiples of 3 and 5 up to a user-specified number. 
// The intention of this code was to solve Project Euler problem 1. Enter 1000 as the input for the solution.
// This must run in the console! 
[<EntryPoint>]
let main argv = 
    System.Console.WriteLine("Enter input")
    let v  = System.Console.ReadLine() |> System.Int32.Parse 
    //v is the user-specified number, or 1000 in the problem. 
    //v must be of type int, so the input, a string, is piped to Int32.Parse, which turns the string into an int
    let trip x = 3 * x // trip will multiply a number by 3
    let quint x = 5 * x // quint will multiply a number by 5
    let threelist = List.map trip [1..((v-1)/3)] //creates a list of every multiple of v up to three
    let quintlist = List.map quint [1..((v-1)/5)] //creates a list of every multiple of v up to five
    let union left right = List.append left right |> Seq.distinct |> List.ofSeq
    //This function takes two lists, and appends one after the other.
    //It then removes duplicate elements. 
    //List.ofSeq is used because Seq.distinct outputs a sequence and we want a list. 
    //Our final output is the union of the two lists. 
    let multilist = union threelist quintlist   
    let sum = List.sum multilist // takes the sum of all of the elements of multilist
    System.Console.Write("The sum is ")
    System.Console.WriteLine(sum)
    System.Console.WriteLine("Press any key to exit")
    System.Console.ReadKey() |> ignore //keeps console open until key pressed, then ignores input and goes to next line
    0 // return an integer exit code


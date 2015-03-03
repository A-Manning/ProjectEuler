let getFracLength n = 
    let rec longdiv x y list = 
        let r = (10*x)%y
        if list |> List.exists(fun z -> z = r)
            then list.Length 
        else longdiv r y (list |> List.append [r])
    longdiv 1 n []

let l = List.map getFracLength [1..1000] 
let max = l |> List.max
let ans = l |> List.findIndex(fun x-> x= max)
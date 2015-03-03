let factors x = [1..(x-1)] |> List.filter(fun y-> x%y = 0)  |> List.sum
let isabundant x = ((factors  x) > x)
let abs = List.filter(fun x -> isabundant x) [1..28124]
let isSum x = List.map(fun y -> x-y) abs |> List.exists(fun z -> (abs |> List.exists(fun a -> a = z)))

List.filter(fun x -> isSum x = false) [1..28125] |> List.sum
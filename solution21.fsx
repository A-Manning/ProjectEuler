let divisorsum a = List.filter(fun x -> a%x = 0 )[1..(a-1)] |> List.sum
divisorsum 220
let isamicable a = 
    let tmp1 = divisorsum a
    let tmp2 = divisorsum (tmp1)
    a = tmp2 && a <> tmp1

List.filter(fun x -> isamicable x) [1..10000] |> List.sum
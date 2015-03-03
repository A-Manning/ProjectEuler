let findIndex (x:int array) = 
    let rec checkNext ind = 
        if x.[ind-1] < x.[ind]
            then ind
        else checkNext (ind-1)
    checkNext 9

let Next (x:int array)  = 
    let pivot = (findIndex x) - 1
    let rec next ind= 
        if x.[ind] > x.[pivot]
           then ind
        else next (ind-1)
    let tmp1 = next 9
    let tmp2 = x.[tmp1]
    do x.[tmp1] <- x.[pivot]
    do x.[pivot] <- tmp2
    Array.append ( Array.sub x 0 (pivot+1)) ( Array.sub x (pivot+1) (9-pivot) |> Array.rev)
    



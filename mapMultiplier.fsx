let list = [1; 2; 3; 4; 5; 6]

let mutable factor = 2

let multiplier e = e * factor

printfn "%s" ((List.map (fun e -> e * factor) list).ToString()) //[2; 4; 6; ... ]

printfn "%s" ((List.map multiplier (*e * factor*) list).ToString()) //using the multiplier instead of the map
//[2; 4; 6; ... ]

factor <- 3
printfn "%s" ((List.map multiplier list).ToString()) //[3; 6; 9; ...]
//multiply list by 3

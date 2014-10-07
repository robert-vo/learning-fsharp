let totalValues list = 
    let total = ref 0
    list |> List.iter(fun e -> total := !total + e) //:= referring to a heap, ! is dereference
    !total 
   
let list = [1; 2; 3; 4; 5; 6]

let total = list |> totalValues
printfn "Total is %d" total
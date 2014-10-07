let list = [1; 2; 3; 4; 5; 6]

//Way 1, using 3 methods to print total values of all, even, and odd values.
let totalValues list = list |> List.sum

let totalEvenValues list = 
    list |> List.filter (fun e -> e % 2 = 0)
         |> List.sum

let totalOddValues list =
    list |> List.filter (fun e -> e % 2 <> 0)
         |> List.sum

list |> totalValues 
     |> printfn "Total is %d" //Total is 21"

list |> totalEvenValues
     |> printfn "Total of even values is %d" //Total of even values is 12

list |> totalOddValues
     |> printfn "Total of odd values is %d" //Total of odd values is 9
     
//Way 2, using one function to print total of all,even, and odd values.
let totalSelectedValues selector list = 
    list |> List.filter(fun e -> selector(e))
         |> List.sum
         
list |> totalSelectedValues (fun e -> true) 
     |> printfn "Total of all values %d" //Total of all values is 9

list |> totalSelectedValues (fun e -> e% 2 = 0) 
     |> printfn "Total of even values is %d" 

list |> totalSelectedValues (fun e -> e% 2 <> 0) 
     |> printfn "Total of odd values is %d" 
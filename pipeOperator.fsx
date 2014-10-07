//forward pipe operator (double only event values)

//without pipe operator
let list = [1; 2; 3; 4; 5; 6]

printfn "%s" (list.ToString()) //[1; 2; 3; ... ]

let evenValues = List.filter(fun e -> e % 2 = 0) list

printfn "%s" (evenValues.ToString()) //[2; 4; 6]
//filter is like a map, but it filters elements out of a list that does not meet the criteria 

let doubledEvenValues = List.map (fun e -> e * 2) evenValues
printfn "%s" (doubledEvenValues.ToString()) //[4; 8; 12]

//chaining the evenvalues + doubledevenvalues function using the pipe operator  
let giveString obj = obj.ToString()

list 
     |> List.filter(fun e -> e % 2 = 0)
     |> List.map(fun e -> e * 2)
     |> giveString
     |> printfn "%s"//[4; 8; 12]
//similar to "." in java
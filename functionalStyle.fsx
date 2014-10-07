//functional style of programming

//method to print all of the elements in the list
let printList list = (* you can add ": int list" to specify that is it 
                returning a list, but it isn't necessary. *) 
    List.iter(fun e -> printf "%d" e) list
    printfn ""
(* List.iter gives you an iteration
 *foreach in scala, each in groovy/ruby
 *'fun e' is our parameter name
 *List.iter takes an anonymous function
 *)

//create a list
let list = [1; 2; 3; 4; 5; 6]
printList list

printf "The original list is " //The original list is 123456
printList list

printf "The doubled list is "
printList (List.map(fun e -> e * 2) list)  //The doubled list is 24681012
//map is like the collect method in ruby
//map takes each variable in the collection, perform an operation, and return the list 

printf "The total is "//The total is 
printfn "%d" (List.reduce(fun carryOver e ->
    carryOver + e) list) //21
//reduce is similar to foldleft in scala
//reduce takes an anonymous function, carryover is the value returned

printfn "The max of values in the list if %d" (
    List.fold(fun max e -> 
        if max < e then e else max
        ) System.Int32.MinValue list
 )
 //fold takes an anonymous function
 //fold left function with three parameters
 //the method, System.Int32.MinValue (initial value), list (to work with)


//built in functions
printfn "The total is %d" (List.sum list) //The total is 21
printfn "The max is %d" (List.max list) //The max is 6
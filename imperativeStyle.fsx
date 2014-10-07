//imperative style of programming

//method to print all of the elements in the list
let printList list = 
    for e in list do //traditional for loop
        printf "%d" e
    printfn ""
    
//create a list
let list = [1; 2; 3; 4; 5; 6]

printf "The original list is " //The original list is 123456
printList list

//doubling each value in the list using imperative style 
let mutable doubledList = []
for e in list do 
    doubledList <- doubledList @ [e * 2] //@ is used to concatenate the elements to the list
    
printf "The doubled list is "
printList doubledList //The doubled list is 24681012

//totaling the list
let mutable total = 0
for e in list do
    total <- total + e //similar to for each loop in c#
    
printfn "The total is %d" total //The total is 21

//finding the maximum of the list
let mutable max = System.Int32.MinValue //minimum value -2,147,483,648
for e in list do 
    if max < e then max <- e

printfn "The max of values in the list is %d" max //The max of values in the list is 6

let max = 100 //immutable 

printfn "The max is %s" ((max = 1).ToString())
//The max is False
//you are comparing max to 1, not assigning max to 1

let mutable total = 0
printfn "The total is %d" total
//The total is 0

total <- 2
printfn "The total is %d" total //The total is 2
//equal sign is comparing the value
//assignment of the value uses the <- "arrow" symbol
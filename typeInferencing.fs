let add a b = a + b
printfn "%d" (add 2 6)
//f# infers that the add function is an int.

let printSomeThing something = printfn "%s" something
printSomeThing "Hello f#!"
//printSomeThing -> string

let printSomeThingElse something = printfn "%g" something
printSomeThingElse 1.0
//printSomeThingElse -> float

let printSomeOtherThing something = printfn "%s" (something.ToString())
printSomeOtherThing 2       
printSomeOtherThing 1.0
printSomeOtherThing true
//printSomeOtherThing -> generic types to string
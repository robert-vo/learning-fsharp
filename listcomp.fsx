//list comprehension
let isPrime number =
    if [2..number - 1] |> List.exists (fun e -> number % e = 0) then false else true //returns a boolean
    //exists would be better to use so it won't iterate the entire list every time.
    //exists exits once it finds a 'true' it.
    
printfn "%b" (isPrime 3) //true
printfn "%b" (isPrime 4) //false

printfn "Primes between 1 and 25 are: "
//Primes between 1 and 25 are:
[for e in 2..25 do
    if isPrime e then yield e] 
    |> List.iter(printf "%d, ")
 //2, 3, 5, 7, 11, 13, 17, 19, 23, 

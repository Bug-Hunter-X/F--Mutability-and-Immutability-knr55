let mutable x = 10
let mutable y = 20

let add x y = x + y

let result = add x y
printfn "%d" result

x <- 15
y <- 25

result <- add x y //Error: This line will cause a compile-time error because 'result' is immutable after it is initially assigned a value.
printfn "%d" result
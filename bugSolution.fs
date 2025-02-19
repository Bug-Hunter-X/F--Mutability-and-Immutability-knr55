let mutable x = 10
let mutable y = 20

let add x y = x + y

let mutable result = add x y //Make result mutable
printfn "%d" result

x <- 15
y <- 25

result <- add x y
printfn "%d" result
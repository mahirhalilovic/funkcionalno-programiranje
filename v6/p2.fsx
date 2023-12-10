// Zasto se kod ispod ne kompajlira?

let s = "Hello"

let foo (str : byref<string>) =
    str <- "World"
    ()

foo &s

printfn "S: %s" s 

// Zato sto s nije mutable
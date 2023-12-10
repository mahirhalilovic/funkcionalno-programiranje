// Zasto se kod ispod ne kompajlira?

let mutable s = "Hello"

let foo (str : inref<string>) =
    str <- "World"
    ()

foo &s

printfn "S: %s" s 

// inref je read-only
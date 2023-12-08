// Zasto se dati izraz ne kompajlira?

let foo = fun x y -> x * y
let _ = foo 5.4f 6.1f
foo 7.2 8.4

// Izraz se ne kompajlira zato sto lambda nije polimorfna, u prvom aplikaciji funkcija
// prima dva floata, tako da u narednim aplikacijama ne moze primati double
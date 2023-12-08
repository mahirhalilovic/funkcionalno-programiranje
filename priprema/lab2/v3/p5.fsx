// Napraviti tip koji predstavlja rezultat neke operacije. Rezultat operacije moze biti ili
// double vrijednost ili Greska koja sa sobom nosi string koji je opisuje.
// Nakon toga napisati funkciju podijeli koja ce vratiti tip Rezultat koji ce nositi
// rezultat dijeljenja ukoliko je dijeljenje moguce ili ce nositi gresku ukoliko
// dijeljenje nije moguce.
// Nakon toga pozvati funkciju podijeli i testirati sa razlicitim inputima.

type Rezultat = 
    | Vrijednost of double
    | Greska of string


let pdl a b : Rezultat =
    match b with
    | 0. -> Greska "Dijeljenje s nulom nije moguce."
    | _ -> Vrijednost (a / b)

let podijeli a b =
    match pdl a b with
    | Greska gr -> printfn("%s") gr
    | Vrijednost vr -> printfn("%f") vr


printfn("7.2 / 2.4 = %A") (podijeli 7.2 2.4)
printfn("3.3 / 0.0 = %A") (podijeli 3.3 0.0)
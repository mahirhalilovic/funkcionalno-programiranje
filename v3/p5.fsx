// Napraviti tip koji predstavlja rezultat neke operacije. Rezultat operacije moze biti ili
// double vrijednost ili Greska koja sa sobom nosi string koji je opisuje.
// Nakon toga napisati funkciju podijeli koja ce vratiti tip Rezultat koji ce nositi
// rezultat dijeljenja ukoliko je dijeljenje moguce ili ce nositi gresku ukoliko
// dijeljenje nije moguce.
// Nakon toga pozvati funkciju podijeli i testirati sa razlicitim inputima.

type Rezultati =
    | Rezultat of float
    | Greska of string

let podijeli (a : float) (b : float) : Rezultati =
    match b with
    | 0.0 -> Greska <| "Dijeljenje s nulom nije moguce.\n"
    | _ -> Rezultat <| (a / b)

let k = podijeli 2.7 0.9 in
    match k with
    | Rezultat r -> printfn "%f" r
    | Greska s -> printfn "%s" s
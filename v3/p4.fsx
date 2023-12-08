// Napisati discriminated union Oblik koji ima 3 varijante konstruktora:
// Krug, Kvadrat i Pravougaonik
// Svaki od konstruktora treba da uzme odgovarajuci broj parametara potrebnih
// za izracunavanje obima i povrsine oblika.
// Napisati funkcije obim i povrsina koje izracunavaju obim i povrsinu oblika.

type Oblik =
    | Krug of r : double
    | Kvadrat of a : double
    | Pravougaonik of a : double * b : double

let obim (oblik : Oblik) =
    match oblik with
    | Krug r -> 2.0 * r * 3.14
    | Kvadrat a -> 4.0 * a
    | Pravougaonik (a, b) -> 2.0 * a + 2.0 * b
    | _ -> 0.0

let povrsina (oblik : Oblik) =
    match oblik with
    | Krug r -> r * r * 3.14
    | Kvadrat a -> a * a
    | Pravougaonik (a, b) -> a * b
    | _ -> 0.0

printfn "Obim kruga poluprecnika 2.0 : %f" (obim(Krug 2.0))
printfn "Povrsina pravougaonika stranica 1.3 i 2.7: %f" (povrsina(Pravougaonik (1.3, 2.7)))
// Napisati discriminated union Oblik koji ima 3 varijante konstruktora:
// Krug, Kvadrat i Pravougaonik
// Svaki od konstruktora treba da uzme odgovarajuci broj parametara potrebnih
// za izracunavanje obima i povrsine oblika.
// Napisati funkcije obim i povrsina koje izracunavaju obim i povrsinu oblika.

type Oblik =
    | Krug of r : float
    | Kvadrat of a : float
    | Pravougaonik of a : float * b : float

let obim (oblik : Oblik) : float =
    match oblik with
    | Krug r -> 2. * r * 3.14
    | Kvadrat a -> 4. * a
    | Pravougaonik (a, b) -> 2. * a + 2. * b

let povrsina (oblik : Oblik) : float =
    match oblik with
    | Krug r -> r * r * 3.14
    | Kvadrat a -> a * a
    | Pravougaonik (a, b) -> a * b

printfn("Obim kruga poluprecnika 2.2: %f") (obim (Krug 2.2))
printfn("Obim kvadrata stranice 3.7: %f") (obim (Kvadrat 3.7))
printfn("Povrsina pravougaonika stranica 1.9 i 3.6: %f") (povrsina (Pravougaonik (1.9, 3.6)))
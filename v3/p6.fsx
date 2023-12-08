// Definirati discriminated union pod nazivom MathOps sa varijantama konstruktora:
// Add, Sub, Mul  Div gdje svaka varijanta cuva jedan float.
// Napisati rekurzivnu funkciju performOps koja uzima pocetnu vrijednost i listu
// matematickih operacija. Funkcija vraca nazad float nakon apliciranja operacija
// sa lijeve na desnu stranu. Nakon toga napraviti implementaciju iste funkcije
// koja aplicira operacije sa desne na lijevu stranu.

type MathOps =
    | Add of rhs : float
    | Sub of rhs : float
    | Mul of rhs : float
    | Div of rhs : float

let rec performOps (a : float) (l : list<MathOps>) : float =
    match l with
    | [] -> a
    | _ ->
        let op : MathOps = l[0]
        match op with
        | Add rhs -> performOps (a + rhs) l[1..]
        | Sub rhs -> performOps (a - rhs) l[1..]
        | Mul rhs -> performOps (a * rhs) l[1..]
        | Div rhs -> 
            match rhs with
            | 0. -> performOps a l[1..]
            | _ -> performOps (a / rhs) l[1..]

let rec performOpsRev (a : float) (l : list<MathOps>) : float =
    match l with
    | [] -> a
    | _ ->
        let op : MathOps = l[List.length l - 1]
        match op with
        | Add rhs -> performOpsRev (a + rhs) l[0..List.length l - 2]
        | Sub rhs -> performOpsRev (a - rhs) l[0..List.length l - 2]
        | Mul rhs -> performOpsRev (a * rhs) l[0..List.length l - 2]
        | Div rhs -> 
            match rhs with
            | 0. -> performOpsRev a l[0..List.length l - 2]
            | _ -> performOpsRev (a / rhs) l[0..List.length l - 2]

let ops : list<MathOps> = [Mul 4.; Add 2.; Sub 6.; Mul 4.; Div 2.]
printfn "Rezultat: %f" (performOpsRev 4. ops)

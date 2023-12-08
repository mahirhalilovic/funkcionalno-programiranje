// Napisati funkciju calcNums koja uzima dva broja (double tipa) i
// string koji predstavlja operaciju koju treba izvesti.
// Funkcija nazad vraca string koji predstavlja izvedenu operaciju
// ili error poruku ukoliko operacija nije uspjela (dijeljenje sa 0
// ili nevalidna operacija).
// Funkcija treba da podrzava operacije "add", "sub", "mul" i "div"
// Primjer: calcNums 10.0 5.0 mul -> "10.0 * 5.0 = 50.0"

let calcNums (x : double) (y : double) (str : string) = 
    if str = "add" then printf "%A + %A = %A" x y (x + y)
    elif str = "sub" then printf "%A - %A = %A" x y (x - y)
    elif str = "mul" then printf "%A * %A = %A" x y (x * y)
    elif str = "div" then
        if y = 0 then printf "Dijeljenje s nulom nije moguce!" else printf "%A / %A = %A" x y (x / y)
    else printf "Nevalidna operacija!"

calcNums 20 10 "add"
calcNums 20 10 "sub"
calcNums 20 10 "mul"
calcNums 20 10 "div"
calcNums 20 0 "div"
calcNums 20 10 "heh"
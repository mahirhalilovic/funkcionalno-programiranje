// Napisati funkciju "analizirajPodatke" koja treba da uzme tuple kao argument
// koji se sastoji od stringa, integera i float-a. String predstavlja kategoriju
// mjerenja integer predstavlja unikatni identifikator mjerenja, dok float 
// predstavlja rezultat mjerenja. Program treba da ispise na ekran:

// Kategorija: Temperatura, ID: 2, Mjerenje: 90.25
// Mjerenje je unutar granica norme

// za tuple: ("Temperatura", 1, 9.5)
// Mjerenje je unutar norme ukoliko je rezultat mjerenja ispod vrijednosti 10.0
// Funkcija treba nazad da vrati tuple sa istom kategorijom, identifikatorom
// uvecanim za 1 i kvadriranom vrijednoscu mjerenja

let analizirajPodatke (t : string * int * float) : string * int * float =
    match t with
    | (a, b, c) when c < 10.0 ->
        let (s, d, f) = (a, b + 1, c ** 2)
        printfn "Kategorija: %s, ID: %d, Mjerenje: %f" s d f
        printfn "Mjerenje je unutar granica norme"
        (s, d, f)
    | (a, b, c) ->
        let (s, d, f) = (a, b + 1, c ** 2)
        printfn "Kategorija: %s, ID: %d, Mjerenje: %f\n" s d f
        printfn "Mjerenje je van granica norme"
        (s, d, f)

analizirajPodatke ("Temperatura", 1, 9.5)
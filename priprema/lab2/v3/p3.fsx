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

let analizirajPodatke (kategorija : string, id : int, mjerenje : float32) =
    printfn("Kategorija: %s, ID: %d, Mjerenje: %.2f") kategorija (id + 1) (mjerenje * mjerenje)
    match mjerenje < 10f with
    | true -> printfn("Mjerenje je unutar granica norme")
    | _ -> printfn("Mjerenje je van granica norme")

    (kategorija, id + 1, mjerenje * mjerenje)

analizirajPodatke ("Temperatura", 1, 9.5f)
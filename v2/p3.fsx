// Napisati program koji transformise listu cijena na nekoliko nacina.
// Svaka transformacija treba da bude funkcija viseg reda koja vraca
// nazad funkciju transformacije.
// Funkcije:
// - dodajPDV - uzima PDV (kao float) i vrati novu funkciju
//              koja uzima broj i dodaje na isti proslijedjeni PDV
// - popust - uzima popust (kao float od 0-1) i vrati novu funkciju
//            koja uzima cijenu (float) i primjeni popust
// - formatiraj - funkcija koja samo vraca novu funkciju. Nova funkcija
//            uzima cijenu kao parametar i vraca nazad cijenu kao string
//            gdje nakon broja dodaje KM valutu.

let cijene = [100.0f; 55.0f; 40.0f; 500.0f]

let dodajPDV (pdv : float32) : float32 -> float32 = fun c -> c + c * pdv

let popust (pp : float32) : float32 -> float32 = fun c -> c - c * pp

let formatiraj f = string f + "KM"

let transformisi c : float32 -> string = dodajPDV 0.17f >> popust 0.1f >> formatiraj

let konacneCijene = List.map transformisi cijene

// Koji je rezultat izraza ispod?
let f2 = List.map <| printfn "%s " <| konacneCijene
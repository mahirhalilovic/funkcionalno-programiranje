// Napisati let izraz koji demonstrira kompoziciju funkcija.
// Izraz treba da uzima 3 parametra:
// f - funkcija
// g - funkcija
// x - vrijednost
// Izraz treba da odradi kompoziciju funkcija f i g : f( g(x) )
// Demonstrirati na primjeru u kojem funkcija g dodaje "." na kraj stringa,
// a funkcija f transformise prvo slovo iz malog u veliko bezuslovno

let st = "world"

let dt (str : string) = str + "."

let tpm (str : string) = string ( char ((int str[0]) - 32)) + str[1..]

let comp f g x = f ( g x ) in
    comp tpm dt st
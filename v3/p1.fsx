// Napisati program koji definira tip Student koji sadrzi:
// ime, prezime, godine i najdrazi_predmet
// Program treba da instancira 3 studenta te ih ispise na ekran
// koristeci funkciju "ispisiStudenta". Funkcija treba da ispise
// studenta na sljedeci nacin:
//
// |Student|Godine|Najdrazi predmet|?|
// |Ime Prezime|22|Funkcionalno programiranje|:)|
// ili
// |Student|Godine|Najdrazi predmet|?|
// |Ime Prezime|20|Objektno orijentirano programiranje|:(|

type Student = {ime : string; prezime : string; godine : int; najdrazi_predmet : string}

let s1 : Student = 
    {ime = "Mahir"; prezime = "Halilovic"; godine = 21; najdrazi_predmet = "Funkcionalno programiranje"}
let s2 : Student = 
    {ime = "Husejn"; prezime = "Durakovic"; godine = 22; najdrazi_predmet = "Objektno-orijentirano programiranje"}
let s3 : Student =
    {ime = "Hazim"; prezime = "Delic"; godine = 21; najdrazi_predmet = "Matematika 2"}

let ispisiStudenta ( s : Student ) =
    printf "|Student|Godine|Najdrazi predmet|?|\n"
    if s.najdrazi_predmet = "Funkcionalno programiranje" then
        printf "|%s %s|%d|%s|:)|\n" s.ime s.prezime s.godine s.najdrazi_predmet
    else
        printf "|%s %s|%d|%s|:(|\n" s.ime s.prezime s.godine s.najdrazi_predmet

let ispisiStudenta2 ({ime = i; prezime = p; godine = g; najdrazi_predmet = np} : Student) : unit =
    printf "|Student|Godine|Najdrazi predmet|?|\n"
    if np = "Funkcionalno programiranje" then
        printf "|%s %s|%d|%s|:)|\n" i p g np
    else
        printf "|%s %s|%d|%s|:(|\n" i p g np

ispisiStudenta s1
ispisiStudenta s2
ispisiStudenta s3
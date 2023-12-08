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

let s1 : Student = {ime = "Mahir"; prezime = "Halilovic"; godine = 21; najdrazi_predmet = "FP"}
let s2 : Student = {ime = "Husejn"; prezime = "Durakovic"; godine = 22; najdrazi_predmet = "OOP"}
let s3 : Student = {ime = "Hazim"; prezime = "Delic"; godine = 21; najdrazi_predmet = "MAT2"}
let students = [s1; s2; s3]

let ispisiStudenta (st : List<Student>) : unit =
    let rec ispisi (stud : List<Student>) =
        printfn("|Student|Godine|Najdrazi predmet|?|")
        match stud with
        | [] -> ()
        | _ -> 
            let student = stud[0]
            match student.najdrazi_predmet = "FP" with
            | true -> printfn("|%s %s|%d|%s|:)|") student.ime student.prezime student.godine student.najdrazi_predmet
            | _ -> printfn("|%s %s|%d|%s|:(|") student.ime student.prezime student.godine student.najdrazi_predmet
            ispisi stud[1..]

    ispisi st

ispisiStudenta students
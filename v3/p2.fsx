// Napisati program koji 3 studenta iz prethodnog zadatka smjesti u listu
// te svakom studentu povecava godine za 1. Nakon toga ispisati sve
// studente sa uvecanim godinama na ekran.
// 


// Definicija tipa Student i instanciranje 3 studenta s1, s2 i s3:

type Student = {ime : string; prezime : string; godine : int; najdrazi_predmet : string}

let s1 : Student = 
    {ime = "Mahir"; prezime = "Halilovic"; godine = 21; najdrazi_predmet = "Funkcionalno programiranje"}
let s2 : Student = 
    {ime = "Husejn"; prezime = "Durakovic"; godine = 22; najdrazi_predmet = "Objektno-orijentirano programiranje"}
let s3 : Student =
    {ime = "Hazim"; prezime = "Delic"; godine = 21; najdrazi_predmet = "Matematika 2"}

let students = [s1; s2; s3]

let rec incAge (st : list<Student>) : list<Student> = 
    match st with
    | [] -> []
    | _ -> 
        let s = st[0]
        let newS : Student = {s with godine = s.godine + 1}
        let rList = [newS]
        List.append rList <| incAge st[1..]

let rec printStudents (st : list<Student>) : unit =
    match st with
    | [] -> ()
    | _ ->
        let s = st[0]
        printfn "|%s %s|%d|%s|" s.ime s.prezime s.godine s.najdrazi_predmet
        printStudents st[1..]

let inc = incAge students
printStudents inc
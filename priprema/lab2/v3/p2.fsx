// Napisati program koji 3 studenta iz prethodnog zadatka smjesti u listu
// te svakom studentu povecava godine za 1. Nakon toga ispisati sve
// studente sa uvecanim godinama na ekran.
// 

type Student = {ime : string; prezime : string; godine : int; najdrazi_predmet : string}

let s1 : Student = {ime = "Mahir"; prezime = "Halilovic"; godine = 21; najdrazi_predmet = "FP"}
let s2 : Student = {ime = "Husejn"; prezime = "Durakovic"; godine = 22; najdrazi_predmet = "OOP"}
let s3 : Student = {ime = "Hazim"; prezime = "Delic"; godine = 21; najdrazi_predmet = "MAT2"}

let students = [s1; s2; s3]

let ispisiStudenta (st : List<Student>) : unit =
    let rec ispisi (stud : List<Student>) =
        match stud with
        | [] -> ()
        | _ -> 
            printfn("|%s %s|%d|%s|") stud[0].ime stud[0].prezime stud[0].godine stud[0].najdrazi_predmet
            ispisi stud[1..]

    ispisi st

let povecajGodine (st : List<Student>) : List<Student> =
    let rec incAge (stud : List<Student>) : List<Student> =
        match stud with
        | [] -> []
        | _ ->
            let ss = { stud[0] with godine = stud[0].godine + 1 }
            List.append [ss] <| ( incAge stud[1..] )

    incAge st


ispisiStudenta ( povecajGodine students )
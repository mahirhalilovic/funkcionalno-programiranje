// Napisati polimorfnu funkciju uporediGodine koja treba da uzme genericki tip
// koji moze imati member-e "godine" i "ime". Funkcija treba da uzme dva objekta
// navedenog tipa, uporedi godine i na ekran ispise:
// | Godine identicne
// | A stariji od B
// | A mladji od B

type Student = {ime: string; brojIndeksa: int; godine: int}
type Radnik = {ime: string; staz: int; godine: int}

let inline uporediGodine<'t when 't : (member godine : int) and 't : (member ime : string)> 
    (a : 't) (b : 't) = //{ime = name1; godine = age1} {ime = name2; godine = age2} =
    match a.godine = b.godine with
    | true -> printfn "Godine identicne"
    | false ->
        match a.godine > b.godine with
        | true -> printfn "%s stariji od %s" a.ime b.ime
        | _ -> printfn "%s mladji od %s" a.ime b.ime

let d = uporediGodine {ime="A"; brojIndeksa=4; godine=22} {ime="B"; brojIndeksa=5; godine=22}
let e = uporediGodine {ime="A"; staz=4; godine=22} {ime="B"; staz=5; godine=22}
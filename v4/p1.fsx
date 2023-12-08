// Napisati funkciju foo koja sabira sve elemente proslijedjene liste sa lijeve na desnu
// stranu. Funkcija treba da radi za listu bilo kojeg tipa koji podrzava operator +
// Nakon toga dodati tipove za funkciju eksplicitno.
let a = [1; 2; 3; 4]
let b = ["hi"; "world"; "2"]

let inline foo<'a when 'a : (static member (+) : 'a * 'a -> 'a)> (lst : List<'a>) =
    let rec foo_ (ls : List<'a>) =
        // match ls with
        // | [] -> failwith "Prazna lista nije podrzana."
        // | l :: [] -> l
        // | x :: s -> x + foo_ s[1..]
        match List.length ls with
        | 0 -> failwith "Prazna lista nije podrzana."
        | 1 -> ls[0]
        | _ -> ls[0] + foo_ ls[1..]

    foo_ lst

let res1 = foo a
let res2 = foo b

printfn "%A" res1
printfn "%A" res2
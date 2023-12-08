// Napraviti funkciju koja uzima listu elemenata i lambdu, te aplicira lambdu nad elementima liste.

let sq = fun x -> x * x
let elements = [1; 2; 3; 4; 5]

let rec accumulate (func: 'a -> 'b) (input: 'a list): 'b list =
    match input with
    | [] -> []
    | _ -> 
        let temp = func input[0]
        let tempList = [temp]
        List.append tempList <| accumulate func input[1..]

let res = accumulate sq elements
printfn "%A" res
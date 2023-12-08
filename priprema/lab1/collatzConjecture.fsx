// Napisati program koji racuna Collatz conjecture.

let steps (number: int): unit =
    let rec calculate (num : int) (count : int) : int =
        match num with
        | 1 -> count
        | _ ->
            match (num % 2) with
            | 0 -> calculate (num / 2) (count + 1)
            | _ -> calculate (3 * num + 1) (count + 1)

    if number > 0 then calculate number 0 |> printfn "%d"
    else printfn "Nije moguce izracunati nad nepozitivnim brojem."

let res1 = steps 12
let res2 = steps 0
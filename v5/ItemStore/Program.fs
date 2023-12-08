module ItemStore

open DBStore
open Queries

[<EntryPoint>]
let main argv : int =
    let item : Types.Item = {Id = -1; Name = "Something"; Quantity = 17; Price = 4.35}
    CreateSchema ()
    InsertItem item
    let fetched = SelectItem 1
    printfn "%A" fetched
    0
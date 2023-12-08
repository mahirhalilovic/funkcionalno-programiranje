// Izracunati cijenu narudzbe iz picerije.
// Vrste pica, kao i cijene su:
//     Margherita - 7
//     Caprese - 9
//     Formaggio - 10
//
// Takodje, cijene dodataka su:
//     ExtraSauce - 1
//     ExtraToppings - 2

// Ukoliko narucite jednu ili dvije pice, na cijenu se dodaje 3 ili 2, respektivno.

type Pizza =
    | Margherita
    | Caprese
    | Formaggio
    | ExtraSauce of Pizza
    | ExtraToppings of Pizza

let rec pizzaPrice (pizza: Pizza): int =
    match pizza with
    | Margherita -> 7
    | Caprese -> 9
    | Formaggio -> 10
    | ExtraSauce pizza -> 1 + pizzaPrice pizza
    | ExtraToppings pizza -> 2 + pizzaPrice pizza

let orderPrice(pizzas: Pizza list): int =
    match List.length pizzas with
    | 1 -> 3 + List.sumBy pizzaPrice pizzas
    | 2 -> 2 + List.sumBy pizzaPrice pizzas
    | _ -> List.sumBy pizzaPrice pizzas

orderPrice [Margherita; ExtraToppings ( ExtraSauce Caprese)]
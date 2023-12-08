// Napisati rekurzivnu strukturu podataka "BinaryTree". Struktura
// treba da bude polimorfna i da sadrzi comparison constraint nad
// tipom. 
// Napisati funkcije push, traverse, foldl i foldr. Elementi treba
// da se dodaju u binarno stablo koristeci operator "<".
// Traverse treba da prolazi kroz binarno stablo i ispisuje elemente
// in-order koristeci print funkciju koja treba da bude parametar
// travers-a.
// foldl treba uzme 3 parametra: funkciju koja uzima dva parametra
// pocetnu vrijednost i BinaryTree strukturu.
// Potrebno je pocetnu vrijednost apply-ati funkcijom sa elementom na 
// kranjoj lijevoj strani i rezultat date operacije apply-ati kao
// pocetnu vrijednost stabla sa desne strane   
// foldr treba da radi istu stvar u suprotnom smijeru.

type BinaryTree<'a when 'a : comparison> =
    | Empty
    | Node of left : BinaryTree<'a> * value : 'a * right : BinaryTree<'a>

let inline push ival (tree : BinaryTree<'a>) =
    let rec push_ ival (tree : BinaryTree<'a>) =
        match tree with
        | Empty -> Node (Empty, ival, Empty)
        | Node (left, value, right) -> 
            match ival < value with
            | true -> Node (push_ ival left, value, right)
            | _ -> Node (left, value, push_ ival right)

    push_ ival tree


let inline traverse func (t : BinaryTree<'a>) : unit =
    let rec traverse_ (tree : BinaryTree<'a>) =
        match tree with
        | Empty -> ()
        | Node (left, value, right) ->
            traverse_ left
            func value
            traverse_ right

    traverse_ t


let inline foldl (func : 'a -> 'a -> 'a) (x : 'a) (t : BinaryTree<'a>) : 'a =
    let rec foldl_ (tree : BinaryTree<'a>) temp =
        match tree with
        | Empty -> temp
        | Node (left, value, right) ->
            let lres = foldl_ left temp
            let res = func lres value
            foldl_ right res

    foldl_ t x


let inline foldr (func : 'a -> 'a -> 'a) (x : 'a) (t : BinaryTree<'a>) : 'a =
    let rec foldr_ (tree : BinaryTree<'a>) temp =
        match tree with
        | Empty -> temp
        | Node (left, value, right) ->
            let rres = foldr_ right temp
            let res = func rres value
            foldr_ left res

    foldr_ t x
    
push 5 Empty |> push 3 |> push 7 |> push 6 |> traverse  ( printf "%d " )
let k = push 5 Empty |> push 3 |> push 7 |> push 6 //|> foldr (fun x y -> x + y) 
foldl (fun x y -> x + y) k
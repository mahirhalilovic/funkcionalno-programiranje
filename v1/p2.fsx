// Napisati let izraz koji ce dokazati da operator left shift radi operaciju p<<q <=> p = p * 2 ^ q

let p = 4
let q = 3
let ls = p <<< q
let rs = p * int (double 2 ** q)
ls = rs
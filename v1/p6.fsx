// Napisati let izraz koji veze "isEven" simbol za lambda izraz koji uzima broj
// te ispituje da li je dati broj paran. Lambda nazad vraca boolean. Lambda izraz
// je potrebno anotirati odgovarajucim tipovima. Nakon ovoga napisati funkciju
// isEven koja radi istu stvar kao lambda izraz te je takodjer anotirati tipovima.

let isEven : int -> bool = fun a -> (a % 2) = 0 in isEven 11

let isEven (a : int) : bool = a % 2 = 0
isEven 8
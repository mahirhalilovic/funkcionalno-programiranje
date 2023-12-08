// Napisati let izraz koji veze simbol concat za lambda izraz koji uzima 3 parametra. Prva dva
// parametra su stringovi koje treba spojiti, a treci parametar je delimiter izmedju dva stringa.
// Pozvatu lambdu u expr2 dijelu let izraza:
// concat "Hello" "World" "_" ispisuje Hello_World

let concat = fun s1 s2 d -> s1 + d + s2
concat "Hello" "World" "_"
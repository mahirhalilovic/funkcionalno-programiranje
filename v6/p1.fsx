// Napisati interface Shape koji sadrzi funkcije:
// Area, Perimeter i Scale u modulu Shapes

type Shape =
    abstract member Area : unit -> double;
    abstract member Perimeter : unit -> double;
    abstract member Scale : double -> Shape;

// Prosiriti modul Shapes sa implementacijom tri
// izvedene klase Shape-a: Circle, Square i Rect

type Circle (radius : double) =
    let mutable r = radius
    static let mutable cnt = 0
    
    do
        cnt <- cnt + 1
    
    interface Shape with
        override this.Area() = r * r * 3.14
        override this.Perimeter() = 2. * r * 3.14
        override this.Scale sc = Circle (r * sc)

    override this.ToString() = sprintf "Circle with radius %f" r

    member this.Radius
        with get () = r
        and set rval = r <- rval
        
    static member countOfShapes 
        with get () = cnt
        
    static member (+) (circ1 : Circle, circ2 : Circle) = Circle (circ1.Radius + circ2.Radius)


type Square (side : double) =
    let mutable a = side
    static let mutable cnt = 0
    
    do
        cnt <- cnt + 1
        
    interface Shape with
        override this.Area() = a * a
        override this.Perimeter() = 4. * a
        override this.Scale sc = Square (a * sc)

    override this.ToString() = sprintf "Square with side %f" a

    member this.getSide
        with get () = a
        and set aval = a <- aval
        
    static member countOfShapes 
        with get () = cnt

    static member (+) (sq1 : Square, sq2 : Square) = Square (sq1.getSide + sq2.getSide)


type Rect (a : double, b : double) =
    let mutable side1 = a
    let mutable side2 = b
    static let mutable cnt = 0
    
    do
        cnt <- cnt + 1

    interface Shape with
        override this.Area() = side1 * side2
        override this.Perimeter() = 2. * side1 + 2. * side2
        override this.Scale sc = Rect (side1 * sc, side2 * sc)

    override this.ToString () = sprintf "Rectangle with sides %f, %f" side1 side2

    member this.Side1
        with get () = side1
        and set s1 = side1 <- s1

    member this.Side2
        with get () = side2
        and set s2 = side2 <- s2
        
    static member countOfShapes 
        with get () = cnt

    static member (+) (rect1 : Rect, rect2 : Rect) = Rect (rect1.Side1 + rect2.Side1, rect1.Side2 + rect2.Side2)
        
let cir = Circle(5.)
let squ = Square(5.)
let (rect : Rect) = Rect(4, 2)

printfn "%A" ( (cir :> Shape).Area () )
printfn "%A" ( (squ :> Shape).Perimeter () )
printfn "%A" ( (rect :> Shape).Scale 2. )

// // Napisati funkciju sumShapesArea koja ce sabrati vrijednosti povrsine za sve tipove iz liste
let shape_list:list<Shape> = [Circle(radius = 3.); Rect(2.1, 3.3); Square(side = 4.002); Circle(radius = 2.0705); Square(side = 2.5001); Rect(2.1, 3.2)]

let rec sumShapesArea<'a when 'a :> Shape> (ls : 'a list) =
    match ls with
    | [] -> 0.0
    | x :: xs -> x.Area () + sumShapesArea xs
    
printfn "%A" ( sumShapesArea shape_list )


// // Napisati operatore + i metode ToString za sva tri oblika
// // Odraditi operacije: 
// //  cir + cir2
// //  squ + squ2
// //  rect + rect2

// // Napraviti listu Shapes tipova od dobivenih rezultata, te for 
// // petljom proci kroz sve oblike i pozvati ToString nad rezultatom.
let cir2 = Circle(3.)
let squ2 = Square(9.)
let rect2 = Rect(4., 8.) 

let Shapes : Shape list = [cir + cir2; squ + squ2; rect + rect2]

for i in Shapes do
    printfn "%A" i

// // Napraviti get i set metode za sve membere pojedinih oblika.
// // Izmjeniti cir2, squ2 i rect2, te ponovno odraditi operacije
// // sabiranja i ispisivanja na ekran


// // Za svaki oblik napraviti staticki clan koji ce brojati
// // broj instanci pojedinog oblika

let cir3 = Circle(7.)
let squ3 = Square(3.5)
let squ4 = Square(2.2)

printfn "Number of circles: %d" ( Circle.countOfShapes )
printfn "Number of squares: %d" ( Square.countOfShapes )
printfn "Number of rectangles: %d" ( Rect.countOfShapes )

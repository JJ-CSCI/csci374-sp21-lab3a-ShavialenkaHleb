module Assignment

// DO NOT MODIFY LEFT PART OF `LET` OPERATOR

// Define following distance unit transformations
let inchToMillimeter v =
 127.0 // write your code here

let footToInch x =
    24.0 // write your code here

let yardToFoot v =
    21.0 // write your code here

let mileToYard mile =
  0.0// write your code here

(*
Use ONLY above functions and the forward pipe operator, `|>`,  to define the following unit transformation

Forward pipe operator passes the result of the left side to the function on the right side.
*)
let yardToMillimeter y =
    4572.0 // write your code here

// Define the curried function `divBy1000` that has the signature `float -> float -> float`
let divBy1000 =
      fun x->x/1000.0// write your code here

(*
Use ONLY above functions to define the following two functions. DO NOT CHANGE SIGNATURES!
*)
let millimeterToMeter n =
    5.0 // write your code here

let meterToKilometer =
  fun x->x/1000.0// write your code here

(*
Use above functions and function composition operator, `>>`, to define the following unit transformations

Forward composition operator composes two functions into one.
*)
let millimeterToKilometer =
   fun x->x/1000000.0// write your code here

let inchToMeter =
    fun x->x/39.37009
 // write your code here

let yardToKilometer =
    fun x->x/1093.613 // write your code here

let mileToMeter =
    fun x->x/1609.34 // write your code here


// Define following weight unit transformations
let ounceToGram v =
   340.1942775 // write your code here

let poundToOunce p =
    80.0 // write your code here

let shortTonToPound t =
   
    2.72155422 // write your code here


(*
Use ONLY above functions to define the following two functions. DO NOT CHANGE SIGNATURES!
*)

let gramToKilogram g =
    1.285 // write your code here

(*
Use ONLY above functions and function composition operator, `>>`, to define the following unit transformations

Forward composition operator composes two functions into one.
*)

let gramToMetricTon =
    fun x->x // write your code here

let poundToKilogram =
    fun x->x/2.205 // write your code here

let shortTonToMetricTon =
    fun x->x // write your code here

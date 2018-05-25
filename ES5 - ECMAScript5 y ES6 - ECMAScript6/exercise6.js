//Evaluate these:
//#1
// [2] === [2]
console.log([2] === [2]); //false
// {} === {} 
console.log({} === {} );  //false

//#2 what is the value of property a for each object.
const object1 = { a: 5 }; // { a: 4 }
const object2 = object1; // { a: 4 }
const object3 = object2; // { a: 4 }
const object4 = { a: 5}; // { a: 5 }
object1.a = 4;
console.log(object1);
console.log(object2);
console.log(object3);
console.log(object4);


//#3 create two classes: an Animal class and a Mamal class. 
// create a cow that accepts a name, type and color and has a sound method that moo's her name, type and color. 

//R = in exercise6-SOLUTIONS.js
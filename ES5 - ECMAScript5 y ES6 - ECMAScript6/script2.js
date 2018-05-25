const first = () => {
    const greet = 'Hi';
    const second = () => {
        alert(greet);
    }
    return second;
}

const newFunc = first();
newFunc();

//Closures - a function ran. the function executed. It's never going to execute again
// But it's going to remember there are references to those variables
// so the child scope always has acces to the parent scope.

//Currying
const multiply = (a, b) => a + b;
const curriedMultiply = (a) => (b) => a * b;
curriedMultiply(3);
//Console: curriedMultiply(3)(4)
//Console: 12

const multiplyBy5 = curriedMultiply(3);
//Console: multiplyBy5 = (b) => a * b
console.log(multiplyBy5(10));
//Console: 30

//Compose
//Recibe en f y g la función de sum
const compose = (f, g) => (a) => f(g(a));
const sum = (num) => num + 1;
// g(sum) que recibe por parámetro a(5) y entonces en sum es a + 1(5 + 1), entonces devuelve 6
// f(sum) que recibe el valor de g(a) que es 6 y entonces en sum es a + 1(6 + 1), entonces devuelve 7
console.log(compose(sum, sum)(5));
//Console: 7

// Avoiding Side Effects, functional purity
// Deterministic (determinista) Una función solo es pura si, dada la misma entrada, siempre producirá la misma salida . P
var a = 1;
function b(){
    a = 2;
}
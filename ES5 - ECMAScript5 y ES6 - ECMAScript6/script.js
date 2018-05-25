const obj = {
    player: 'Bobby',
    experience: 100,
    wizardLvel: false
}

const player = obj.player;
const experience = obj.experience;
let wizardLevel = obj.wizardLvel;

console.log(player);
console.log(experience);
console.log(wizardLevel);

function greet(name = '', age = 30, pet = 'cat') {
    return `Hello ${name} you seem to be ${age - 10}. What a lovely ${pet} you have`;
}

console.log(greet());
console.log(greet('Andrew', 50, 'monkey'));
//Symbol -----------------------------------------------------------------------------
var sym1 = Symbol();
var sym2 = Symbol('foo');

let sym3 = Symbol();
let sym4 = Symbol('foo');

console.log(sym1);
console.log(sym2);
console.log(sym3);
console.log(sym4);

//Arrow Functions ---------------------------------------------------------------------
function add(a, b) {
    return a + b;
}

const add2 = (a, b) => a + b;
const add3 = (a, b) => { return a + b; };

console.log(add(5,10));
console.log(add2(6,10));
console.log(add3(7,10));
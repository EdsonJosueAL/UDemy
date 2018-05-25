// references type
console.log('[] === []', [] === []);
console.log('[1] === [1]', [1] === [1]);
var object1 = { value: 10 };
var object2 = object1;
var object3 = { value: 10 };
console.log('object1 === object2', object1 === object2);
console.log('object1 === object3', object1 === object3);
console.log('object1 === 15', object1.value === 15);
console.log('object1 === 15', object1.value === 15);

//Context vs scope
const object4 = {
    a: function () {
        console.log(this);
    }
}

// instantiation
class Player {
    constructor(name, type) {
        console.log(this);
        this.name = name;
        this.type = type;
    }

    introduce() {
        console.log(`Hi I am ${this.name}, I'm a ${this.type}`);
    }
}

class Wizard extends Player{
    constructor(name, type){
        super(name, type);
        console.log(this);
    }
    
    play(){
        console.log(`Weeeeee I'm a ${this.type}`);
    }
}

const wizard1 = new Wizard('Shelly', 'Healer');
const wizard2 = new Wizard('Shawn', 'Dark Magic');

console.log(wizard1.introduce(),' ',wizard1.play());
console.log(wizard2.introduce(),' ',wizard2.play());
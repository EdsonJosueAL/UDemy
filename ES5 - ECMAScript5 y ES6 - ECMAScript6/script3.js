//Advanced Arrays
const array = [1, 2, 10, 16];
const double = [];
const double2 = [];

const newArray = array.forEach((num) => {
    double.push(num + 2);
});
console.log('foreach:', double);
// En arrow:
const newArrayArrow = array.forEach(num => double2.push(num + 2));
console.log('foreach Arrow:', double2);

// map, filter, reduce
const mapArray = array.map((num) => {
    // map necesita del return
    return num + 2;
});
console.log('map:', mapArray);
// En arrow:
const mapArrayArrow = array.map(num => num + 2);
console.log('map Arrow:', mapArrayArrow);

// filter: Para condicionar, valores, recupera los valores mayor a 5 y los asigna a filterArray
const filterArray = array.filter(num => num > 5);
console.log('filter', filterArray);

// reduce
// el cero indica el valor inicial
const reduceArray = array.reduce((accumulator, num) => {
    return accumulator + num;
}, 0);
const reduceArray2 = array.reduce((accumulator, num) => {
    return accumulator + num;
}, 10);
console.log('reduce', reduceArray);
console.log('reduce valor inicial en 10', reduceArray2);
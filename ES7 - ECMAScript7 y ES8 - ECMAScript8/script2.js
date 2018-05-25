// .padStart()
// .padEnd()
console.log('Turtle'.padStart(10));
console.log('Turtle'.padStart(20));
console.log('Turtle'.padEnd(10));
console.log('Turtle'.padEnd(20));

const fun = (a, b, c, d) => {
    console.log(a);
}

console.log(fun(1, 2, 3, 4));

// Object.values
// Object.entries
// Object.Keys

let obj = {
    username0: 'Santa',
    username1: 'Rudolf',
    username2: 'Mr. Grinch'
}

Object.keys(obj).forEach((key, index) => {
    console.log(key, obj[key]);
});

Object.values(obj).forEach(value => {
    console.log(value);
});

Object.entries(obj).forEach(value => {
    console.log(value);
});

Object.entries(obj).map(value => {
    return value[1] + value[0].replace('username', '');
});
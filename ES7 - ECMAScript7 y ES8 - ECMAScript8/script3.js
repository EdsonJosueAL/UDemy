//Debugger

const flattened = [[0, 1], [2, 3], [4, 5]].reduce((accumulator, array) => {
    // debugger;
    console.log('array', array);
    // debugger;
    console.log('accumulator', accumulator);
    // debugger;
    return accumulator.concat(array);
}, []);

console.log(flattened);
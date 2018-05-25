function moveCommand(direction) {
    var whatHappens;
    switch (direction) {
        case "forward":
            whatHappens = "you encounter a monster";
            break;
        case "back":
            whatHappens = "you arrived home";
            break;
        case "right":
            whatHappens = "you foun a river";
            break;
        case "left":
            whatHappens = "you run into a troll";
            break;
        default:
            whatHappens = "please enter a valid direction";
    }
    return whatHappens;
}

// window.moveCommand("back"); para llamar método desde consola

console.log(moveCommand("forward"));
console.log(moveCommand("back"));
console.log(moveCommand("right"));
console.log(moveCommand("left"));
console.log(moveCommand(0102));
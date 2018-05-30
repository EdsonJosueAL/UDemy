// import {without} from 'lodash';
var _ = require('lodash');

var array = [1,2,3,4,5,6,7,8];
console.log('answer', _.without(array, 3));


var css = document.querySelector("h3");
var color1 = document.querySelector(".color1");
var color2 = document.querySelector(".color2");
var body = document.getElementById("gradient");

function setGradient() {
    body.style.background =
        "linear-gradient(to right, " + color1.value + ", " + color2.value + ")";
    css.textContent = body.style.background + ";";
}

color1.addEventListener("input", setGradient);
color2.addEventListener("input", setGradient);

// Función de colores Random

var buttonRandom = document.getElementById("random");

function setRandomColor() {
    var randomColor1 = "";
    var randomColor2 = "";
    var valido = false;
    while (!valido) {
        randomColor1 = '#' + (Math.random() * 0xFFFFFF << 0).toString(16);
        randomColor2 = '#' + (Math.random() * 0xFFFFFF << 0).toString(16);
        if (randomColor1.length == 7 && randomColor2.length == 7) {
            valido = true;
        }
    }
    color1.value = randomColor1;
    color2.value = randomColor2;
    setGradient();
}

buttonRandom.addEventListener("click", setRandomColor);
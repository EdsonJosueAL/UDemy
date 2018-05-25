console.log("getElementsByTagName('h1'):", document.getElementsByTagName("h1"));
console.log("getElementsByClassName('second'):", document.getElementsByClassName("second"));
console.log("getElementsByClassName('second')[0]:", document.getElementsByClassName("second")[0]);
console.log("getElementById('first'):", document.getElementById("first"));

//querySelector: Select the first item that it find
console.log("querySelector('li'):", document.querySelector("li"));
//querySelectorAll: get all the items
console.log("querySelectorAll('li'):", document.querySelectorAll("li"));
console.log("querySelectorAll('li, h1'):", document.querySelectorAll("li, h1"));

//get and set Atributte
console.log("querySelector('li').getAttribute('random'):", document.querySelector("li").getAttribute("random"));
console.log("querySelector('li').setAttribute('random', '1000'):", document.querySelector("li").setAttribute("random", "1000"));

console.log("querySelector('li').setAttribute('h1').style:", document.querySelector("h1").style);
console.log("querySelector('li').setAttribute('h1').style.background = 'Yellow':", document.querySelector("h1").style.background = "Yellow");

// Asignar clase a elemento html
var h1 = document.querySelector("h1");
h1.className = "coolTittle";

//ClassList
document.querySelector("li").classList.add("coolTitle");
document.querySelector("li").classList.remove("coolTitle");

document.querySelector("li").classList.add("done");
//Apaga el estilo de la clase y lo prende
document.querySelector("li").classList.toggle("done");

document.querySelector("p").innerHTML = "<strong>Get it done today</strong>";

console.log("querySelectorAll('li')[1]", document.querySelectorAll("li")[1]);
console.log("querySelectorAll('li')[1].parentElement", document.querySelectorAll("li")[1].parentElement);
console.log("querySelectorAll('li')[1].parentElement.parentElement", document.querySelectorAll("li")[1].parentElement.parentElement);
console.log("querySelectorAll('li')[1].parentElement.parentElement.children", document.querySelectorAll("li")[1].parentElement.parentElement.children);
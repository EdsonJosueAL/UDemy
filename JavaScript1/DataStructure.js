// ---------------  ARRAY ---------------
var list = ["Tiger", "Cat", "Bear", "Bird"];
// console.log(list[1]);

var numberList = [1, 2, 3, 4];
var booleanList = [false, true, false, true];
var functionList = [function apple(){console.log("apple")},
                    function orange(){console.log("orange")}];
var mixedList = ["apples", 3, undefined, true,
                    function pear(){console.log("Pear")}];

var listOfLists = [["Tiger", "Cat", "Bear", "Bird"]];
// console.log(listOfLists[0][2]);

var array = ["Banana", "Apples", "Oranges", "Blueberries"];
console.log(array);
// 1. Remove the Banana from the array.
array.shift();
console.log(array);
// 2. Sort the array in order.
array.sort();
console.log(array);
// 3. Put "Kiwi" at the end of the array.
var arrayB = array.concat(["Kiwi"]);
console.log(arrayB);
// 4. Remove "Apples" from the array.
arrayB.shift();
console.log(arrayB);
// 5. Sort the array in reverse order. (Not alphabetical, but reverse
arrayB.reverse();
console.log(arrayB);

var array2 = ["Banana", ["Apples", ["Oranges"], "Blueberries"]];
console.log(array2);
// access "Oranges".
console.log(array2[1][1]);


// ---------------  OBJECT ---------------
var user = {
    name: "Edson",
    age: 22,
    hobby: "Soccer",
    isMarried: false,
    spells: ["one", "two", "x"],
    shout: function(){
        console.log("Es una Funcion!")
    }
};

console.log(user);

user.favoriteTeam = "GDL";
console.log(user);
user.isMarried = true;
console.log(user);

var listOfObjects = [user,{name:"Josue", 
age: 23, 
spells: ["one", "two", "x"]}];
console.log(listOfObjects);

console.log(user.spells[1]);
console.log(listOfObjects[0].spells[1]);

console.log(listOfObjects[0].shout());
console.error("Error es una funcion de el objeto consola..");


// ---------------  BUILD BD ---------------

var database = 
[{
    username: "andrei",
    password: "supersecret"
}];

var newsFeed = 
[{
    username: "Bobby",
    timeline: "Si tired from alla that learning!"
},{
    username: "Sally",
    timeline: "Javascript is soooo coooool!"
}];

var userNamePrompt = prompt("What´s your name?");
var passwordPrompt = prompt("What´s your password?");

function signIn(user, passwrd){
    if (user === database[0].username && 
        passwrd === database[0].password){
            console.log(newsFeed);
        }else{
            alert("Sorry, wrong username and password!");
        }
}

signIn(userNamePrompt, passwordPrompt);

// Difference between a function and a method
//function
function thisIsAFunction(){

}
//call
thisIsAFunction();

//method
var method = {
    thisIsAMethod : function(){

    }
}
//call
method.thisIsAMethod();

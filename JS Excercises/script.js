function isUserValid(bool){
    return bool;
}

// Condiciones Ternarias ----------------------------
var answer = isUserValid(true) ? "You may enter" : "Acces denied";
var automatedAnswer = "Your account # is " + (isUserValid(false) ? "1234" : "not available");

console.log(answer);
console.log(automatedAnswer);

//Condición Normal ---------------------------------
function condition(){
    if (isUserValid(true)){
        return "You may enter";
    }else{
        return "Acces denied";
    }
}

var answer2 = condition();
console.log(answer2);

function multi(a, b){
    if (a > 10 || b > 10){
        return "Valor muy grande!";
    }else{
        return (a * b);
    }
}

var multiplica = multi(3, 7);
// alert(multiplica);

function checkDriverAge(){
    var age = prompt("What is your age?");

    if (Number(age) < 18) {
        alert("Sorry, you are too yound to drive this car. Powering off");
    } else if (Number(age) > 18) {
        alert("Powering On. Enjoy the ride!");
    } else if (Number(age) === 18) {
        alert("Congratulations on your first year of driving. Enjoy the ride!");
    }
}

// checkDriverAge();

var checkDriverAge2 = function(age){
    if (Number(age) < 18) {
        alert("Sorry, you are too yound to drive this car. Powering off");
    } else if (Number(age) > 18) {
        alert("Powering On. Enjoy the ride!");
    } else if (Number(age) === 18) {
        alert("Congratulations on your first year of driving. Enjoy the ride!");
    }
}

// checkDriverAge2(18);
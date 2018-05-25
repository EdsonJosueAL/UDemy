var database =
    [{
        username: "andrei",
        password: "supersecret"
    }, {
        username: "sally",
        password: "123"
    }, {
        username: "ingrid",
        password: "777"
    }];

var newsFeed =
    [{
        username: "Bobby",
        timeline: "Si tired from alla that learning!"
    }, {
        username: "Sally",
        timeline: "Javascript is soooo cool!"
    }, {
        username: "Mitch",
        timeline: "Javascript is pretyy cool!"
    }];

var userNamePrompt = prompt("What\'s your name?");
var passwordPrompt = prompt("What\'s your password?");

function isUserValid(user, passwrd) {
    for (var i = 0; i < database.length; i++) {
        if (database[i].username === user &&
            database[i].password === passwrd) {
            return true;
        }
    }
    return false;
}

function signIn(username, password) {
    if (isUserValid(username, password)) {
        console.log(newsFeed);
    } else {
        alert("Sorry, wrong username and password!")
    }
}

signIn(userNamePrompt, passwordPrompt);
// var button = document.getElementsByTagName("button")[0];

// button.addEventListener("click", function(){
//     console.log("click");
// })

// button.addEventListener("mouseenter", function(){
//     console.log("mouseenter");
// })

var buttonEnter = document.getElementById("enter");
var input = document.getElementById("userinput");
var ul = document.querySelector("ul");

function inputLength(){
    return (input.value.length);
}

function createListElement(){
    var li = document.createElement("li");
    var button = document.createElement("button");
    li.appendChild(document.createTextNode(input.value));
    li.classList = "done";
    button.appendChild(document.createTextNode("Delete"));
    button.className = "btnDelete";
    li.appendChild(button);
    ul.appendChild(li);
    input.value = "";
}

function addListAfterClick(){
    if (inputLength() > 0){
        createListElement();
    }
}

function addListAfterKeypress(event){
    if (inputLength() > 0 && event.keyCode === 13){
        createListElement();
    }
}

buttonEnter.addEventListener("click", addListAfterClick);
input.addEventListener("keypress", addListAfterKeypress);

$(document).ready(function(){

    $('.done').click(function(){
        $(this).toggleClass();
    });

    // No detectaba elementos añadidos con 'document.createElement'
    // $('.btnDelete').on("click", function(){
    //     $(this).parent().toggle();
    // });

    // Detecta los cliks del documento que tengan clase btnDelete
    $(document).on("click",".btnDelete", function(){
        $(this).parent().toggle();
    });

});

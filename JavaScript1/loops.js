var todos = [
    "clean room",
    "brush teeth",
    "exercise",
    "study javascript",
    "eat healthy"
];

// CICLO FOR
var todosLength = todos.length;
for (var i = 0; i < todosLength; i++){
    console.log(todos[i] + "!");
}
// CICLO FOREACH
todos.forEach(function(i){
    console.log(i);
})

// foreach con item e index, lo identifica siempre el 2 parámetro como el index
todos.forEach(function(todo, i){
    console.log(todo, i);
})

// llamado de función en foreach
function logTodos(todo, i){
    console.log(todo, i);
}
todos.forEach(logTodos);

// CICLO WHILE
var counterOne = 0;
while(counterOne < 10){
    console.log(counterOne);
    counterOne++;
}
// CICLO 
var counterTwo = 10;
do{
    console.log(counterTwo);
    counterTwo--;
}while(counterTwo > 0);
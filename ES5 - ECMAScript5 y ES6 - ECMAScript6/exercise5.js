console.log('Excercise 5');
// Complete the below questions using this array:
const arrayE5 = [
  {
    username: "john",
    team: "red",
    score: 5,
    items: ["ball", "book", "pen"]
  },
  {
    username: "becky",
    team: "blue",
    score: 10,
    items: ["tape", "backpack", "pen"]
  },
  {
    username: "susy",
    team: "red",
    score: 55,
    items: ["ball", "eraser", "pen"]
  },
  {
    username: "tyson",
    team: "green",
    score: 1,
    items: ["book", "pen"]
  },

];

const namesArray = [];
//Create an array using forEach that has all the usernames with a "!" to each of the usernames
const foreachArray = arrayE5.forEach(element => {
  namesArray.push(element.username + "!");
});
console.log('forEach', namesArray);

const namesArray2 = [];
const foreachArrayArrow = arrayE5.forEach(element => namesArray2.push(element.username + "!"));
console.log('forEach Arrow', namesArray2);

//Create an array using map that has all the usernames with a "? to each of the usernames
const namesArrayMap = arrayE5.map(element => {
  return element.username + "?";
});
const namesArrayMapArrow = arrayE5.map(element => element.username + "?");
console.log('map', namesArrayMap);
console.log('map Arrow', namesArrayMapArrow);

//Filter the array to only include users who are on team: red
const usersTeamRed = arrayE5.filter(element => {
  return element.team === "red";
});
const usersTeamRedArrow = arrayE5.filter(element => element.team === "red");
console.log('filter', usersTeamRed);
console.log('filter Arrow', usersTeamRedArrow);

//Find out the total score of all users using reduce
const usersTotalScore = arrayE5.reduce((total, element) => {
  return total + element.score;
}, 0);
const userTotalScoreArrow = arrayE5.reduce((total, element) => total + element.score, 0);
console.log('reduce', usersTotalScore);
console.log('reduce Arrow', userTotalScoreArrow);

// (1), what is the value of i? R= index value
// (2), Make this map function pure:
const arrayNum = [1, 2, 4, 5, 8, 9];
const newArrayE5 = arrayNum.map((num, i) => {
  console.log(num, i);
  alert(num);
  return num * 2;
})

const newArrayE5 = arrayNum.map((num, i) => {
  return num * 2;
})

//BONUS: create a new list with all user information, but add "!" to the end of each items they own.

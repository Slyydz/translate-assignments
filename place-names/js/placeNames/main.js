// Put your code here

const arrayTaco = [
  "Nashville", "Hong Kong", "The back yard", "Earth",
  "London", "The mall", "Ryman Auditorium", "The Great Wall of China"
]

console.log("All Place Names");

arrayTaco.forEach(element => {
  console.log(element);
});

console.log("");

// arrayTaco.forEach(element => {
//     if (element.startsWith("The")) {
//         console.log(element);
//     }
// });

const arrayTacoThe = arrayTaco.filter(test => test.startsWith("The"));

console.log(arrayTacoThe);

arrayTacoThe.forEach(theElem => {
  console.log(theElem);
});
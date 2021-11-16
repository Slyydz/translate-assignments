// Put your code here

console.log("Let's roll some dice, baby!");
console.log("---------------------------");

for (let i = 0; i < 10; i++) {
    const die1 = createDie(getRandomInt(1, 6))
    const die2 = createDie(getRandomInt(1, 6))

    let message = `${die1.roll} + ${die2.roll} == ${die1.value + die2.value}`;
    if (die1.value == die2.value) {
        message += " DOUBLES!";
    }

    console.log(message);

}

function getRandomInt(min, max) {
    min = Math.ceil(min);
    max = Math.floor(max);
    return Math.floor(Math.random() * (max - min + 1)) + min;
}

function createDie(value) {

    return {
        value,
        roll: tacoRun(value)
    };

}


function tacoRun(input) {

    let dieString = "undefined";

    switch (input) {
        case 1:
            dieString = "one"; // These \uXXXX values are fancy unicode characters
            break;
        case 2:
            dieString = "two";
            break;
        case 3:
            dieString = "three";
            break;
        case 4:
            dieString = "four";
            break;
        case 5:
            dieString = "five";
            break;
        case 6:
            dieString = "six";
            break;
    }

    return dieString;
}
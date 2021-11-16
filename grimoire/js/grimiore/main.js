// Put your code here

console.log("Do you believe in magic?");
console.log("------------------------");

const allSpells = getAllSpells();


const goodTaco = MakeGoodSpellBook(allSpells);
const evilTaco = MakeEvilSpellBook(allSpells);

DisplaySpellBook(goodTaco);
console.log("");
DisplaySpellBook(evilTaco);

function DisplaySpellBook(book) {
    console.log(book.title);
    (book.spells).forEach(element => {
        console.log(`${element.Name}`);
        console.log(`Energy Required: ${element.EnergyReqired}`)
        console.log(`----`);
    });
}

function MakeEvilSpellBook(arrayInput) {
    evilBook = {
        title: "Evil Book",
        spells: arrayInput.filter(taco => taco.IsEvil)
    }

    return evilBook;
}

function MakeGoodSpellBook(arrayInput) {
    goodBook = {
        title: "Good Book",
        spells: arrayInput.filter(taco => !taco.IsEvil)
    }

    return goodBook;
}

function getAllSpells() {

    spellsArray = [
        {
            Name: "Turn enemy into a newt",
            IsEvil: true,
            EnergyReqired: 5.1
        },
        {
            Name: "Conjure some gold for a local charity",
            IsEvil: false,
            EnergyReqired: 2.99
        },
        {
            Name: "Make yourself emperor of the universe",
            IsEvil: true,
            EnergyReqired: 100.0
        },
        {
            Name: "Convince your relatives your political views are correct",
            IsEvil: false,
            EnergyReqired: 2921.5
        }
    ]

    return spellsArray;
}
const Character = require("./character.js");
const Wizard = require("./wizard.js");

let myChar = new Character("Kung");
let otherChar = new Character("David");

console.log(myChar);
console.log(otherChar);
myChar.takeDamage(30);
console.log(myChar);
console.log(myChar.speak());
console.log(myChar.speak("Blah"));

let myWizard = new Wizard("Bob", "Ice Blast");
console.log(myWizard);
console.log(myWizard.cast());

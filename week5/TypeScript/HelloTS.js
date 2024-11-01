// Some TS data types
let age = 34;
let myUserName = "Alice";
let likesDogs = true;
function logMessage(message) {
    console.log(message);
}
//Null and Undefined
let nothing = null; // variable with NO value
let undef = undefined; // declared but value is not assigned
// Array, we can declare it in 2 ways
// Type[] and Array<Type>
let myNumbers = [1, 2, 3, 4, 5];
let fruits = ["apple", "orange"];
// Object
let person = {
    name: "Alice",
    age: 34
};
// Unions - allow variable to hold multiple types
let myValue;
myValue = "I am a person"; // valid
//myValue = "I am not a person, I am a robot";
myValue = 54; // valid
myValue = true; // not Valid
console.log(myValue);
function returnMyString(name) {
    return name;
}
console.log(returnMyString("Vlada"));

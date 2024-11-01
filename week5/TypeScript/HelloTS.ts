// Some TS data types

let age: number = 34; 
let myUserName: string = "Alice";
let likesDogs: boolean = true;


function logMessage(message:string): void {
    console.log(message);
}

//Null and Undefined

let nothing: null = null; // variable with NO value
let undef: undefined = undefined; // declared but value is not assigned

// Array, we can declare it in 2 ways
// Type[] and Array<Type>

let myNumbers: number[] = [1,2,3,4,5];
let fruits: string[] = ["apple", "orange"];


// Object

let person: {name:string, age:number} ={
    name: "Alice",
    age: 34
}

// Unions - allow variable to hold multiple types

let myValue: string | number | boolean;
myValue = "I am a person"; // valid
//myValue = "I am not a person, I am a robot";

myValue = 54;  // valid
myValue = true; // not Valid

console.log(myValue);

function returnMyString(name:string):string{
    return name;
}

console.log(returnMyString("Vlada"));


// To compile ts to hs run: tsc FileName.ts
// If you want to have different JS version use tsc FileName.ts --target "ES6"
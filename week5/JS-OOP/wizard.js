const Character = require("./character.js");

class Wizard extends Character {
    #mp;
    #spell;

    constructor(name, spell) {
        super(name);
        this.#spell = spell;
        this.#mp = 10; 
    }

    getMp() {
        return this.#mp;
    }

    cast() {
        this.#mp--;
        return `I am using ${this.#spell} and I have ${this.#mp} mp left`
    }
}

module.exports = Wizard;
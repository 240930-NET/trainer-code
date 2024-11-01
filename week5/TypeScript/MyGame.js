var Choice;
(function (Choice) {
    Choice["Rock"] = "rock";
    Choice["Paper"] = "paper";
    Choice["Scissors"] = "scissors";
})(Choice || (Choice = {}));
// Computer's choice
function getComputerChoice() {
    const choice = [Choice.Rock, Choice.Paper, Choice.Scissors];
    const randomIndex = Math.floor(Math.random() * choice.length);
    return choice[randomIndex];
}
//Determine a winner
function getWinner(computerChoice, playerChoice) {
    if (computerChoice === playerChoice) {
        return "It's a tie!";
    }
    else if (playerChoice == Choice.Rock && computerChoice == Choice.Scissors ||
        playerChoice == Choice.Paper && computerChoice == Choice.Rock ||
        playerChoice == Choice.Scissors && computerChoice == Choice.Paper) {
        return "You win!";
    }
    else {
        return "You lose!";
    }
}
// Launch a game
function playGame(playerChoice) {
    //Get choice from computer
    let computerChoice = getComputerChoice();
    console.log("You selected: " + playerChoice);
    console.log("Computer selected: " + computerChoice);
    console.log(getWinner(computerChoice, playerChoice));
}
playGame(Choice.Rock);

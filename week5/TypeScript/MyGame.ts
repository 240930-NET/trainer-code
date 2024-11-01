
enum Choice {

    Rock = "rock",
    Paper = "paper",
    Scissors = "scissors"
}

// Computer's choice
function getComputerChoice(): Choice{

    const choice = [Choice.Rock, Choice.Paper, Choice.Scissors];
    const randomIndex = Math.floor(Math.random() * choice.length); 
    return choice[randomIndex];

}

//Determine a winner
function getWinner(computerChoice:Choice, playerChoice:Choice) :string{

    if(computerChoice === playerChoice){
        return "It's a tie!";
    }
    else if(
        playerChoice == Choice.Rock && computerChoice == Choice.Scissors ||
        playerChoice == Choice.Paper && computerChoice == Choice.Rock ||
        playerChoice == Choice.Scissors && computerChoice == Choice.Paper
    )
    {
        return "You win!";
    }
    else{
        return "You lose!";
    }

}

// Launch a game
function playGame(playerChoice: Choice) :void{

    //Get choice from computer
    let computerChoice:Choice = getComputerChoice();
    console.log("You selected: " + playerChoice);
    console.log("Computer selected: " + computerChoice);
    console.log(getWinner(computerChoice, playerChoice));

}

playGame(Choice.Rock);



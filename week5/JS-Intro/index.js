//https://developer.mozilla.org/en-US/docs/Glossary/IIFE
//Below if IIFE
// (function foo()
// {
//     console.log("Hello World!");
// })()

function clickHandler(e, name)
{
    console.log(e, name);
    e.stopPropagation();
}

function alertBox()
{
    alert("STOP!!!");
}

function newCat()
{
    let newImg = document.createElement('img');
    newImg.src = "https://cdn.pixabay.com/photo/2024/01/29/20/40/cat-8540772_1280.jpg";
    let el = document.getElementById('first-ul-item');
    el.appendChild(newImg);
}

const button4 = document.getElementById('button4');
button4.innerText = 'Hello';

button4.addEventListener('click', function(e) {
    e.stopPropagation();
    console.log("Button 4 was pressed");

    fetch('https://pokeapi.co/api/v2/pokemon/ditto', {
        method: 'GET'
    })
    .then(res => res.json())
    .then(resBody => console.log(resBody))
});
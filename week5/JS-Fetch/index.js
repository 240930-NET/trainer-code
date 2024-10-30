const apiURL = 'http://localhost:5222/api/'

async function getAllExpenseHandler() {
    const data = await fetch('http://localhost:5222/api/Expense');    
    const expensesJson = await data.json();
    
    let ul = document.createElement('ul');
    ul.id = 'expenseList';

    expensesJson.forEach((e) => {
        let li = document.createElement('li');
        li.innerText = JSON.stringify(e);
        ul.appendChild(li);
    });

    document.body.appendChild(ul);    
}

async function getAllUserHandler() {
    const data = await fetch('http://localhost:5222/api/User');    
    const expensesJson = await data.json();
    
    let ul = document.createElement('ul');
    ul.id = 'expenseList';

    expensesJson.forEach((e) => {
        let li = document.createElement('li');
        li.innerText = JSON.stringify(e);
        ul.appendChild(li);
    });

    document.body.appendChild(ul);    
}

const userForm = document.getElementById('addUserForm');

userForm.addEventListener('submit', function(event) {
    event.preventDefault();
    
    const user = {
        'firstName': event.target.elements['firstname'].value,
        'lastName': event.target.elements['lastname'].value
    };

    fetch('http://localhost:5222/api/User/AddNewUser', {
        method: 'POST',
        body: JSON.stringify(user),
        headers: {
            'Content-Type' : 'application/json'
        }
    })
    .then(res => console.log(res))
    .then(resJson => console.log(resJson))
});

const expenseForm = document.getElementById('addExpenseForm');

// expenseForm.addEventListener('submit', function(e)
// {
//     e.preventDefault();

//     const expense = {
//         "expenseId": 0,
//         "expenseName": e.target.elements['expenseName'].value,
//         "expenseAmount": e.target.elements['amount'].value,
//         "expenseDescription": e.target.elements['description'].value,
//         "userId": e.target.elements['userId'].value
//     }

//     fetch('http://localhost:5222/api/Expense', {
//         method: 'POST',
//         body: JSON.stringify(expense),
//         headers: {
//             'Content-Type' : 'application/json'
//         }
//     })
//     .then(res => console.log(res))
// });

function addExpenses(e)
{
    e.preventDefault();
    const expense = {
        "expenseId": 0,
        "expenseName": e.target.elements['expenseName'].value,
        "expenseAmount": e.target.elements['amount'].value,
        "expenseDescription": e.target.elements['description'].value,
        "userId": e.target.elements['userId'].value
    }

    fetch('http://localhost:5222/api/Expense', {
        method: 'POST',
        body: JSON.stringify(expense),
        headers: {
            'Content-Type' : 'application/json'
        }
    })
    .then(res => console.log(res))
}
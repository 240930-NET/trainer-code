import './App.css'
import Header from './components/Header'
import Home from './Home'

function App() {

  const currentUser = {
    username: "TestUser", 
    age:18, 
    email: "TestUser@gmail.com"
  }

  const UserList = [
    {username: "Vlada", age:45, email: "vlada@gmail.com"},
    {username: "Kung", age:46, email: "kung@gmail.com"},
    {username: "Gabriel", age:47, email: "gabriel@gmail.com"},
    {username: "Elton", age:48, email: "elton@gmail.com"}
  ]


  // This is an event handler for our <li> element
  const displayName = (e) => {
    e.preventDefault();
    alert(`Hello, ${e.target.textContent}!`)
  }

  return (
    <main>
        <Home username = {currentUser.username}/>
  
        <h4>Here is your user list:</h4>
        <ul>
        {
          UserList.map((user, index) => 
          <li key={index} onClick={displayName}>
            <strong>Name:</strong>{user.username}, 
            <strong>Age:</strong> {user.age}, 
            <strong>email:</strong> {user.email}
            </li>)
        }
        </ul>
    </main>
  )
}

export default App

import React, { Component } from 'react';
import './App.css'
import Header from './Header';

// Demo how class based set up would work in React
class App extends React.Component {

  constructor(props){
    super(props);

    this.state = {
      currentUser: {
        username: "TestUser", 
        age:18, 
        email: "TestUser@gmail.com"
      },

      UserList: [
        {username: "Vlada", age:45, email: "vlada@gmail.com"},
        {username: "Kung", age:46, email: "kung@gmail.com"},
        {username: "Gabriel", age:47, email: "gabriel@gmail.com"},
        {username: "Elton", age:48, email: "elton@gmail.com"}
      ]
    }
  }

  render(){

    const { currentUser, UserList } = this.state;

    return(
      <main>
        <Header username = {currentUser.username} age = {currentUser.age}/>
        <h5>Welcome {currentUser.username}</h5>
         <h4>Here is your user list:</h4>
         {
          UserList.map((user, index) => 
          <li key={index}>
            <strong>Name:</strong>{user.username}, 
            <strong>Age:</strong> {user.age}, 
            <strong>email:</strong> {user.email}
            </li>)
        }
      </main>
    )
  }
}

export default App

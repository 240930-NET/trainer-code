import { useState } from 'react'
import { useContext } from 'react';
import UserContext from './UserContext';
import Header from './components/Header';
import './App.css'

function App() {

  /*We need an array where we store our tasks*/
  const [taskList, setTaskList] = useState([]);

  // This variable holds value for a new task that suppose to be added to my list
  const [newTask, setNewTask] = useState('');

  const {username, setUsername} = useContext(UserContext);

  /*Add new Task*/
  const handleTaskAdding = (e) => {
    e.preventDefault();
    console.log("Test");
    //Update state for taskList
    if(newTask != ''){
      setTaskList([...taskList, newTask]);
      //Reset state for newTask
      setNewTask('');
    }

  
  }

  /*Remove Task*/
  const handleTaskRemoval = (index) => {
    // filter based on current index (do not inclide it to new array)
    const updatedTaskList = taskList.filter((_, i) => i !== index); 
    setTaskList(updatedTaskList);
  }


  return (
    <>
      <Header></Header>
      <h1>{username}'s To Do List</h1>
      <input type="text" placeholder='Enter your task...' value={newTask} onChange={(e) => {setNewTask(e.target.value)}} />
      <button type="submit" onClick={handleTaskAdding}>Add Task</button>
      {
        taskList.length > 0 ? 
        //<p>{taskList[0]}</p>
        
        taskList.map((task, index) => (
          <li key={index}>
            {task}
            <button onClick = {() => handleTaskRemoval(index)}>X</button>
          </li>
        ))
      
        : 
        " No tasks were found!"
      }
     

    </>
  )
}

export default App

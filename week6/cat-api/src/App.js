import logo from './logo.svg';
import './App.css';
import { useState, useEffect } from'react';

function App() {

  const[catJSON, setCatJSON] = useState(null);
  const [catImage, setCatImage] = useState("");

  const [userData, setUserData] = useState("My input");

  // Load a cat json data  when we render App component

  useEffect(() => {
    console.log("Hello World!")
    fetch("https://cataas.com/cat?json=true", {
      method:"GET",
      headers:{
        "Content-Type": "application/json"
      }
    })
    .then(response => response.json())
    .then(data => setCatJSON(data))
  }, []) // no dependencies, so it will execute only once


  // Fetch a cat image
  const handleKitty = async () => {

    // Test your input and validate it
    if(userData !== undefined &&  userData !== "Someting") {
      //Run your fetch here 
      try{
        const response = await fetch("https://cataas.com/cat", {
          method:"GET",
          headers:{
            "Accept": "image/jpeg"
          }
          
        }
      
      )

        if(response.ok){
          setCatImage(response.url);
        }

      }
      catch(err){
        console.error("Error fetching cat image:", err);
      }
    }

    
  }

  return (
    <div>
      <h1>My cat API</h1>
      <input type="text" placeholder='something' required value={userData} onChange={(e) => setUserData(e.target.value)}/>
      <button onClick={handleKitty}>Fetch a kitty</button>

      {
        catJSON != null ? catJSON.createdAt: null
      }
      <img src={catImage} alt={catImage}></img>
    </div>
  );
}

export default App;

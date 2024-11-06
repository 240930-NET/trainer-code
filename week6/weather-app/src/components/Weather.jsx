import { useState } from "react";
import Header from "./Header"
import { useParams } from "react-router-dom"
import "./Weather.css";

function Weather() {

    let { id } = useParams();
    const[cityname, setCityname] = useState("");

    const [formData, setFormData] = useState({
        cityname: "",
        username: "",
        email: ""
      });

    const [weatherData, setWeatherData] = useState(null);
      //onChange={() => setCityname(e.target.value)}

      const handleFormDataChange = (e) => {

        const { name, value } = e.target;
        setFormData({
            ...formData,
            [name]: value
        });
      }

    const handleFormSubmission = (e) => {

        e.preventDefault();
        //Here we are going to call our weather API
        const apiKEY= import.meta.env.VITE_SECRET_KEY;
        console.log(formData.cityname);
        if(formData.cityname != ''){

            fetch(`https://api.openweathermap.org/data/2.5/weather?appid=${apiKEY}&q=${formData.cityname}`, {
            })
            
            .then(res => {
                if(res.ok){
                    //console.log(res);
                    return res.json();
                }
                else{
                    console.log("Something went wrong");
                }
            })
            .then(data => {
                console.log(data);
                setWeatherData(data);
            }
            )
            
            .catch(err => {
                console.log(err);
            })
        }


    }

    return (
      <>
        <h1>Weather Page</h1>

        <form onSubmit={handleFormSubmission}>
            <label>City:</label>
            <input type="text" name="cityname" required value = {formData.cityname} onChange={handleFormDataChange}></input>
            <label>Username:</label>
            <input type ="text"name="username" value={formData.username}  onChange={handleFormDataChange}></input>
            <label>Email:</label>
            <input type ="email"name="email" value={formData.email}  onChange={handleFormDataChange}></input>
            <input type="submit" value="Submit" />
        
        </form>

        <div>
            {weatherData != null ? 

            <div id="ouput_container">   
                <h1>Weather in {weatherData.name}:</h1>
                <h4>Weather is {weatherData.main.temp}:</h4>
                <h4>Feels like {weatherData.main.feels_like}:</h4>
            </div>


            : 
                ""
            }
        </div>
      </>
    )
  }
  
  export default Weather
  
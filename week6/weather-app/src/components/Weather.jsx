import Header from "./Header"
import { useParams } from "react-router-dom"

function Weather() {

    let { id } = useParams();
    
    return (
      <>
        <Header />
        <h1>Weather Page, id {id}</h1>

      </>
    )
  }
  
  export default Weather
  
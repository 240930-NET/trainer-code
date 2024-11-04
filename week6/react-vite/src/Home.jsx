
import Header from "./components/Header";

const Home = (props) => {
    return (
        <div>
            <Header username = {props.username}/>
           <h3>This is me! Your Home Page!</h3>
        </div>

    )
}

export default Home;
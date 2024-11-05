import './HeaderStyle.css';
import UserData from './UserData';
import { useState, useContext } from 'react'
import UserContext from '../UserContext';



const Header = () => {

    const[logStatus, setLogStatus] = useState(false);
    const { username, setUsername } = useContext(UserContext);

    const handleLogin = () => {

        if(logStatus){
            setUsername('Anon');
        }
        else{
            setUsername('Vlada');
        }

        setLogStatus(!logStatus);
    }

    return(
        <header>
            <h5>ToDoList App</h5>
            {/* Add our UserData Component*/}
            <UserData />
            <nav>
                <ul>
                    <li>Home</li>
                    <li>About</li>
                </ul>
            </nav>

            <button onClick={handleLogin}>{logStatus ? "Logout": "Login"}</button>
        </header>
    )
}

export default Header;
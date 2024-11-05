import {useContext} from 'react';
import UserContext from '../UserContext';

const UserData = () => {

    const {username, setUsername} = useContext(UserContext);
    return(
        <h3>Welcome, {username}</h3>
    )
}

export default UserData;
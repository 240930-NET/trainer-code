import { createContext, useState } from "react";


const UserContext = createContext(null);

export const UserProvider = ({children}) => {

    const [username, setUsername] = useState("Anon"); // initial state for our username

    return(
        <UserContext.Provider value={{username, setUsername}}>
            {children}
        </UserContext.Provider>
    )
}

export default UserContext;
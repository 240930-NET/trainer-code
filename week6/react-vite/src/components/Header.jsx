import "../styles/Header.css";


const Header = (props) => {

    return(
        <header>
            Hello {props.username}, you are {props.age}! 

            <nav>
                <ul>
                    <li>Home</li>
                    <li>About</li>
                    <li>Contact</li>
                    <li>Portfolio</li>
                </ul>
            </nav>
            
        </header>
    )
}

export default Header;
import React, { Component } from 'react';


class Header extends React.Component {
    render(){
        return(
            <header>
            Hello {this.props.username}
            <nav>
                <ul>
                    <li>Home</li>
                    <li>About</li>
                    <li>Contact</li>
                    <li>Portfolio</li>
                </ul>
            </nav>
            
        </header>
        );
    }
}

export default Header;
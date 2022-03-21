import './Nav.css';
import React from 'react';
import {Link} from "react-router-dom";

export default function Nav(){
    return (
        <div className='Nav'>
            <Link to="/">root</Link>
            <Link to="/login">login</Link>
            <Link to="/board">board</Link>
            <Link to="/info">info</Link>
        </div>
    );
}
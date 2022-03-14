import React, { useState } from 'react';

export default function Counter(props){

    const [myval,setMyval] = useState(parseInt(props.myval));

    function decrease(){
        // document.getElementById("myval").innerHTML = myval;
        let val = myval-1;
        setMyval(val);
    }
    function increase(){
        let val = myval+1;
        setMyval(val);
    }
    return (
        <div className="d-flex m-5">
            <button onClick={decrease} className="w-btn w-btn-brown">-</button>
            <span id="myval" className="m-5">{myval}</span>
            <button onClick={increase} className="w-btn w-btn-brown">+</button>
        </div>
    )
}
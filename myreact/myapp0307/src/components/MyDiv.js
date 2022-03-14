import React, { useState } from 'react';

export default function MyDiv(props){
    const [myval,setMyval] = useState(props.b);
    function myvalChange(){
        setMyval(parseInt(myval)+1);
    }
    return ( 
        <div>
            <h1>Mydiv {props.a}</h1>
            <h5>{props.b}</h5>
            {/* <h3>{this.state.a}</h3> */}
            <button className='btn btn-primary' onClick={myvalChange}>{myval}</button>
        </div> 
    );
}

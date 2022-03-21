import './BB.css'
import React, { useState } from 'react';


export default function BB(){
    const [h2val,setH2val] = useState(10);
    const [inputval,setInputVal] = useState('');
    function doChange(e){
        setH2val(h2val+1);
        setInputVal(e.target.value);
    }
    return(
        <div>
            <input onChange={doChange}/>
            <h2>{h2val}</h2>
            <h2>{inputval}</h2>
            <button className='btn'>input값바꾸기</button>            
        </div>
    )
}
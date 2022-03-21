import React, { useState } from 'react';

export default function AA(){
    const [aa,setAa] = useState('aaa');
    function doA(){
        aa === "aaa"? setAa("bbb"):setAa("aaa");
    }
    return(
        <div>
            <h1>{aa}</h1>
            <button onClick={doA}>값바꾸기</button>
        </div>
    )
}
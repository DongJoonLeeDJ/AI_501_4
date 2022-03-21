import React, { useState } from 'react';

export default function AA(props){
    // console.log(props);
    let iaa = props.aa;
    const [aa,setAa] = useState(iaa);
    function doA(){
        aa === iaa? setAa("bbb"):setAa(iaa);
    }
    return(
        <div>
            <h1>{aa}</h1>
            <button onClick={doA}>값바꾸기</button>
        </div>
    )
}
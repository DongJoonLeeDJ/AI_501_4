import './BoardInsert.css'
import { useNavigate } from "react-router-dom";

export default function BoardInsert(){
    const navigate = useNavigate();

    const url ="http://localhost:3001/boards"
    const requestOptions = {
        method: 'post',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify({ 
            id:9,
            title:"newtitle",
            hit : 1
        })
    };

    const dosubmit = e=>{
        e.preventDefault();
        fetch(url, requestOptions)
        .then( 
            navigate('/board', { replace: true })
        )
    }
    return (<div>
        <form onSubmit={dosubmit}>
            <input type="submit" value="글쓰기"/>
        </form>
    </div>)
}
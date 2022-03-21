import './Board.css'
import { useEffect, useState } from "react"
import { Link } from 'react-router-dom';
// import data from '../data/data.json';

export default function Board(){
    const url = "http://localhost:3001/boards";
    const [boards,setBoards] = useState([]);

    useEffect(()=>{
        fetch(url)
        .then(res=>res.json())
        .then(resJson=>setBoards(resJson))
    },[url])
                
    const trtags = boards.map((board)=>{
        return (
            <tr key={board.id}>
                <td>{board.id}</td>
                <td>{board.title}</td>
                <td>{board.hit}</td>
            </tr>
            )
        }
    )

    if(boards.length === 0)
        return (<div style={{height:'400px',backgroundColor:'#eee'}}>loding...</div>)
    
    return (
    <div>
        <table>
            <thead>
            <tr>
                <th>순번</th>
                <th>제목</th>
                <th>조회수</th>
            </tr>
            </thead>
            <tbody>
            {trtags}
            </tbody>
        </table>
        <Link to="/boardInsert">글쓰기</Link>
    </div>)
}
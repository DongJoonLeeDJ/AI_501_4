import './App.css';
import TodoListTemplate from './components/TodoListTemplate.js'
import Form from './components/Form.js'
import TodoItemList from './components/TodoItemList';
// import MyCom from './components/MyCom.js'
import React, { useState } from 'react';

function App() {
  const [id,setId] = useState(3); // 이미 0,1,2 가 존재하므로 3으로 설정

  const [input,setInput] = useState('')
  const [todos,setTodos] = useState(
    [
      { id: 0, text: ' 리액트 소개', checked: false },
      { id: 1, text: ' 리액트 소개', checked: true },
      { id: 2, text: ' 리액트 소개', checked: false }
    ]
  )

  const handleChange = (e)=>{
    this.setState({ input : e.target.value} )
  }

  return (
    <div>
      <TodoListTemplate form={<Form/>}>
        <TodoItemList/>
      </TodoListTemplate>
    </div>
  );
}

export default App;

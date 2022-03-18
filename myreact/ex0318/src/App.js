import './App.css';
import TodoListTemplate from './components/TodoListTemplate.js'
import Form from './components/Form.js'
import TodoItemList from './components/TodoItemList';
// import MyCom from './components/MyCom.js'
import React, { useState } from 'react';

function App() {
  const [id,setId] = useState(3);
  const [input,setInput] = useState('');
  const [todos,setTodos] = useState([
    { id: 0, text: ' 리액트 소개', checked: false },
    { id: 1, text: ' 리액트 소개', checked: true },
    { id: 2, text: ' 리액트 소개', checked: false }
  ]);

  const handleCreate = ()=>{
    console.log('추가')
    setId(id+1);
    setTodos([...todos,
      { id: id, text: input, checked: false }
    ])
    setInput('');
    console.log(todos);
  }
  const handleKeyPress = (e) => {
    // 눌려진 키가 Enter 면 handleCreate 호출
    if(e.key === 'Enter') {
      handleCreate();
    }
  }
  const handleChange = (e)=>{
    console.log(e);
    console.log(e.target.value);
    setInput(e.target.value);
  }

  return (
    <div>
      <TodoListTemplate form={<Form 
                  value={input} 
                  onChange={handleChange}
                  onKeyPress={handleKeyPress}
                  onCreate={handleCreate}/>}>
        <TodoItemList todos={todos}/>
      </TodoListTemplate>
    </div>
  );
}

export default App;

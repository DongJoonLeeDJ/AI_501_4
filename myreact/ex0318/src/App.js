import './App.css';
import TodoListTemplate from './components/TodoListTemplate.js'
import Form from './components/Form.js'
import TodoItemList from './components/TodoItemList';
// import MyCom from './components/MyCom.js'

function App() {
  return (
    <div>
      <TodoListTemplate form={<Form/>}>
        <TodoItemList/>
      </TodoListTemplate>
    </div>
  );
}

export default App;


import './App.css';
import './css/bootstrap.css'
import MyHeader from "./component/MyHeader";
import Counter from "./component/Counter";

function App() {
  return (
    <div className="App">
      <div className="App-header">
        <MyHeader/>
        <Counter myval="10"/>
        <Counter myval="3"/>
        <Counter myval="2"/>
        <Counter myval="7"/>
      </div>
    </div>
  );
}

export default App;

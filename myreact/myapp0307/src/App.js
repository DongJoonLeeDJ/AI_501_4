import './App.css';
import './css/bootstrap.css';
import MyDiv from './components/MyDiv';

function App() {
  return (
    <div className="App">
      <MyDiv a="aa" b="3"/>
      <MyDiv a="bb" b="5"/>
      <MyDiv a="cc" b="7"/>
      <MyDiv a="dd" b="9"/>
      <MyDiv a="ee" b="11"/>
    </div>
  );
}

export default App;

import './App.css';
import AA from './components/AA'
import BB from './components/BB'
import CC from './components/CC'

function App() {
  
  return (
    <div className="App">
      <h1>AA 컴포넌트 사용</h1>
      <AA aa="aa"/>
      <AA aa="bb"/>
      <AA aa="cc"/>
      <hr/>
      <h1>BB 컴포넌트 사용</h1>
      <BB/>
      <BB/>
      <hr/>
      <h1>CC 컴포넌트 사용</h1>
      <CC/>
      <CC/>
    </div>

  );
}

export default App;

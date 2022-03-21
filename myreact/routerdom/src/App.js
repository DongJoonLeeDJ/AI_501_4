import './App.css';
import Nav from './components/Nav';
import Root from './components/Root';
import Board from './components/Board';
import Login from './components/Login';
import Info from './components/Info';

import {BrowserRouter, Routes, Route} from "react-router-dom";
import BoardInsert from './components/BoardInsert';

function App() {
  return (
    <BrowserRouter>
      <div className="App">
        <Nav/>
        <div className='Container'>
          <Routes>
            <Route exact path="/" element={<Root />} />
            <Route exact path="/login" element={<Login />} />
            <Route exact path="/board" element={<Board />} />
            <Route exact path="/boardInsert" element={<BoardInsert />} />
            <Route exact path="/info" element={<Info />} />
          </Routes>
          <div>
            <p>
              My Name is Hong gil dong<br/>
              Daegu Center<br/>
              &copy; KB
            </p>
          </div>
        </div>
      </div>
    </BrowserRouter>
  );
}

export default App;

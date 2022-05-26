import './App.css';
import {Container,Row,Col} from 'react-bootstrap';
import {NavEle} from './structure/NavEle.js';
import {BrowserRouter as Router,Routes,Route} from 'react-router-dom';
import {Root} from './components/Root.js';
import {Home} from './components/Home.js';
import {Link} from './components/Link.js';


function App() {
  // / /Home /Link
  return (
    <div className="App">
    <Router>
      <NavEle/>
      <Container style={{ backgroundColor:'#aaa', fontSize:'1.5rem' }}>
        <Row>
          <Col>딥러닝이미지분류</Col>
        </Row>
      </Container>
      <Routes>
        <Route exact path='/' element={<Root/>}/>
        <Route exact path='/Home' element={<Home/>}/>
        <Route exact path='/Link' element={<Link/>}/>
      </Routes>
    </Router>
    </div>
  );
}

export default App;

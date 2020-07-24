import React, { useReducer } from 'react';
import './App.css';
import Menucito from './components/Menucito';
import {
  BrowserRouter as Router,
  Switch,
  Route,
  Link
} from "react-router-dom";
import Productos from './components/Producto';



function App() {





  return (
    <div className="App">
        <Router>
      <div>
        <nav>
          <ul>
            <li>
              <Link to="/">Home</Link>
            </li>
            <li>
              <Link to="/productos">Productos</Link>
            </li>
            <li>
              <Link to="/users">Algo</Link>
            </li>
          </ul>
        </nav>

        {/* A <Switch> looks through its children <Route>s and
            renders the first one that matches the current URL. */}
        <Switch>
          <Route path="/productos">

            <Productos />
          </Route>
          <Route path="/users">
          
          
          </Route>
          <Route path="/">
          <Menucito />
          </Route>
        </Switch>
      </div>
    </Router>
    </div>
  );
}

export default App;

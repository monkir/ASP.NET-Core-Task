import logo from './logo.svg';
import './App.css';
import ViewLogStatus from './viewlogstatus';
import AdLogstatus from './adlogstatus';
import { BrowserRouter, Route, Routes } from 'react-router-dom';

function App() {
  return (
      <BrowserRouter>
        <Routes>
          <Route path='ad-log-status' element={<AdLogstatus/>}/>
          <Route path='view-log-status' element={<ViewLogStatus/>}/>
        </Routes>
      </BrowserRouter>
  );
}

export default App;

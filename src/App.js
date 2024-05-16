import { BrowserRouter, Routes, Route } from "react-router-dom";
import Home from './Home/Home.js';
import DayPlanner from "./DayToDay/DayPlanner.js";

export default function App() 
{
  return (
  <BrowserRouter>
    <Routes>
    
        <Route path="/" element={<Home />}/>
        <Route path="dayPlanner" element={<DayPlanner />}/>
    </Routes>
  </BrowserRouter>)
}


import { Link } from "react-router-dom";
import '../App.css';
import { useState } from 'react';
import Activity from "./Activity";

function DayPlanner()
{   
    const [name, setName] = useState([]);
    const [activity, setActivity]= useState("");
    const [day, setDay]  = useState("");
    const [startTime , setStartTime] = useState("");
    const [endTime, setEndTime] = useState("");
    const [breakTime, setBreatTime] = useState("");
    
    const postDayPlanner =  (event) => {
        event.preventDefault();
       fetch('https://localhost:7276/api/DayPlanners', {
            method: 'POST',
            body: JSON.stringify({
                'activity' :activity, 
                'day' : day,
                'startTime' : startTime,
                'endTime' : endTime,
                'breakTime': breakTime,
                'userId': 1
            }),
            headers: {
                'Content-type': 'application/json;',
              },
          })
          .then((response) => printSuccess(response))
          .catch((error) => alert("Activity Not Added") )
         

          
    }
    async function getDayPlanner(event) {
        event.preventDefault();
        try{
   const response = await fetch('https://localhost:7276/api/DayPlanners');
   setName(await response.json())
   
        }
        catch(error)
        {
 
                console.error('Error fetching data:', error);
              
        }

          
    }

    function printSuccess (response){
    
        alert("Activity Added Successfully !");
       console.log(response.json());
    
   }
  return (
  <>
  <ul>
        <li><Link className="" to="/">Home</Link></li>
        <li><Link to="#news">News</Link></li>
        <li><Link to="#contact">Contact</Link></li>
        <li><Link to="#about">About</Link></li>
      </ul>
  <h1>Day Planner</h1>

  <form onSubmit={postDayPlanner}>
     <input type="text" placeholder="Enter Activity" value={activity} onChange={(e) => setActivity(e.target.value)}></input>
     <input type="text" placeholder="Enter Day" value={day} onChange={(e) => setDay(e.target.value)}></input>
     <input type="text" placeholder="Enter Start Time (e.g 9:00 am)" value={startTime} onChange={(e) => setStartTime(e.target.value)}></input>
     <input type="text" placeholder="Enter End Time (e.g 12:00pm)" value={endTime} onChange={(e) => setEndTime(e.target.value)}></input>
     <input type="text" placeholder="Enter Break Time (e.g 1 hour)" value={breakTime} onChange={(e) => setBreatTime(e.target.value)}></input>
     <input type="submit" value="Create DayPlanner"/>
  </form>
 
  <Activity data={name}/>
  <button onClick={getDayPlanner}>View Day Planner</button>
  </>)
}

export default DayPlanner;
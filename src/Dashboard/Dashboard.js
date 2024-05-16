import '../Dashboard/DashboardStyle.css'
import { Link } from 'react-router-dom';
function Dashboard() {
    return (
        <>
        <h1>Your Dashboard</h1>
        <Link className="daytoday" to="dayPlanner">
            <h3>DayToDay</h3>
        </Link>
        <Link className="interactiveGames">
            <h3>Interactive Games </h3>
        </Link>
        <Link className="reminder">
            <h3>Reminder</h3>
        </Link>
        <Link className="chilltime">
            <h3>ChillTime</h3>
        </Link>
        <Link className="worktime">
             <h3>Work Time</h3>
        </Link>
        </>
      );
    
  }

  export default Dashboard;
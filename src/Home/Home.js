import Dashboard from '../Dashboard/Dashboard';
import '../Footer.css'
import { Link } from 'react-router-dom';
function Home() {
    return (
        <>
      <ul>
        <li><Link className="active" to="/">Home</Link></li>
        <li><Link to="#news">News</Link></li>
        <li><Link to="#contact">Contact</Link></li>
        <li><Link to="#about">About</Link></li>
      </ul>
        <Dashboard/>
        <footer >&copy</footer>
        </>
      );
    
  }
  
  export default Home;
  
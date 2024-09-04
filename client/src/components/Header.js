import React from 'react';
import {Link} from "react-router-dom";

function Header() {
  return (
    <header className="App-header">
      <nav>
        <div className="logo">AnyRoom</div>
        <ul>
          <li><Link to="/">Home</Link></li>
          <li><Link to="/services">Services</Link></li>
          <li><Link to="/register">Register User</Link></li>
          <li><Link to="/contact">Contact</Link></li>
        </ul>
      </nav>
    </header>
  );
}

export default Header;

import React from 'react';

function HeroSection() {
  return (
    <section className="hero">
      <h1>Anyroom, a place for everyone!</h1>
      <p>Find the right place for you and your family, where your comfort is our goal!</p>
      <form className="search-bar">
        <input type="text" placeholder="Search for a destination..." />
        <button type="submit">Search</button>
      </form>
    </section>
  );
}

export default HeroSection;

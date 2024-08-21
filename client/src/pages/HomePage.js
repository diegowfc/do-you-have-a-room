import React from 'react';
import Header from '../components/Header';
import HeroSection from '../components/HeroSection';
import HeroSectionCard from '../components/HeroSectionCard';
import Footer from '../components/Footer';
import { myImage1, myImage2, myImage3 } from '../assets/images';
import '../App.css';

function HomePage() {
  return (
    <>
      <Header />
      <main>
        <HeroSection />
        <section className="featured-hotels">
          <h2>Featured Hotels</h2>
          <div className="hotel-cards">
            <HeroSectionCard image={myImage1} name="Hotel Sunshine" price="$99" />
            <HeroSectionCard image={myImage2} name="Seaside Resort" price="$129" />
            <HeroSectionCard image={myImage3} name="Mountain Retreat" price="$149" />
          </div>
        </section>
      </main>
      <Footer />
    </>
  );
}

export default HomePage;

import React from 'react';

function HeroSectionCard({ image, name, price }) {
  return (
    <div className="hotel-card">
      <img src={image} alt={name} />
      <h3>{name}</h3>
      <p>{price} per night</p>
    </div>
  );
}

export default HeroSectionCard;

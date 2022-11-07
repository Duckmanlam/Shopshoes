import React from "react";
import "../../scss/component/PageShop/RangePrice.scss";
export default function RangePrice({ value, handleChange }) {
  return (
    <div>
      <div className="Shop__wrapper">
        <header className="heading">
          <h2 className="title">Price</h2>
        </header>
        <div className="price-input">
          <div className="field">
            <input type="number" className="input-min" placeholder="" />
          </div>
          <div className="separator">-</div>
          <div className="field">
            <input type="number" className="input-max" placeholder="" />
          </div>
        </div>
        <div className="slider">
          <div className="progess"></div>
        </div>
        <div className="range-input">
          <input type="range" className="range-min" min="0" max="10000" />
          <input type="range" className="range-max" min="0" max="10000" />
        </div>
      </div>
    </div>
  );
}

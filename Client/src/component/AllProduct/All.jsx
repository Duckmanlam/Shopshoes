import React from "react";
import { Link } from "react-router-dom";
import "../../scss/component/PageShop/responsive.css";
import Arrow from "../../assets/font/Arrow.js";
import "../../scss/component/PageShop/Shop.scss";
import RangePrice from "../PageShop/RangePrice";

export default function All() {
  return (
    <div className="Shop">
      <div className="grid wide">
        <div className="row">
          <div className="col l-3 m-12 c-12">
            <h1 className="Shop__heading">All Products (531)</h1>
            <p className="Shop__categories">Categories</p>
            <ul className="Shop__categories-list">
              <li className="Shop__categories-item">
                <Link to="#" className="Shop__categories-link">
                  Shoes (321)
                </Link>
              </li>
              <li className="Shop__categories-item">
                <Link to="#" className="Shop__categories-link">
                  Clothing (75)
                </Link>
              </li>
              <li className="Shop__categories-item">
                <Link to="#" className="Shop__categories-link">
                  Accessoris (135)
                </Link>
              </li>
            </ul>
            <RangePrice />
          </div>
          <div className="col l-9 m-12 c-12 Shop__product">
            <div className="Shop__product-sort">
              <span className="Shop__product-sort-name">Sort by</span>
              <Arrow />
            </div>
          </div>
        </div>
      </div>
    </div>
  );
}

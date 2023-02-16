import React, { useState } from "react";
import { Link, NavLink } from "react-router-dom";
import "../../scss/component/homepage/Heder.scss";
import Search from "../../assets/img/search.png";
import Vector from "../../assets/img/Vector.png";
import Nabar from "../../assets/img/nabar.png";
import { cartState } from "../../features/cart/cartState";
import { useRecoilValue } from "recoil";

export default function Heder() {
  const [search, setSearch] = useState("");
  const cart = useRecoilValue(cartState);
  const [hideSearch, setHideSearch] = useState(false);

  const handleSearch = () => {
    setSearch("");
  };

  const checkUser = localStorage.getItem("accessToken");
  const User = JSON.parse(checkUser);
  return (
    <div>
      <div className="Heder">
        <Link to="/" className="Heder_logo">
          Shoppes
        </Link>
        <div className="menu-mobile-icon hide-on-pc">
          <img className="menu-mobile-icon-1" src={Nabar} alt="" />
        </div>

        <div className="Heder_list hide-on-mobile">
          <NavLink className="Heder_list_item" to="/">
            Home
          </NavLink>
          <NavLink className="Heder_list_item" to="/PageShop">
            Product
          </NavLink>
          <NavLink className="Heder_list_item" to="/Blog">
            Blog
          </NavLink>
          {User?.role ? (
            <NavLink className="Heder_list_item" to="/Admin">
              Admin
            </NavLink>
          ) : null}
        </div>
        <div className="Heder_list2 hide-on-mobile">
          <Link
            className="Heder_list2-link"
            onClick={() => setHideSearch(!hideSearch)}
          >
            <img className="Heder_list2_img1 icon_mobile" src={Search} alt="" />
            <p className="Heder_list2_a">Search</p>
          </Link>
          <div className="Heder_list2-search">
            {hideSearch && (
              <div className="Heder_list2-search-box">
                <input
                  value={search}
                  type="text"
                  placeholder="Enter..."
                  onChange={(e) => {
                    setSearch(e.target.value);
                  }}
                />
                <Link
                  to={search && `PageShop/${search}`}
                  onClick={handleSearch}
                >
                  Ok
                </Link>
              </div>
            )}
          </div>

          <div className="Heder_list2_line"></div>

          {User ? (
            <Link
              to="/"
              className="Heder_list2_a1"
              onClick={() => {
                localStorage.removeItem("accessToken");
                window.location.reload();
              }}
            >
              {" "}
              Log out
            </Link>
          ) : (
            <Link to="/login" className="Heder_list2_a1">
              {" "}
              Log in
            </Link>
          )}
          <NavLink className="Heder_list_item" to="/Carts">
            <img className="Heder_list2_img" src={Vector} alt="" />
            {cart.length > 0 ? <span>{cart.length}</span> : ""}
          </NavLink>
        </div>
      </div>
    </div>
  );
}

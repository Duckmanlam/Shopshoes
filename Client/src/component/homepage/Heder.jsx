import React, { useState } from "react";
import { Link, NavLink } from 'react-router-dom'
import "../../scss/component/homepage/Heder.scss";
import Search from "../../assets/img/search.png";
import Vector from "../../assets/img/Vector.png";
import Nabar from "../../assets/img/nabar.png";
import { useRef } from "react";

export default function Heder() {
  const [search, setSearch] = useState('')
  const [hideSearch, setHideSearch] = useState(false)

  const inputRef = useRef()

  const handleSearch = () => {
    setSearch('')
    inputRef.current.focus()
  }

  const checkUser = localStorage.getItem('accessToken')
  return (
    <div>
      <div className="Heder">
        <Link to="/" className="Heder_logo">Shoppes</Link>
        <div className="menu-mobile-icon hide-on-pc">
          <img className="menu-mobile-icon-1" src={Nabar} alt="" />
        </div>
        <div className="Heder_list hide-on-mobile">
          <NavLink className="Heder_list_item" to="/">Home</NavLink>
          <NavLink className="Heder_list_item" to="/PageShop">Product</NavLink>
          {/* <NavLink className="Heder_list_item" to="/DetailBlog">Details </NavLink> */}
          <NavLink className="Heder_list_item" to="/Blog">Blog</NavLink>
        </div>
        <div className="Heder_list2 hide-on-mobile">
          <Link
            className="Heder_list2-link"
            onClick={() => setHideSearch(!hideSearch)}
          >
            <img
              className="Heder_list2_img1 icon_mobile"
              src={Search}
              alt=""
            />
            <p className="Heder_list2_a">
              Search
            </p>
          </Link>
          <div className="Heder_list2-search" >
            {hideSearch &&
              <div className="Heder_list2-search-box">
                <input
                  ref={inputRef}
                  value={search}
                  type="text" placeholder="Enter..."
                  onChange={e => {
                    setSearch(e.target.value)
                  }}
                />
                <Link
                  to={search && `PageShop/${search}`}
                  onClick={handleSearch}
                >
                  Ok
                </Link>
              </div>
            }

          </div>

          <div className="Heder_list2_line"></div>

          {
            checkUser ? 'Đã đăng nhập' : <p>
              <Link to='/login' className="Heder_list2_a1">
                {" "}
                Log in
              </Link>
            </p>
          }
          <NavLink className="Heder_list_item" to="/EmptyProduct"><img className="Heder_list2_img" src={Vector} alt="" /> </NavLink>
        </div>
      </div>
    </div>
  );
}
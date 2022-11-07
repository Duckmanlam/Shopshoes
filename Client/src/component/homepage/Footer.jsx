import "../../scss/component/homepage/Footer.scss";
import React from "react";
import Call from "../../assets/img/call.png";
import Face from "../../assets/img/face.png";
import IG from "../../assets/img/IG.png";
import { Link, NavLink } from "react-router-dom";
export default function Footer() {
  return (
    <div>
      <div className=" footer flex-mobile ">
        <div className="footer_container flex-mobile ">
          <div className="footer_container_content ">
            <h2 className="footer_container_content_header1 ">Shoppes</h2>
            <p className="footer_container_content_text1 ">Address</p>
            <p>
              <Link to="" className="footer_container_content_text">
                2118 Thornridge Cir. Syracuse, Connecticut 35624
              </Link>
              </p>
          </div>
          <div className="footer_container_content ">
            <h3 className="footer_container_content_header">Menu</h3>
            <p>
            <NavLink to="/">Home </NavLink>
            </p>
            <p>
            <NavLink to="/AllProduct">Shop </NavLink>
            </p>
            <p>
              <Link to="" className="footer_container_content_text ">
                Wishlist
              </Link>
            </p>
            <p>
              <Link to="" className="footer_container_content_text ">
                Order Tracking
              </Link>
            </p>
            <p>
            <NavLink to="/Blog">Blog </NavLink>
            </p>
          </div>
          <div className="footer_container_content">
            <h3 className="footer_container_content_header ">Quick Links</h3>
            <p>
            <NavLink to="/login">Login </NavLink>
            </p>
            <p>
            <NavLink to="/a">Register </NavLink>
            </p>
            <p>
              <Link to="" className="footer_container_content_text ">
                My Cart
              </Link>
            </p>
          </div>
          <div className="footer_container_content">
            <h3 className="footer_container_content_header">
              Let's Stay in Touch
            </h3>
            <p className="footer_container_content_text ">
              {/* <button className="footer_container_content_text_btn1">
                Enter Your Email Address
                <button className="footer_container_content_text_btn1_btn2">
                  Subscribe
                </button>
              </button> */}
            </p>
            <p className="footer_container_content_text2 ">Follow our Social</p>
            <div className="footer_container_content_list ">
              <Link to="" className="footer_container_content_list_1 ">
                <img src={Face} alt="" />
              </Link>
              <Link to="" className="footer_container_content_list_1 ">
                <img src={IG} alt="" />
              </Link>
              <Link to="" className="footer_container_content_list_1 ">
                <img src={Call} alt="" />
              </Link>
            </div>
          </div>
        </div>
        <div className="footer_end">
          Copyright Shoppes 2022 All Right Reserved
        </div>
      </div>
    </div>
  );
}

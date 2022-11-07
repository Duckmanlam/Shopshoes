import React from "react";
import "../../scss/component/homepage/Body.scss";
import "../../scss/global.scss";
export default function Body() {
  return (
    <div className="Body">
      <div className="container">
        <div className="about-us">
          <h3 className="about-us__title">Why you Choose US</h3>
          <div className="about-us__content">
            {data?.map((item, index) => {
              return (
                <div className="about-us__item" key={index}>
                  <img className="about-us__item-icon" src={item.img} alt="" />
                  <h3 className="about-us__item-title">
                    {" "}
                    <b>{item.title}</b>
                  </h3>
                  <p className="about-us__item-description">
                    {item.description}
                  </p>
                </div>
              );
            })}
          </div>
        </div>
      </div>
    </div>
  );
}

const data = [
  {
    img: "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c3/Circle-icons-camera.svg/768px-Circle-icons-camera.svg.png",
    title: "Free Shipping",
    description:
      "Velit officia consequat duis enim velit mollit. Exercitation veniam consequat sunt nostrud amet. ",
  },
  {
    img: "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c3/Circle-icons-camera.svg/768px-Circle-icons-camera.svg.png",
    title: "100% Secure Payment",
    description:
      "Velit officia consequat duis enim velit mollit. Exercitation veniam consequat sunt nostrud amet. ",
  },
  {
    img: "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c3/Circle-icons-camera.svg/768px-Circle-icons-camera.svg.png",
    title: "24/7 Dedicated Support",
    description:
      "Velit officia consequat duis enim velit mollit. Exercitation veniam consequat sunt nostrud amet. ",
  },
];

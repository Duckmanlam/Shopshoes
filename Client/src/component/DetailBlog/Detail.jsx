import axios from "axios";
import React from "react";
import "../../scss/component/DetailBlog/Detail.scss";
import "../../scss/grid.css";
import "../../scss/component/homepage/responsive.css";
import Facebook from "../../assets/icons/Facebook";
import Instagram from "../../assets/icons/Instagram";
import Telegram from "../../assets/icons/Telegram";
import NikeOne from "../../assets/img/nike-1.png";
import NikeTwo from "../../assets/img/nike-2.png";
import NikeThree from "../../assets/img/nike-3.png";
import RecentPost from "./RecentPost";
import PopularAuthor from "./PopularAuthor";
import PopularPost from "./PopularPost";
import Comment from "./Comment";

export default function Detail() {
  const [data, setData] = React.useState([]);

  const getApi = async () => {
    axios
      .get("https://localhost:7292/api/Blog/GetAllBlog?CategoryId=4&page=1")
      .then((res) => setData(res.data));
  };
  React.useEffect(() => {
    getApi();
  }, []);
  return (
    <div className="Detail">
      <div className="grid wide">
        <div className="row">
          <div className="col l-8 Detail__sports">
            {data.map((item) => {
              return (
                item.id === 19 && (
                  <div key={item.id} className="Detail__container">
                    <img
                      className="Detail__container-img"
                      src={item.productImage}
                      alt=""
                    />
                    <div className="Detail__container-info">
                      <p className="Detail__container-info-name">
                        {item.productDetails.style}
                      </p>
                      <p className="Detail__container-info-date">
                        {item.productDetails.create}
                      </p>
                    </div>
                    <div className="Detail__content">
                      <h1 className="Detail__content-header">{item.posts}</h1>
                      <div className="Detail__content-user">
                        <img
                          className="Detail__content-user-img"
                          src={item.account.avatar}
                          alt={item.account.userName}
                        />
                        <p className="Detail__content-user-name">
                          {item.account.userName}
                        </p>
                      </div>
                      <div className="Detail__content-desc">
                        <p className="Detail__content-desc-text">
                          Lorem ipsum dolor sit amet, consectetur adipiscing
                          elit. Tortor pellentesque et nibh tincidunt bibendum.
                          Sed in tellus in feugiat dui et enim. Odio feugiat id
                          donec ultricies. Nisi, sed sed pellentesque posuere
                          orci sit sed. Gravida facilisis sollicitudin donec
                          vitae quam ut nibh enim.
                        </p>
                        <p className="Detail__content-desc-text">
                          Enim semper nulla quis est.Est scelerisque malesuada
                          maecenas augue elementum integer. Sollicitudin augue
                          in libero eu neque augue diam lectus laoreet. Viverra
                          amet, in massa integer tincidunt ullamcorper. Accumsan
                          massa consequat amet cursus condimentum consectetur.
                          Enim sem cursus viverra at imperdiet.
                        </p>
                        <p className="Detail__content-desc-content">
                          Lorem ipsum dolor sit amet, consectetur adipiscing
                          elit. Tortor pellentesque et nibh tincidunt bibendum.
                          Sed in tellus in feugiat dui et enim. Odio feugiat id
                          donec ultricies. Nisi, sed sed pellentesque posuere
                          orci sit sed. Gravida facilisis sollicitudin donec
                          vitae quam ut nibh enim.
                        </p>
                        <p className="Detail__content-desc-text">
                          Lorem ipsum dolor sit amet, consectetur adipiscing
                          elit. Tortor pellentesque et nibh tincidunt bibendum.
                          Sed in tellus in feugiat dui et enim. Odio feugiat id
                          donec ultricies.
                        </p>
                      </div>
                      <ul className="Detail__content-shoes">
                        <li className="Detail__content-shoes-item">
                          <img
                            className="Detail__content-shoes-item-img"
                            src={NikeOne}
                            alt="NikeOne"
                          />
                        </li>
                        <li className="Detail__content-shoes-item">
                          <img
                            className="Detail__content-shoes-item-img"
                            src={NikeTwo}
                            alt="NikeTwo"
                          />
                        </li>
                        <li className="Detail__content-shoes-item">
                          <img
                            className="Detail__content-shoes-item-img"
                            src={NikeThree}
                            alt="NikeThree"
                          />
                        </li>
                      </ul>
                      <ul className="Detail__content-socials">
                        <li className="Detail__content-socials-item">
                          <p className="Detail__content-socials-item-share">
                            Share
                          </p>
                        </li>
                        <li className="Detail__content-socials-item">
                          <a className="Detail__content-socials-item-link">
                            <Facebook />
                          </a>
                        </li>
                        <li className="Detail__content-socials-item">
                          <a className="Detail__content-socials-item-link">
                            <Instagram />
                          </a>
                        </li>
                        <li className="Detail__content-socials-item">
                          <a className="Detail__content-socials-item-link">
                            <Telegram />
                          </a>
                        </li>
                      </ul>
                    </div>
                  </div>
                )
              );
            })}
          </div>
          <div className="col l-4">
            <RecentPost />
            <PopularPost />
            <PopularAuthor />
          </div>
        </div>
        <Comment />
      </div>
    </div>
  );
}

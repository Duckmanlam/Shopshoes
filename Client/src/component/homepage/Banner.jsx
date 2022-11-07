import React from "react";
import axios from "axios";
import "../../scss/grid.css";
import shoe from "../../assets/img/shoe.png";
import "../../scss/component/homepage/responsive.css";
import "../../scss/component/homepage/Banner.css";
import Rectangle from "../../assets/img/Rectangle.png";
import { Link } from "react-router-dom";

export default function Banner() {
  const [data, setData] = React.useState([]);
  const [loading, setLoading] = React.useState(false);
  const getApi = async () => {
    setLoading(false)
    axios
      .get("https://localhost:7292/api/HomePage/Banner?productId=1")
      .then((res) => setData(res.data));
    setLoading(true)
  };
  React.useEffect(() => {
    getApi();
  }, []);
  return (
    <div>
      {loading ? <div className="Banner__background">
        <img className="Banner__background-img" src={Rectangle} alt="" />
      </div> : <h1>loading .........</h1>
      }
      <div className="grid wide">
        {data.map((item, index) => (
          <div className="row Banner-show" key={index}>
            <div className="col l-6 m-12 Banner-zoom">
              <h2 className="Banner__title">{item.productDetails.type}</h2>
              <h1 className="Banner__heading">
                {item.productDetails.productName}
              </h1>
              <p className="Banner__text">{item.productDetails.description}</p>
              <div className="Banner__group">
                <select className="Banner__select">
                  <option className="Banner__select-item" value="1">
                    GET
                  </option>
                </select>
                <select className="Banner__select">
                  <option className="Banner__select-item" value="1">
                    SIZE
                  </option>
                </select>
                <span className="Banner__select-price">$173</span>
              </div>
              <div className="Banner__button">
                <button className="btn btn--primary">Add to Bag</button>
                <Link className="Banner__button-link" to="#">
                  See Details
                </Link>
              </div>
            </div>
            <div className="col l-6 m-12 Banner__shoes">
              <img className="Banner-img" src={shoe} alt="" />
            </div>
            <div className="overplay"></div>
          </div>
        ))}
      </div>
      <div className="Banner__statistical">
        <div className="grid wide statistical__global">
          <div className="row statistical__link">
            <div className="col l-4 m-12 Banner__foot">
              <p className="statistical__data">
                <span className="statistical__amount">500+ </span>
                <span className="statistical__text">Amazing products</span>
              </p>
            </div>
            <div className="col l-4 m-12 Banner__foot">
              <p className="statistical__data">
                <span className="statistical__amount">40k+ </span>
                <span className="statistical__text">Orders Complated</span>
              </p>
            </div>
            <div className="col l-4 m-12 Banner__foot">
              <p className="statistical__data">
                <span className="statistical__amount">32k+ </span>
                <span className="statistical__text">Happy Customers</span>
              </p>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
}

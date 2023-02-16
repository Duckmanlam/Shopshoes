import React from "react";
import "../../scss/component/homepage/Latest.scss";
import axios from "axios";
import "../../scss/global.scss";
import { Link } from "react-router-dom";

export default function Lastest() {
  const [data, setData] = React.useState([]);

  const getApi = async () => {
    axios
      .get("https://localhost:7292/api/HomePage/ListCategory?id=4")
      .then((res) => setData(res.data));
  };
  React.useEffect(() => {
    getApi();
  }, []);

  return (
    <div className="Latest">
      <h3 className="Second__title">Latest From Blogs</h3>
      <h5>
        Velit officia consequat duis enim velit mollit. Exercitation veniam co
      </h5>
      <div className="container">
        {data.map((item, index) => {
          return (
            <Link
              to={`/DetailBlog/${item.id}`}
              className="Latest__item"
              key={index}
            >
              <img src={item.productImage} alt="" />
              <h6>{item.posts}</h6>
              <p className="p1">{item.productDetails}</p>

              <div className="Lastest__user">
                <div className="Lastest__user-big">
                  <img src={item.account.avatar} alt="" />
                  <div className="Lastest__user-info">
                    <h6>{item.account.userName}</h6>
                    <p className="Lastest__user-info-name">8/2/19</p>
                  </div>
                </div>
              </div>
            </Link>
          );
        })}
      </div>
    </div>
  );
}

import React from "react";
import "../../scss/component/homepage/Second.scss";
import axios from "axios";
import "../../scss/global.scss";

export default function Second() {
  const [data, setData] = React.useState([]);

  const getApi = async () => {
    axios
      .get("https://localhost:7292/api/HomePage/Trending")
      .then((res) => setData(res.data));
  };
  React.useEffect(() => {
    getApi();
  }, []);
  return (
    <div className="Second">
      <div className="container">
        <h3 className="Second__title">What’s Trending Now</h3>
        <div className="Second__item">
          {data.map((item, index) => (
            <div key={index}>
              <img src={item.productDetails.productImage} />
              <div className="Second__content">
                <h5 className="Second__item-title">
                  {item.productDetails.productName}
                </h5>
                <p>${item.productDetails.price}</p>
              </div>
              <p className="Brain__name">{item.productDetails.brandName}</p>
            </div>
          ))}
        </div>
      </div>
    </div>
  );
}

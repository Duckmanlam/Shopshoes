import React from "react";
import "../../scss/component/Des/Banner.scss";
import star from "../../assets/img/star.png";
import tym from "../../assets/img/tym.jpg";
import { useParams } from "react-router-dom";
import axiosApi from "../../api/axios";
import Description from "./Description";
export default function BannerDes() {
  const [data, setData] = React.useState([]);
  const [loading, setLoading] = React.useState(false);
  const param = useParams()



  React.useEffect(() => {
    const getApi = async () => {
      setLoading(true)
      await axiosApi.get(
        `/DetailProductDescription/GetByLocal?ProductName=${param.name}`)
        .then((res) => setData(res)).catch(err => console.log(err.message));
      setLoading(false)
    };
    getApi()
  }, [param.name]);



  return (
    <div>
      {loading ? <h1>loading .........</h1> : (<>{data?.map((item, index) => (
        <div key={index} className="Banner flex-mobile">
          <div className="Banner_img">
            <img className="Banner_img-item" src={item.productDetails.productImage} alt='' />
          </div>
          <div className="Banner_header">
            <h2 className="Banner_header_h3">
              {item.productDetails.productName}
            </h2>
            <p className="Banner_header_p">{item.productDetails.brandName}</p>
            <div className="Banner_header_two">
              <div className="Banner_header_two_price">
                ${item.productDetails.price}
              </div>
              <div>
                <img className="Banner_header_two_img " src={star} alt='' />
                <img className="Banner_header_two_img " src={star} alt='' />
                <img className="Banner_header_two_img " src={star} alt='' />
                <img className="Banner_header_two_img " src={star} alt='' />
                <img className="Banner_header_two_img " src={star} alt='' /> (15
                Reviews)
              </div>
            </div>
            <div className="Banner_header_des">
              <p className="Banner_header_des_p"></p>
              {item.productDetails.description}
            </div>
            <a href="#Des" className="Banner_header_p1">See Details</a>
            <div className="Banner_header_btn">
              <select id="cars">
                <option defaultValue="">QNT</option>
                <option defaultValue="1">1</option>
                <option defaultValue="2">2</option>
                <option defaultValue="3">3</option>
                <option defaultValue="4">4</option>
                <option defaultValue="5">5</option>
              </select>
              <select id="cars">
                <option defaultValue="">Size</option>
                <option defaultValue="1">34</option>
                <option defaultValue="2">35</option>
                <option defaultValue="3">36</option>
                <option defaultValue="4">37</option>
                <option defaultValue="5">38</option>
                <option defaultValue="5">39</option>
              </select>
            </div>
            <div className="Banner_header_button34">
              <button className="Banner_header_button34_3" onClick={() => console.log(item)}>Add to Bag</button>
              <button className="Banner_header_button34_4">
                <img className="Banner_header_button34_4_img" src={tym} alt='' />
                <p className="Banner_header_button34_4_p">Add to Wishlist</p>
              </button>
            </div>
          </div>
        </div>
      ))}
      </>)}
      
      <div id="Des">
        <Description />
      </div>

    </div>
  );
}

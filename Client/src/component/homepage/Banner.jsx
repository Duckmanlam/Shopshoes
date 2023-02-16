import React from "react";
import axios from "axios";
import "../../scss/grid.css";
import shoe from "../../assets/img/shoe.png";
import "../../scss/component/homepage/responsive.css";
import "../../scss/component/homepage/Banner.css";
import Rectangle from "../../assets/img/Rectangle.png";
import { Link } from "react-router-dom";
import { useRecoilState } from "recoil";
import { addToCart, cartState } from "../../features/cart/cartState";
import { ToastContainer, toast } from 'react-toastify';
import 'react-toastify/dist/ReactToastify.css'

export default function Banner() {
  const [data, setData] = React.useState([]);
  const [cart, setCart] = useRecoilState(cartState)
  const [size, setSize] = React.useState('40')

  const getApi = async () => {
    axios
      .get("https://localhost:7292/api/HomePage/Banner?productId=1")
      .then((res) => setData(res.data));
  };
  React.useEffect(() => {
    getApi();
  }, []);

  const handleAddToCart = (product) => {

    const newCart = addToCart(cart, product, size);
    setCart(newCart)

    toast.success('Successfully added')
  }

  const handleSize = (e) => {
    setSize(prev => [...prev, e.target.value])
  }

  return (
    <div>
      <ToastContainer />
      <div className="Banner__background">
        <img className="Banner__background-img" src={Rectangle} alt="" />
      </div>

      <div className="grid wide">
        {data.map((item, index) => (
          <div className="row Banner-show" key={index}>
            <div className="col l-6 m-12 Banner-zoom">
              <h2 className="Banner__title">{item.type}</h2>
              <h1 className="Banner__heading">
                {item.productName}
              </h1>
              <p className="Banner__text">{item.description}</p>
              <div className="Banner__group">
                <p className="Banner__group-text">QNT</p>
                <select
                  className="Banner__select"
                >
                  <option value="1">1</option>
                </select>

                <p className="Banner__group-text">SIZE</p>
                <select
                  className="Banner__select"
                  onChange={handleSize}
                >
                  <option value="40">40</option>
                </select>
                <span className="Banner__select-price">${item.price}</span>
              </div>
              <div className="Banner__button">
                <button
                  className="btn btn--primary"
                  onClick={() => handleAddToCart(item)}
                >
                  Add to Bag
                </button>
                <Link className="Banner__button-link" to={`/DetailWriteReview/${item.id}`}>
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

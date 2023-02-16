import React from "react";
import "../../scss/component/Empty/EmptyProduct.scss";
import Product from "../../assets/img/Product.png";
import { ToastContainer, toast } from 'react-toastify';
import 'react-toastify/dist/ReactToastify.css';


export default function EmptyProduct({success}) {
  success && toast.success('Successfully paied')

  return (
    <div className="EmptyProduct">
      <ToastContainer />
      <h2 className="EmptyProduct_h2">Wishlist</h2>
      <div className="EmptyProduct_ul a-mobile">
      </div>
      <div className="EmptyProduct_line a-mobile"></div>
      <img className="EmptyProduct_img pc" src={Product} alt="" />
    </div>
  );
}

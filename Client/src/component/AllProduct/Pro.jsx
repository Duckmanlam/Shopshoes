import React from "react";
import "../../scss/component/AllProduct/AllPro.scss";
import AllPro from "../../assets/img/AllPro.png";
import All from "./All";
export default function Pro() {
  return (
    <div>
      <All />
      <div className="Pro flex-left flex-pc ">
        <img className="Pro_img" src={AllPro} alt=""></img>
      </div>
    </div>
  );
}

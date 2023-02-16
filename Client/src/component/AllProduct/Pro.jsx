import React from "react";
import "../../scss/component/AllProduct/AllPro.scss";
import AllPro from "../../assets/img/AllPro.png";

export default function Pro() {
  return (
    <div>
      <div className="Pro flex-left flex-pc ">
        <img className="Pro_img" src={AllPro} alt=""></img>
      </div>
    </div>
  );
}

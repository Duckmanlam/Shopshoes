import React from "react";
import "../../scss/component/Empty/EmptyState.scss";
import Data from "../../assets/img/Data.png";
export default function EmptyState() {
  return (
    <div className="Empty state-left state-pc ">
      <img className="Empty_img" src={Data} alt=""></img>
    </div>
  );
}

import React from "react";
import Banner from "../component/homepage/Banner";
import Body from "../component/homepage/Body";
import Fifth from "../component/homepage/Fifth";
import Lastest from "../component/homepage/Lastest";
import Second from "../component/homepage/Second";

import Test from "./../component/homepage/Test";
export  function Homepage() {
  return (
    <>
      <Banner />
      <Body />
      <Test />
      <Second />
      <Fifth />
      <Lastest />
    </>
  );
}

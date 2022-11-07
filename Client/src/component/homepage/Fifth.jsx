import React from "react";

import "../../scss/component/homepage/Fifth.scss";
import "../../scss/global.scss";

export default function Fifth() {
  return (
    <div className="fifth">
      <div className="container">
        <h3 className="fifth__title">Share With #Shoppes</h3>
        <p className="fifth__des">Follow @shoppes instagram for inspirations</p>
        <div className="fifth__item">
          {data?.map((item, index) => {
            return (
              <div key={index}>
                <img src={item} alt="" />
              </div>
            );
          })}
        </div>
      </div>
    </div>
  );
}
const data = [
  "https://lh3.googleusercontent.com/drive-viewer/AJc5JmRPMfPGpYXIST9WSiO7XEZ4xwlXe7jdLP50a7zbAuieuj1KQk37XzH1o5iSkucYsbMCaG9nV7s=w1227-h942",

  "https://lh3.googleusercontent.com/drive-viewer/AJc5JmSFndNwoL38dLS02ZQZq23lySy2b_owXoh8g3_F-grg_K2pzpPr-i5mW9o-TvAOqKxy7ujgxwE=w1227-h942",

  "https://lh3.googleusercontent.com/drive-viewer/AJc5JmTdqjIzoQZMeanNAY451fIqFA5jXkPin8tUsyRBvdnxP2-8fLTIU_g_L33-DNVFwQc-c5PIoQA=w1227-h942",

  "https://lh3.googleusercontent.com/drive-viewer/AJc5JmQEMkYhXMgz8hyq1qUSEStTMWKr2HEx2MQJ05XEL1KGsekFvwJ5O0F5vvHpLHV30aCk6aE5SfY=w1227-h942",

  "https://lh3.googleusercontent.com/drive-viewer/AJc5JmTaS169x9VUuSmGkLI3AovRuj-1x3ksDBdcLa6u5DqXwyi_4eFo7Cjor1dyz-n1U_Q2AgvdXhQ=w1227-h942",

  "https://lh3.googleusercontent.com/drive-viewer/AJc5JmRVTTvkT3h8aCxHpD1oph_9LeUf3yG_XSPuv78Wc_vv2GvOUK0stF9uuA_6YJfF5C7ZvVtY4BY=w1227-h942",
];

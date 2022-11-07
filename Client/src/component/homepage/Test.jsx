import React from "react";
import "../../scss/component/homepage/Test.scss";
import "../../scss/global.scss";
export default function Test() {
  return (
    <div className="Favourite">
      <div className="container">
        <h3 className="Favourite__title">Favourites on This Week</h3>
        <div className="Favourite__item">
          {data.map((item, index) => (
            <div key={index}>
              {item.productImage?.map((e, i) => (
                <img src={e.featureImage} alt="" key={i} />
              ))}
              <div className="Favourite__content">
                <h5 className="Second__item-title">{item.productName}</h5>
                <h3>${item.price}</h3>
              </div>
            </div>
          ))}
        </div>{" "}
      </div>
    </div>
  );
}
const data = [
  {
    productName: "Nike ZoomX Streakfly",
    title: null,
    productImage: [
      {
        featureImage:
          "https://lh3.googleusercontent.com/drive-viewer/AJc5JmS3EAa4lxSfEn1oi4OSywmqtlwWw-DZcMUddUIfG357gxcvFQGYQJZc6SqBqgaX5b3nyx-sL7k=w1227-h942",
      },
    ],
    price: 213,
    brandName: "Men's Shoes",
    description: null,
  },
  {
    productName: "Nike Air Max 2021",
    title: null,
    productImage: [
      {
        featureImage:
          "https://lh3.googleusercontent.com/drive-viewer/AJc5JmR0Qt1lRYg8j6MohwJizIoHlmtCMAWr1Xz9rOo9fgG4FDmn9Lsr_iS35PHV8WZJpsvMpEzDmuw=w1227-h942",
      },
    ],
    price: 213,
    brandName: "Men's Shoes",
    description: null,
  },
  {
    productName: "Nike Air Max 2021",
    title: null,
    productImage: [
      {
        featureImage:
          "https://lh3.googleusercontent.com/drive-viewer/AJc5JmTgImoHZJrU_oKyn3jSyXhZ9H4f_P0wnLnTLgJ5ot5b7cbu7w_8QTDAKcfeG9HRxmrYcyVRVrM=w1227-h942",
      },
    ],
    price: 213,
    brandName: "Men's Shoes",
    description: null,
  },
  {
    productName: "Nike Air Max 2021",
    title: null,
    productImage: [
      {
        featureImage:
          "https://lh3.googleusercontent.com/drive-viewer/AJc5JmSzha5C6XgTCNn6T7eTHsPtK3xbrPYozPTB6H9ncdhslaIQ5_fbC2ZEdeZRb3jVAmb0tUXOOzQ=w1227-h942",
      },
    ],
    price: 213,
    brandName: "Men's Shoes",
    description: null,
  },
];

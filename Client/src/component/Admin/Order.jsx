import React from "react";
import "../../scss/component/Admin/Order.scss";
// import { faEye } from '@fortawesome/free-solid-svg-icons'
// import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'
export default function () {
  return (
    <>
      <div>
        <h1 className="header"> Order </h1>
        <div className="Product">
          <table>
            <thead className="table" id="render">
              <tr>
                <td>OrderId</td>
                <td>Date</td>
                <td>Payment Status</td>
                <td>Payment Method</td>
                <td>Total</td>
                <td>Status</td>
                <td>Action</td>
              </tr>
            </thead>
            <tbody>
             {
              data?.map(item=> (
                <tr key={item.productId}>
                  <td>{item.productId}</td>
                  <td><img src={item.productImage} style={{width: '100px'}} alt="" /></td>
                  <td>{item.productName}</td>
                  <td>{item.brandName}</td>
                  <td>{item.price}.000VNĐ</td>
                  <td>{item.status === 1 ? 'Hoạt động' : item.status=== 0 ? 'Ngừng hoạt động' : null}</td>
                  <td><button onClick={() => console.log(item)}>Chỉnh</button><button>xoá</button></td>
                </tr>
              ))
             }
            </tbody>
          </table>
        </div>
      </div>
    </>
  );
}

const data =[
    {
        id: '#BM9708',
        date: "2020-12-12",
        total: 100,
        status: "pending"
    },
    {
        id: '#BM9708',
        date: "2020-12-12",
        total: 100,
        status: "pending"
    },
    {
        id: '#BM9708',
        date: "2020-12-12",
        total: 100,
        status: "pending"
    },
    {
        id: '#BM9708',
        date: "2020-12-12",
        total: 100,
        status: "pending"
    },
    {
        id: '#BM9708',
        date: "2020-12-12",
        total: 100,
        status: "pending"
    },
]
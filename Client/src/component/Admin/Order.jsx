import React from "react";
import "../../scss/component/Admin/Order.scss";
import "../../scss/component/Admin/FromButton.scss";
import axiosApi from "../../api/axios";

export default function Order() {
  const [data, setData] = React.useState([]);

  React.useEffect(() => {
    const getApi = async () => {
      await axiosApi.get(
        `/Order_Admin`)
        .then((res) => setData(res)).catch(err => console.log(err.message));
    };
    getApi()
  }, []);

  console.log(data);
  return (
    <div>
      <div className="Header_form">
        <ul className="Header_form_ul">
          <li className="Header_form_ul_li li">
            <a className="Header_form_ul_li_a" href="/">
              Home
            </a>
          </li>
          <li className="Header_form_ul_li li">
            <a className="Header_form_ul_li_a" href="/Admin">
              AdminProducts
            </a>
          </li>
          <li className="Header_form_ul_li li">
            <a className="Header_form_ul_li_a" href="/Order">
              AdminOrder
            </a>
          </li>
        </ul>
      </div>
      <h2 className="title">Order Management</h2>
      <div className="Admin">
        <div className="Product">
          <table>
            <thead className="table" id="render">
              <tr className="table_header">
                <td>ID</td>
                <td>ImageFile</td>
                <td>ProductName</td>
                <td>BrandName</td>
                <td>Price</td>
                <td>Status</td>
                <td>Action</td>
              </tr>
            </thead>

            <tbody>
              {data.map((item) => (
                <tr key={item}>
                  <td>{item.id}</td>
                  <td>
                    <img className="apiImg" src={item.productImage} alt="" />
                  </td>
                  <td>{item.productName}</td>
                  <td>{item.brandName}</td>
                  <td>{item.price}$</td>
                  <td>
                    {item.status === 1
                      ? "delivered"
                      : item.status === 0
                      ? "Not delivery"
                      : null}
                  </td>

                  <td>
                    <button className="Admin_update update" type="button">
                      See detail
                    </button>
                    <button type="button" className="Admin_remove remove">
                      Delete
                    </button>
                  </td>
                </tr>
              ))}
            </tbody>
          </table>
        </div>
      </div>
    </div>
  );
}

// const data = [
//   {
//     id: 1,
//     orderDate: "2022-11-04T14:37:38.854364",
//     productName: "Nike ZoomX Streakfly",
//     shipName: "Châu Tinh Trì",
//     shipAddress: "TPHCM",
//     shipPhoneNumber: "123456789",
//     status: 0,
//     price: 213,
//     quantity: 3,
//     total: 639,
//     brandName: "Men's Shoes",
//     size: "M",
//     productImage:
//       "https://lh3.googleusercontent.com/drive-viewer/AJc5JmR4vAg9_VJqlg0WiateWDeoYd84lQzvlnvyHE3ltsfWXAl51_Zbqo6djfpEtbb1Ce_QMOZLLcY=w1920-h870",
//   },
//   {
//     id: 2,
//     orderDate: "2022-11-03T18:13:40.4750056",
//     productName: "Nike ZoomX Streakfly",
//     shipName: "Châu Tinh Trì",
//     shipAddress: "TPHCM",
//     shipPhoneNumber: "123456789",
//     status: 0,
//     price: 215,
//     quantity: 1,
//     total: 213,
//     brandName: "Men's Shoes",
//     size: "L",
//     productImage:
//       "https://lh3.googleusercontent.com/drive-viewer/AJc5JmR4vAg9_VJqlg0WiateWDeoYd84lQzvlnvyHE3ltsfWXAl51_Zbqo6djfpEtbb1Ce_QMOZLLcY=w1920-h870",
//   },
//   {
//     id: 3,
//     orderDate: "2022-11-03T18:13:40.4750056",
//     productName: "Nike ZoomX Streakfly",
//     shipName: "Châu Tinh Trì",
//     shipAddress: "TPHCM",
//     shipPhoneNumber: "123456789",
//     status: 0,
//     price: 215,
//     quantity: 1,
//     total: 213,
//     brandName: "Men's Shoes",
//     size: "L",
//     productImage:
//       "https://lh3.googleusercontent.com/drive-viewer/AJc5JmR4vAg9_VJqlg0WiateWDeoYd84lQzvlnvyHE3ltsfWXAl51_Zbqo6djfpEtbb1Ce_QMOZLLcY=w1920-h870",
//   },
//   {
//     id: 4,
//     orderDate: "2022-11-03T18:13:40.4750056",
//     productName: "Nike ZoomX Streakfly",
//     shipName: "Châu Tinh Trì",
//     shipAddress: "TPHCM",
//     shipPhoneNumber: "123456789",
//     status: 0,
//     price: 215,
//     quantity: 1,
//     total: 213,
//     brandName: "Men's Shoes",
//     size: "L",
//     productImage:
//       "https://lh3.googleusercontent.com/drive-viewer/AJc5JmR4vAg9_VJqlg0WiateWDeoYd84lQzvlnvyHE3ltsfWXAl51_Zbqo6djfpEtbb1Ce_QMOZLLcY=w1920-h870",
//   },
//   {
//     id: 5,
//     orderDate: "2022-11-03T18:13:40.4750056",
//     productName: "Nike ZoomX Streakfly",
//     shipName: "Châu Tinh Trì",
//     shipAddress: "TPHCM",
//     shipPhoneNumber: "123456789",
//     status: 0,
//     price: 215,
//     quantity: 1,
//     total: 213,
//     brandName: "Men's Shoes",
//     size: "L",
//     productImage:
//       "https://lh3.googleusercontent.com/drive-viewer/AJc5JmR4vAg9_VJqlg0WiateWDeoYd84lQzvlnvyHE3ltsfWXAl51_Zbqo6djfpEtbb1Ce_QMOZLLcY=w1920-h870",
//   },
//   {
//     id: 6,
//     orderDate: "2022-11-03T18:13:40.4750056",
//     productName: "Nike ZoomX Streakfly",
//     shipName: "Châu Tinh Trì",
//     shipAddress: "TPHCM",
//     shipPhoneNumber: "123456789",
//     status: 0,
//     price: 215,
//     quantity: 1,
//     total: 213,
//     brandName: "Men's Shoes",
//     size: "L",
//     productImage:
//       "https://lh3.googleusercontent.com/drive-viewer/AJc5JmR4vAg9_VJqlg0WiateWDeoYd84lQzvlnvyHE3ltsfWXAl51_Zbqo6djfpEtbb1Ce_QMOZLLcY=w1920-h870",
//   },
// ];

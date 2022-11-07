import React from "react";
import { useEffect } from "react";
import axiosApi from "../../api/axios";
import "../../scss/component/Admin/FromButton.scss";
export default function FromButton() {
  const [ProductName, setProductName] = React.useState("");
  const [Type, setType] = React.useState("");
  const [Description, setDescription] = React.useState("");
  const [BrandName, setBrandName] = React.useState("");
  const [Price, setPrice] = React.useState();
  const [Stock, setStock] = React.useState();
  const [Size, setSize] = React.useState();
  const [ImageFile, setImageFile] = React.useState("");
  const [Status, setStatus] = React.useState("");
  const [data, setData] = React.useState([]);
  const [productId, setProductId] = React.useState("");
  const item = {
    ProductName: ProductName,
    Type: Type,
    Description: Description,
    BrandName: BrandName,
    Price: parseInt(Price),
    Stock: parseInt(Stock),
    Size: parseInt(Size),
    Status: Status,
    ImageFile: ImageFile,
  };
  const getApi = async () => {
    await axiosApi.get("Category_Admin").then((res) => setData(res));
  };
  useEffect(() => {
    getApi();
  }, []);

  // Chức năng thêm
  const handleOnSubmit = async (e) => {
    e.preventDefault();
    await axiosApi.post("Category_Admin/AddProduct", item);
    alert("Thêm sản phẩm thành công!");
    console.log(alert);
  };

  // Chức năng xóa => thành công
  const deleteId = async (e) => {
    setProductId(e);
    alert("Bạn có chắc chắn muốn xóa không!");
    console.log(alert);
    await axiosApi.delete(`Category_Admin/8`);
  };

  // Chức năng sửa
  const updateId = async (e) => {
    alert("Bạn có chắc muốn sửa sản phẩm");
    console.log(alert);
    await axiosApi.put(`Category_Admin`);
  };

  return (
    <div>
      <div>
        <div className="Header_form">
          <ul>
            <li>
              <a className="" href="">
                ADDS
              </a>
            </li>
            <li>
              <a href="">ADMIN</a>
            </li>
            <li>
              <a href="">HOMEPAGE</a>
            </li>
          </ul>
        </div>
        <h1 className="Header">THÊM SẢN PHẨM </h1>
        <div className="Content">
          <form className="Content_from " onSubmit={(e) => handleOnSubmit(e)}>
            <Input
              label="ProductName"
              onchange={(e) => setProductName(e.target.value)}
            />
            <Input label="Type" onchange={(e) => setType(e.target.value)} />

            <Input
              label="Description"
              onchange={(e) => setDescription(e.target.value)}
            />
            <Input
              label="BrandName"
              onchange={(e) => setBrandName(e.target.value)}
            />
            <Input label="Price" onchange={(e) => setPrice(e.target.value)} />
            <Input label="Stock" onchange={(e) => setStock(e.target.value)} />
            <Input label="Size" onchange={(e) => setSize(e.target.value)} />
            <div className="Content_from_content">
              <label className="Content_from_content_label" htmlFor="name">
                Status
              </label>
              <br></br>
              <select
                className="Content_from_content_btn "
                onChange={(e) => setStatus(e.target.value)}
                id="Status"
                name="cars"
              >
                <option value="">--</option>
                <option value="0">Deactive</option>
                <option value="1">Active</option>
              </select>
            </div>
            {/* <div className="Content_from_content">
              <label className="Content_from_content_label" htmlFor="kh_ten">
                ImageFile
              </label>
              <br></br>
              <input
                onChange={(e) => setImageFile(e.target.value)}
                type="file"
                id="ImageFile"
                name="kh_ten"
                accept="image/png, image/jpeg, image/jpg"
              />
            </div> */}
            <Input
              label="ImageFile"
              onchange={(e) => setImageFile(e.target.value)}
            />
            <div className="Content_from_btn">
              <button className="Content_from_btn_1" type="submit">
                THÊM SẢN PHẨM
              </button>
            </div>
          </form>
        </div>
      </div>
      {/* Admin product */}
      <div className="Admin">
        <h1 className="header"> ADMIN PRODUCTS</h1>
        <div className="Product">
          <table>
            {/* header table */}
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
              {data?.map((item) => (
                <tr key={item.productId}>
                  <td>{item.productId}</td>
                  <td>
                    <img
                      src={item.productImage}
                      style={{ width: "100px" }}
                      alt=""
                    />
                  </td>
                  <td>{item.productName}</td>
                  <td>{item.brandName}</td>
                  <td>{item.price}.000VNĐ</td>
                  <td>
                    {item.status === 1
                      ? "Active"
                      : item.status === 0
                      ? "Deactive"
                      : null}
                  </td>
                  <td>
                    <button
                      className="Admin_update"
                      onClick={() => updateId(item.productId)}
                      type="button"
                    >
                      SỬA
                    </button>
                    <button
                      type="button"
                      className="Admin_remove"
                      onClick={() => deleteId(item.productId)}
                    >
                      XÓA
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

// tạo function cho input
function Input({ label, onChange }) {
  return (
    <div className="Content_from_content">
      <label className="Content_from_content_label" htmlFor="name">
        {label}
      </label>
      <br></br>
      <input className="Content_from_content_input " onChange={onChange} />
    </div>
  );
}

import React from "react";
import { useEffect } from "react";
import Modal from "../Common/Modal.js";
import axiosApi from "../../api/axios";
import useModal from "../Common/UseModal";
import "../../scss/component/Admin/FromButton.scss";
export default function FromButton() {
  const [page, setPage] = React.useState(1);
  const { isShowing, toggle } = useModal();
  const [data, setData] = React.useState([]);
  const [productId, setProductId] = React.useState("");
  const [update, setUpdate] = React.useState({});
  const [item, setItem] = React.useState({
    productId: 0,
    productName: "",
    type: "",
    description: "",
    brandName: "",
    price: 0,
    stock: 0,
    status: 0,
    viewCount: 0,
    productImage: "",
  });

  const getApi = async () => {
    await axiosApi
      .get(`Category_Admin?page=${page}`)
      .then((res) => setData(res))
      .catch((err) => console.log(err));
  };
  useEffect(() => {
    getApi();
  }, [page]);
  // Chức năng thêm/ sửa
  const handleOnSubmit = async (e) => {
    e.preventDefault();
    const checkItem = data.filter((i) => i.productId === update.productId);

    if (checkItem.length > 0) {
      try {
        item.price = parseInt(item.price);
        item.stock = parseInt(item.stock);
        item.status = parseInt(item.status);
        const dataItem = { ...item, id: update.productId };
        await axiosApi
          .put(`Category_Admin/${productId}`, dataItem)
          .then(() => getApi());
        alert("update success!");
      } catch (err) {}
    } else {
      try {
        delete item.productId;
        item.price = parseInt(item.price);
        item.stock = parseInt(item.stock);
        item.status = parseInt(item.status);
        await axiosApi.post("Category_Admin/AddProduct", item);
        alert("add success!");
      } catch (err) {}
    }
  };

  const handleOnChange = (e) => {
    const newItem = { ...item };

    newItem[e.target.id] = e.target.value;
    setItem(newItem);
  };

  // Chức năng xóa
  const deleteId = async (e) => {
    await axiosApi.delete(`Category_Admin/${e}`).then(() => getApi());
    alert("remove success!");
  };

  //Chức năng sửa
  const updateId = (e) => {
    setUpdate(e);
    setItem({
      productId: e.productId,
      productName: e.productName,
      type: e.type,
      description: e.description,
      brandName: e.brandName,
      price: e.price,
      stock: e.stock,
      status: e.status,
      productImage: e.productImage,
    });
  };

  //  Lấy id truyền qua model
  const handleModel = (e) => {
    toggle(); //kích hoạt model
    setProductId(e); // setState id
  };

  return (
    <div>
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
                AdminProduct
              </a>
            </li>
            <li className="Header_form_ul_li li">
              <a className="Header_form_ul_li_a" href="/Order">
                AdminOrder
              </a>
            </li>
          </ul>
        </div>
        <div>
          <h2 onClick="myFunction()" className="Header">
            ADD PRODUCTS
          </h2>
          <div className="Content content">
            <form className="Content_from " onSubmit={(e) => handleOnSubmit(e)}>
              <Input
                className="Content_from_content_btn "
                label="ProductName"
                id="productName"
                value={item.productName}
                onChange={(e) => handleOnChange(e)}
              />
              <Input
                className="Content_from_content_btn "
                label="Type"
                id="type"
                value={item.type}
                onChange={(e) => handleOnChange(e)}
              />
              <Input
                className="Content_from_content_btn "
                label="Description"
                id="description"
                value={item.description}
                onChange={(e) => handleOnChange(e)}
              />
              <Input
                className="Content_from_content_btn "
                label="BrandName"
                id="brandName"
                value={item.brandName}
                onChange={(e) => handleOnChange(e)}
              />
              <Input
                className="Content_from_content_btn "
                label="Price"
                id="price"
                value={item.price}
                onChange={(e) => handleOnChange(e)}
              />
              <Input
                className="Content_from_content_btn "
                label="Stock"
                id="stock"
                value={item.stock}
                onChange={(e) => handleOnChange(e)}
              />

              <p className="sta">Status</p>
              <select
                className="Content_from_content_btn"
                onChange={(e) => setItem({ ...item, status: e.target.value })}
                id="status"
                value={item.status}
              >
                <option value="">----</option>
                <option value="0">Deactive</option>
                <option value="1">Active</option>
              </select>
              <Input
                className="Content_from_content_btn "
                label="ProductImage"
                id="productImage"
                value={item.productImage}
                onChange={(e) => handleOnChange(e)}
              />
              <div className="Content_from_btn">
                <button className="Content_from_btn_1 addProduct" type="submit">
                  {item.productId ? "CẬP NHẬT SẢN PHẨM" : "THÊM MỚI SẢN PHẨM"}
                </button>
              </div>
            </form>
          </div>
        </div>
      </div>
      {/* Admin product */}
      <div className="Admin">
        <h2 className="header"> ADMIN PRODUCTS</h2>
        <div className="Product hoverProduct">
          <table>
            <thead className="table" id="render">
              <tr className="table_header">
                <td>ID</td>
                <td>ImageFile</td>
                <td>ProductName</td>
                <td>BrandName</td>
                <td>Price</td>
                <td>Status</td>
                <td>ViewCount</td>
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
                  <td>{item.price}$</td>
                  <td>
                    {item.status === 1
                      ? "Active"
                      : item.status === 0
                      ? "Deactive"
                      : null}
                  </td>
                  <td>{item.viewCount}</td>
                  <td>
                    <button
                      className="Admin_update update"
                      onClick={() => updateId(item)}
                      type="button"
                    >
                      Update
                    </button>

                    <button
                      className="Admin_remove remove"
                      onClick={() => handleModel(item.productId)}
                    >
                      Delete
                    </button>
                  </td>
                </tr>
              ))}
            </tbody>
            <button className="pageOne" onClick={() => setPage(1)}>
              Page 1
            </button>
            <button className="pageOne" onClick={() => setPage(2)}>
              Page 2
            </button>
          </table>
          <Modal
            isShowing={isShowing}
            hide={toggle}
            deleteId={() => deleteId(productId)}
          />
        </div>
      </div>
    </div>
  );
}

// tạo function cho input
function Input({ label, onChange, value, id }) {
  return (
    <div className="Content_from_content">
      <label className="Content_from_content_label" htmlFor="name">
        {label}
      </label>
      <br></br>
      <input
        required
        id={id}
        value={value}
        className="Content_from_content_input "
        onChange={onChange}
      />
    </div>
  );
}

// function myFunction() {
//   document.getElementById("myFunction").style.display = "block";
// }
// myFunction();

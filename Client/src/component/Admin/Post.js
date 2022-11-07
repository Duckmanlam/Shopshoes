import axios from "axios";
import React, { Component } from "react";

class Post extends Component {
  constructor(props) {
    super(props);
    this.state = {
      ProductName: "",
      Type: "",
    };
  }
  changeHandler = (e) => {
    this.setState({ [e.target.name]: e.target.value });
  };
  submitHandler = (e) => {
    e.preventDefault();
    console.log(this.state);
    axios
      .post("https://localhost:7292/api/Category_Admin/AddProduct", this.state)
      .then((response) => {
        console.log(response);
      })
      .catch((error) => {
        console.log(error);
      });
  };
  render() {
    const { ProductName, Type } = this.state;
    return (
      <div>
        <form className="Content_from " onSubmit={this.submitHandler}>
          <input
            name="ProductName"
            type="text"
            value={ProductName}
            onChange={this.changeHandler}
          />
          <input
            name="Type"
            type="text"
            value={Type}
            onChange={this.changeHandler}
          />

          <div className="Content_from_btn">
            <button className="Content_from_btn_1" type="submit">
              THÊM SẢN PHẨM
            </button>
          </div>
        </form>
      </div>
    );
  }
}

export default Post;

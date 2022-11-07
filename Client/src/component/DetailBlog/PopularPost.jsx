import axios from "axios";
import React from "react";
import "../../scss/component/DetailBlog/PopularPost.scss";
export default function PopularPost() {
  const [data, setData] = React.useState([]);
  const getApi = async () => {
    axios
      .get("https://localhost:7292/api/Blog/PopularPost?CategoryId=4")
      .then((res) => setData(res.data));
  };
  React.useEffect(() => {
    getApi();
  }, []);

  return (
    <div className="Post">
      <p className="Post_header">Popular Post</p>
      {data.map((item, index) => (
        <div key={index} className="Post_index">
          <p className="Post_index_produc">{item.productDetails}</p>
          <p className="Post_index_p">8/2/19</p>
        </div>
      ))}
      <div className="Post_border4"></div>
    </div>
  );
}

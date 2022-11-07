import axios from "axios";
import React from "react";
import "../../scss/component/DetailBlog/PopularAuthor.scss";
export default function PopularAuthor() {
  const [data, setData] = React.useState([]);

  const getApi = async () => {
    axios
      .get("https://localhost:7292/api/Blog/PopularAuthor?CategoryId=4")
      .then((res) => setData(res.data));
  };
  React.useEffect(() => {
    getApi();
  }, []);
  return (
    <div className="Author">
      <p className="Author_header">Popular Author</p>
      {data.map((item, index) => (
        <div key={index} className="Author_index">
          <div className="Author_index_img">
            <img src={item.account.avatar} />
          </div>
          <div className="Author_index_des">
            <p className="Author_index_des_name">Ralph Edwards</p>
            <p className="Author_index_des_p">
              {item.account.articles} Articles
            </p>
          </div>
        </div>
      ))}
    </div>
  );
}

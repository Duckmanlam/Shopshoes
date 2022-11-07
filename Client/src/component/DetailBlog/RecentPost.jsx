import React from "react";
import "../../scss/component/DetailBlog/RecentPost.scss";
import axios from "axios";
export default function RecentPost() {
  const [data, setData] = React.useState([]);

  const getApi = async () => {
    axios
      .get("https://localhost:7292/api/BlogDetail/RecentPost?CategoryId=4")
      .then((res) => setData(res.data));
  };
  React.useEffect(() => {
    getApi();
  }, []);

  return (
    <div className="recent">
      {/* <div className="recent_header">
        <p className="recent_header_p">Search</p>
        <button className="recent_header_btn">
          Title... <button className="recent_header_btn_2">Search</button>
        </button>
      </div> */}
      <div className="recent_post">
        <p className="recent_post_border"></p>
        <p className="recent_post_p">Category</p>
        <div className="recent_post_ul">
          <p className="recent_post_ul_li">
            <button className="recent_post_ul_li_btn">Sport</button>
          </p>
          <p className="recent_post_ul_li">
            <button className="recent_post_ul_li_btn">Lifestyle</button>
          </p>
          <p className="recent_post_ul_li">
            <button className="recent_post_ul_li_btn">Design</button>
          </p>
        </div>
        <div className="recent_post_ul">
          <p className="recent_post_ul_li">
            <button className="recent_post_ul_li_btn">Promo</button>
          </p>
          <p className="recent_post_ul_li">
            <button className="recent_post_ul_li_btn">Modern</button>
          </p>
          <p className="recent_post_ul_li">
            <button className="recent_post_ul_li_btn">Brand</button>
          </p>
        </div>
      </div>
      <div className="recent_border2"></div>
      <div className="recent_Recent">Recent Post</div>
      <div className="recent_item">
        {data?.map((item, index) => (
          <div key={index} className="recent_item_index">
            <div className="recent_item_index_img">
              <img src={item.productDetails.productImage} alt="" />
            </div>
            <div className="recent_item_index_des">
              {item.productDetails.description}
              <p className="recent_item_index_p">8/2/19</p>
            </div>
          </div>
        ))}
      </div>
      <div className="recent_border3"></div>
    </div>
  );
}

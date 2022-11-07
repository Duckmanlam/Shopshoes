import React from "react";
import ava from "../../assets/img/ava.png";
import "../../scss/component/DetailBlog/Comment.scss";
export default function Comment() {
  return (
    <div className="Comment fex-mobile">
      <h4 className="Comment_header">Comment (1) </h4>
      <p className="Comment_border"></p>
      <div className="Comment_avatar">
        <div className="Comment_avatar_ul">
          <div className="Comment_avatar_ul_li">
            <img className="Comment_avatar_ul_li_img" src={ava} />
          </div>
          <div className="Comment_avatar_ul_li">
            <p className="Comment_avatar_ul_li_p">Ralph Edwards</p>
            <p className="Comment_avatar_ul_li_p2">8/2/19</p>
          </div>
        </div>
        <div className="Comment_avatar_reply">
          <p>Reply</p>
        </div>
      </div>
      <p className="Comment_p">
        Lorem ipsum dolor sit amet, consectetur adipiscing elit. A justo turpis
        massa tristique augue dignissim volutpat. Quis ultricies eu libero
        tortor dictumst.
      </p>
      <div className="Comment_reply">
        <h5 className="Comment_reply_header">Leave a Reply</h5>
        <p className="Comment_reply_p">Comment</p>
        <input type="text" className="Comment_reply_inp size-mobile"></input>
        <div className="Comment_reply_ul wrap-mobile">
          <div className="Comment_reply_ul_li">
            <p className="Comment_reply_ul_li_p">Name</p>
            <input
              type="text"
              className="Comment_reply_ul_li_input2 size-mobile"
            ></input>
          </div>
          <div className="Comment_reply_ul_li">
            <p className="Comment_reply_ul_li_p">Email</p>
            <input
              type="text"
              className="Comment_reply_ul_li_input2 size-mobile"
            ></input>
          </div>
        </div>
      </div>
      <div className="Comment_btn btn-mobile">
        <button className="Comment_btn_1 btn-mobile">Post Comment</button>
      </div>
    </div>
  );
}

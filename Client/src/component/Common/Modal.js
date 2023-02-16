import React from "react";
import "../../scss/component/Admin/Modal.scss";
import "../../scss/component/Admin/FromButton.scss";
const Modal = ({ isShowing, hide, deleteId }) =>
  isShowing ? (
    <React.Fragment>
      <div className="modal hoverModal">
        <p className="modal_p">Bạn có chắc chắn muốn xóa không?</p>

        <button type="button" className="Admin_remove" onClick={deleteId}>
          XÓA
        </button>
        <button
          type="button"
          className="Admin_not not"
          data-dismiss="modal"
          aria-hidden="true"
          onClick={hide}
        >
          KHÔNG
        </button>
      </div>
    </React.Fragment>
  ) : null;

export default Modal;

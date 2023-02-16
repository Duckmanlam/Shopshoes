import React from "react";
import { Link, useNavigate, useParams } from "react-router-dom";
import "../../scss/component/PageShop/responsive.css";
import "../../scss/component/PageShop/Shop.scss";
import axiosApi from "../../api/axios";
export default function Shop() {
  const [sort, setSort] = React.useState("");
  const [data, setData] = React.useState([]);
  const param = useParams();
  const navigate = useNavigate();
  const [page, setPage] = React.useState(1);

  React.useEffect(() => {
    if (param.search) {
      const getApi = async () => {
        axiosApi
          .get(`Products/AllProductInUser?search=${param.search}`)
          .then((res) => setData(res));
      };
      getApi();
    } else {
      const getApi = async () => {
        axiosApi
          .get(`Products/AllProductInUser?sortBy=${sort}&page=${page}`)
          .then((res) => setData(res));
      };
      getApi();
    }
  }, [param.search, navigate, sort, page]);

  return (
    <div className="Shop">
      <div className="grid wide">
        <div className="row">
          <div className="col l-3 m-12 c-12">
            <h1 className="Shop__heading">All Products </h1>
            {/* <p className="Shop__categories">Categories</p>
            <ul className="Shop__categories-list">
              <li className="Shop__categories-item">
                <Link to="#" className="Shop__categories-link">
                  Shoes (321)
                </Link>
              </li>
              <li className="Shop__categories-item">
                <Link to="#" className="Shop__categories-link">
                  Clothing (75)
                </Link>
              </li>
              <li className="Shop__categories-item">
                <Link to="#" className="Shop__categories-link">
                  Accessoris (135)
                </Link>
              </li>
            </ul>
            <RangePrice /> */}
          </div>
          <div className="col l-9 m-12 c-12 Shop__product">
            <div className="Shop__product-sort">
              <select
                className="Shop__product-sort-name abc"
                onChange={(e) => setSort(e.target.value)}
              >
                {" "}
                <option value="">SortBy</option>
                <option value="Price High - Low">Price High - Low</option>
                <option value="Price Low - High">Price Low - High</option>
                <option value="Newest">Newest</option>
                <option value="Featured">Featured</option>
              </select>
            </div>
            <div className="row Shop__product-wrapper">
              {data.map((item, index) => {
                return (
                  <Link
                    to={`/DetailWriteReview/${item.id}`}
                    key={index}
                    className="col l-4 m-6 c-12 Shop__product-item"
                  >
                    <img
                      src={item.productImage}
                      alt=""
                      className="Shop__product-item-img"
                    />
                    <div className="Shop__product-info">
                      <h1 className="Shop__product-info-name">
                        {item.productName}
                      </h1>
                      <span className="Shop__product-info-price">
                        ${item.price}
                      </span>
                    </div>
                    <span className="Shop__product-item-brandname">
                      {item.brandName}
                    </span>
                  </Link>
                );
              })}
            </div>
          </div>
          <button className="pageOne P1" onClick={() => setPage(1)}>
            page 1
          </button>
          <button className="pageOne" onClick={() => setPage(2)}>
            page 2
          </button>
        </div>
      </div>
    </div>
  );
}

import React from "react";
import { Route, Routes } from "react-router-dom";
import FromButton from "./component/Admin/FromButton";
import { AdminLayout, AppLayout, AuthLayout } from "./layout";
import {
  AllProduct,
  Blog,
  Carts,
  Des,
  DetailBlog,
  DetailReview,
  DetailWriteReview,
  Homepage,
  Login,
  PageShop,
  Res,
} from "./page";
import Order from "./component/Admin/Order.jsx";
import "./scss/index.scss";

export default function App() {
  return (
    <div>
      <Routes>
        <Route path="/" element={<AppLayout />}>
          <Route index element={<Homepage />} />
          <Route path="/DetailBlog/:id" element={<DetailBlog />} />
          <Route path="/Carts" element={<Carts />} />
          <Route path="/Des" element={<Des />} />
          <Route path="/Blog" element={<Blog />} />
          <Route path="/AllProduct" element={<AllProduct />} />
          <Route path="/PageShop" element={<PageShop />} />
          <Route path="/PageShop/:search" element={<PageShop />} />
          <Route
            path="/DetailWriteReview/:id"
            element={<DetailWriteReview />}
          />
          <Route path="/DetailReview" element={<DetailReview />} />
        </Route>

        <Route path="/" element={<AuthLayout />}>
          <Route path="login" element={<Login />} />
          <Route path="a" element={<Res />} />
        </Route>

        <Route path="/" element={<AdminLayout />}>
          <Route path="/Admin" element={<FromButton />} />
          <Route path="/Order" element={<Order />} />
        </Route>
      </Routes>
    </div>
  );
}

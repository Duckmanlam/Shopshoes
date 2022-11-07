import React from "react";
import { Routes, Route } from "react-router-dom";
import "./scss/index.scss";
import FromButton from "./component/Admin/FromButton";
import { AllProduct, Blog, Des, DetailBlog, DetailReview, DetailWriteReview, EmptySate, EmptyWishlist, Homepage, Login, PageShop, Res } from "./page";
import { AdminLayout, AppLayout, AuthLayout } from "./layout";
import Order from "./component/Admin/Order";

export default function App() {
  return (
    <div>
      <Routes>
        <Route path="/" element={<AppLayout />}>
          <Route index element={<Homepage />} />
          <Route path="/DetailBlog" element={<DetailBlog />} />
          <Route path="/EmptyState" element={<EmptySate />} />
          <Route path="/EmptyProduct" element={<EmptyWishlist />} />
          <Route path="/Des" element={<Des />} />
          <Route path="/Blog" element={<Blog />} />
          <Route path="/AllProduct" element={<AllProduct />} />
          <Route path="/PageShop" element={<PageShop />} />
          <Route path="/PageShop/:search" element={<PageShop />} />
          <Route path="/DetailWriteReview/:name" element={<DetailWriteReview />} />
          <Route path="/DetailReview" element={<DetailReview />} />
        </Route>


        <Route path="/" element={<AuthLayout />} >
          <Route path="/login" element={<Login />} />
          <Route path="/a" element={<Res />} />
        </Route>


        <Route path="/" element={<AdminLayout />} >
          <Route path="/From" element={<FromButton />} />
          <Route path="/t" element={<Order/>} />


        </Route>
      </Routes>
    </div>
  );
}
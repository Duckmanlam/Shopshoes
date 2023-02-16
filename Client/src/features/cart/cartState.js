// features/cart/cartState.js
import { atom, selector } from "recoil";

export const cartState = atom({
  key: "cart",
  default: JSON.parse(localStorage.getItem("cart")) ?? [],
});

export const addToCart = (cart, item, size) => {
  const newCart = [...cart];
  const foundIndex = cart.findIndex((x) => x.id === item.id);

  // Increase quantity if existing

  const productId = item.id;

  delete item.id;
  if (foundIndex >= 0) {
    newCart[foundIndex] = {
      ...cart[foundIndex],
      productId: productId,
      quantity: cart[foundIndex].quantity + 1,
      size: size,
    };
    return newCart;
  }

  // Add new item

  newCart.push({
    ...item,
    productId: productId,
    quantity: 1,
    size: size,
  });

  const storeCart = JSON.stringify(newCart);
  localStorage.setItem("cart", storeCart);

  return newCart;
};

export const cartTotal = selector({
  key: "cartTotal",
  get: ({ get }) => {
    const cart = get(cartState);
    return cart.reduce((total, item) => {
      return total + item.price * item.quantity;
    }, 0);
  },
});

export const removeCart = (cart, id) => {
  const newCart = cart.filter((item) => item.productId !== id);

  const storeCart = JSON.stringify(newCart);
  localStorage.setItem("cart", storeCart);

  return newCart;
};

import React from "react";
import axios from "axios";
import '../scss/component/Res/Res.scss';
import { useNavigate } from "react-router-dom";
export const Res = () => {
  const [userName, setUserName] = React.useState("");
  const [password, setPassword] = React.useState("");
  const [confirmPassword, setConfirmPassword] = React.useState("");
  const [phone, setPhone] = React.useState("");
  const [address, setAddress] = React.useState("");
  const [fullName, setFullName] = React.useState("");
  const [isAdmin] = React.useState(false);
  const navigate = useNavigate();

  const handleRes = async () => {
    let item = {
      userName,
      password,
      confirmPassword,
      isAdmin,
      phone,
      address,
      fullName,
    };
    await axios
      .post("https://localhost:7292/api/Account/Register", item)
      .then((res) => console.log(res));

    navigate("/login");
  };
  return (
    <div className="html">
      <div className="body">
        <div class="box">
          <div className="form">
            <h2 className="h2">Register</h2>
            <div class="inputBox">
              <input
                type="text"
                onChange={(e) => setUserName(e.target.value)}
                required
              />
              <span>Userame</span>
              <i></i>
            </div>
            <div class="inputBox">
              <input
                type="password"
                onChange={(e) => setPassword(e.target.value)}
                required
              />
              <span>Password</span>
              <i></i>
            </div>

            <div class="inputBox">
              <input
                type="text"
                onChange={(e) => setConfirmPassword(e.target.value)}
                required
              />
              <span>ConfirmPassword</span>
              <i></i>
            </div>
            <div class="inputBox">
              <input
                type="text"
                onChange={(e) => setPhone(e.target.value)}
                required
              />
              <span>Phone</span>
              <i></i>
            </div>
            <div class="inputBox">
              <input
                type="text"
                onChange={(e) => setAddress(e.target.value)}
                required
              />
              <span>Address</span>
              <i></i>
            </div>
            <div class="inputBox">
              <input
                type="text"
                oonChange={(e) => setFullName(e.target.value)}
                required
              />
              <span>Full name</span>
              <i></i>
            </div>
            <div class="links">
      
      
    </div>
            <input className="submit" type="submit" value="Register" onClick={() => handleRes()} />
          </div>
        </div>
      </div>
    </div>
  );
};

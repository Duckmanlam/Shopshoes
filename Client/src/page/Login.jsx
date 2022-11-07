import React from 'react';
import axios from 'axios';
import '../scss/component/Login/Login.scss';
import { useNavigate } from 'react-router-dom'
export const Login = () => {
    const [userName, setUserName] = React.useState("")
    const [password, setPassword] = React.useState("")
    const navigate = useNavigate()

    const handleLogin = async () => {
        let item = { userName, password }
        await axios.post('https://localhost:7292/api/Account/Login', item).then(res => localStorage.setItem('accessToken',res.data.accessToken)).catch(err => console(err))
        navigate('/')
    }
    return (
      <div className='body'>
      <div class="boxl">
  <div className='form'>
    <h2 className='h2'>Sign in</h2>
    <div class="inputBox">
      <input type="text" onChange={(e) => setUserName(e.target.value)} required />
      <span>Userame</span>
      <i></i>
    </div>
    <div class="inputBox">
      <input type="password" onChange={(e) => setPassword(e.target.value)} required />
      <span>Password</span>
      <i></i>
    </div>
    <div class="links">
      
      <a href="#">Signup</a>
    </div>
    <input type="submit" value="Login" onClick={() => handleLogin()}/>
  </div>
</div>
    </div>
    );
}


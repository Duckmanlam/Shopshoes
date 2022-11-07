import axios from "axios";

const axiosApi = axios.create({
    baseURL: 'https://localhost:7292/api/',
    headers: {
      "content-type": "application/json",
      "Access-Control-Allow-Origin": "*"
  },

  });


  // Thêm một bộ đón chặn request
axiosApi.interceptors.request.use(function (config) {

    const token = localStorage.getItem('accessToken')
    config.headers.authorization = `Bearer ${token}`
    return config;
  }, function (error) {
    // Làm gì đó với lỗi request
    return Promise.reject(error);
  });

// Thêm một bộ đón chặn response
axiosApi.interceptors.response.use(function (response) {
  if(response && response?.data) {
    return response.data
  }
    // Bất kì mã trạng thái nào nằm trong tầm 2xx đều khiến hàm này được trigger
    // Làm gì đó với dữ liệu response
    return response;
  }, function (error) {
    // Bất kì mã trạng thái nào lọt ra ngoài tầm 2xx đều khiến hàm này được trigger\
    // Làm gì đó với lỗi response
    return Promise.reject(error);
  });



  export default axiosApi
import React from 'react'
import { Outlet, useNavigate } from 'react-router-dom'

export function AdminLayout() {
  const [loading, setLoading] = React.useState(false)
  const navigate = useNavigate()

    React.useEffect( () => {
       const login = async  () => {
        const checkToken =  localStorage.getItem('accessToken')
        if(checkToken) {
          return setLoading(false)
        } else {
          navigate('/')
        }
        }
        login()
    },[navigate])
  return (
    loading ? 'Loading...' : <Outlet/>
  )
}

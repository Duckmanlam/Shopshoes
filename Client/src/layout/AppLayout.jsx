import React from 'react'
import { Outlet } from 'react-router-dom'
import Footer from '../component/homepage/Footer'
import Heder from '../component/homepage/Heder'

export function AppLayout() {
  return (
    <div>
        <Heder/>
        <Outlet/>
        <Footer/>
    </div>
  )
}

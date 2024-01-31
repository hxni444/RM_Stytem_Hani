import React from 'react'
import { Link,Outlet } from 'react-router-dom'

export default function layout() {
  return (
    <div>
      
        
        

        <nav class="navbar navbar-expand navbar-light bg-light">
            <ul class="nav navbar-nav">
                <li class="nav-item">
                    <Link to="/">Home</Link>
                </li>
                <li class="nav-item">
                    <Link to="about">About</Link>
                </li>
            </ul>
        </nav>
        <Outlet/>

        

      
    </div>
  )
}

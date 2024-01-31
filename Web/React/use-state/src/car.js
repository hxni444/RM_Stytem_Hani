import { useState } from "react";import React from 'react'

export default function Car() {
    const [color,setCol]=useState()
    const [year,setYear]=useState()
    const [model,setModl]=useState()
   
    

  return (
    <div class="container">
       <h1>My car is {model} {year} color {color}</h1>
       <button
        type="button"
        class="btn btn-outline-dark"
        onClick={()=>setCol("Black")}
       >
        color
       </button>
       <button
        type="button"
        class="btn btn-outline-primary"
        onClick={()=>setModl("Mustang")}
       >
        model
       </button>
       <button
        type="button"
        class="btn btn-outline-info"
        onClick={()=>setYear(1969)}
       >
        year
       </button>
       
       
       

       
    </div>
  )
}

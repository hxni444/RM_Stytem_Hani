import { useState } from "react";

export default function Objects() {
    const [{name,id,mail},setState]= useState({name:'hani',id:456,mail:'hani@gmail.com'})
    function setVal() {
        setState((prevoiuseState)=>({
            ...prevoiuseState,
            name:'faris',
            id:id,
            mail:'fasri@ganil.com'

        })
      
        )

   
        
    }
    
            


  return (
    <div>
      <h1>name:{name}</h1>
      <h1>id:{id}</h1>
      <h1>Mail:{mail}</h1> 
      <button
      onClick={setVal}
        type="button"
        class="btn btn-primary"
      >
        Button
      </button>
      
    </div>
  )
}

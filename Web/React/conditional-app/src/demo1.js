import React from 'react'

function User() {
  return (
    <div>
        <h1>Welcome User</h1>
    </div>
  )
}


 function Guest() {
  return (
    <div>
      <h1>Welcome Guest.....</h1>
    </div>
  )
}


 function login(props) {
    let islogged=props.islogged
//     if(islogged)
//   return (
//     <div>
//         <User/>
//     </div>
//   )
//   else return(
//     <di>
//         <Guest/>
//     </di>
//   )
return islogged?<User/>:<Guest/> 
}
export default login




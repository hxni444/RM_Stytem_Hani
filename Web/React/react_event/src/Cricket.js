import React from "react";
const Cricket = () => {
//    const Greet = () => {
//     alert("good moring")
         
//     };   
 const Greet = (e) => {
    alert('Greetings '+e);
     
 };

return(
    <div>
        <button onClick={()=>Greet('Hani')}>greet me</button>
    </div>

)
};
 
export default Cricket
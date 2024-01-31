import React, {useState} from "react";
function Col ()
 {
    const [color , setCol] = useState('red')
    function changeCol() {
        setCol("geen")
    }
    
 
    return (
        <div>
            <h2>
                MY Fav col is {color}
            </h2>
            {/* <button onClick={changeCol}>click me</button> */}
            <input
                name=""
                
                class="btn btn-primary"
                type="button"
                value="Button"
            />
             <button
             onClick={changeCol}
                type="button"
                class="btn btn-outline-primary"
             >
                Button
             </button>
             
                     
            
        </div>
      );
}

export default Col ;
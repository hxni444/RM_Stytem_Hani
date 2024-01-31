import { useState } from "react";
const cls=[1,2,3,5,5,4,7]
function Myform() {
    const [std,setStd]=useState(1)
    
    return ( 
        <div>
            <select onChange={(e)=>setStd(e.target.value)}>
                {
                    cls.map(i=><option>{i}</option>)
                }

            </select>
            <p>Yo have selected {std}</p>
        </div>
     );
}

export default Myform;
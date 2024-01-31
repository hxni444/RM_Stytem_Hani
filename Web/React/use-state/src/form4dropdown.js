import { useState } from "react";
function Myform() {
 let courseList = [
    {id:1,name:'sql'},
    {id:2,name:'react'},
    {id:3,name:'.net'},
    {id:4,name:'c#'},
    {id:5,name:'css'},
]
    const [course,setCourse]=useState({id:0,name:''})
    return ( 
        <div>
            <select onChange={(e)=>setCourse({id:e.target[e.target.selectedIndex].value
            ,name:e.target[e.target.selectedIndex].text
            })}>
                {
                    courseList.map(i=><option>{i.name}</option>)
                }
            </select>
            <p>Your selected couese is {course.name} and id is {course.id}</p>

        </div>
     );
}

export default Myform;
import { useState } from "react";
function MyForm() 
{
    let StdList = [
        {id:1,name:'hani',age:22,std:12},
        {id:2,name:'nuha',age:20,std:1},
        {id:3,name:'nihal',age:7,std:2}
    ]
    const [list,setList]= useState(StdList)
    const [id,setId]=useState(0)    
    const [name,setName]=useState('')
    const [age,setAge]=useState(0)
    const [std,setStd]=useState(0)
    const save = (e) => {
        setList([...list,
            {
        id:id,
        name:name,
        age:age,
        std:std}
        
        ])
        e.preventDefault()
    };
    return (
        <div>
            <form onSubmit={save}>
                <div
                    class="table-responsive"
                >
                    <table
                        class="table table-primary"
                    >
                      
                        <tbody>
                            <tr class="">
                                <td>id:<input type="number" value={id} onChange={(e)=>setId(e.target.value)}/></td>
                            </tr>
                            <tr class="">
                                <td>name:<input type="text" value={name} onChange={(e)=>setName(e.target.value)}  /></td>
                            </tr>
                            <tr class="">
                                <td>age:<input type="number" value={age} onChange={(e)=>setAge(e.target.value)}/></td>
                            </tr>
                            <tr class="">
                                <td>std:<input type="number" value={std} onChange={(e)=>setStd(e.target.value)}/></td>
                            </tr>
                            
                        </tbody>
                    </table>
                </div>
                <button
                    type="submit"
                    class="btn btn-primary"
                >
                    submit
                </button>
                
                
            </form>
            
           <hr/>
                <div
                    class="table-responsive"
                >
                    <table
                        class="table table-primary"
                    >
                        <thead>
                            <tr>
                                <th scope="col">ID</th>
                                <th scope="col">Name</th>
                                <th scope="col">Age</th>
                                <th scope="col">Class</th>
                            </tr>
                        </thead>
                        <tbody>
                {list.map((student) => {
              return (
                <tr>
                  <td>{student.id}</td>
                  <td>{student.name}</td>
                  <td>{student.age}</td>
                  <td>{student.std}</td>
                </tr>
              );
                 })
                 }
                        </tbody>
                    </table>
                </div>
                
            
        </div>
      );
}

export default MyForm;
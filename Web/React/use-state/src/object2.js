import { useState } from "react";
import React from 'react'

export default function Object2() {
    const [students,setState] = useState({id:456,name:'hani'})
    const setval=()=>{
        setState((prevoiuseState)=>({
            ...prevoiuseState,
            id:123,
            name:'koli'
        }

        ))
    }
  return (
    <div>
        <div
            class="table-responsive"
        >
            <table
                class="table table-primary"
            >
                <thead>
                    <tr>
                        <th scope="col">Id</th>
                        <th scope="col">name</th>
                        <th></th>
                  
                    </tr>
                </thead>
                <tbody>
                    <tr class="">
                        
                        <td>{students.id}</td>
                        <td>{students.name}</td>
                        <td><button
                            type="button"
                            class="btn btn-primary"
                            onClick={setval}
                        >
                            Button
                        </button>
                        </td>
                    </tr>
                  
                </tbody>
            </table>
        </div>
        
      
    </div>
  )
}

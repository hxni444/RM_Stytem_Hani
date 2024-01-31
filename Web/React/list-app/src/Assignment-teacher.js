import { useState } from "react";
import React from 'react'

export default function Assignment_teacher() {
    const[teachers,SetVal]= useState({id:456,tName:'Sanu',tSub:'core',tStd:[5,3]})
   const updateTeacg= () => {
        SetVal((prvst)=>({
            ...prvst,
            tSub:'core2',
            tStd:[12,5]
        }))
             
        
         
    };
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
                    <th scope="col">ID</th>
                    <th scope="col">teacher Name</th>
                    <th scope="col">Std</th>  
                    <th></th>
                    <th scope="col">Subject</th>
                    <th></th>
                    
                </tr>
            </thead>
            <tbody>
                <tr class="">
                   
                    <td>{teachers.id}</td>
                    <td>{teachers.tName}</td>
                    {/* <td>{teachers.tStd}</td> */}
                    <td>
                    {
                        teachers.tStd.map(i=><td>{i}</td>)
                    }

                    </td>
                   
                    <td>{teachers.tSub}</td>
                    <td>
                        <button
                            type="button"
                            class="btn btn-primary"
                            onClick={updateTeacg}
                        >
                            Update
                        </button>
                        
                    </td>
                </tr>
               
            </tbody>
        </table>
      </div>
      
    </div>
  )
}

import { useState } from "react";
const Form = () => {
    const [uname,setName]= useState('')
    const [mssg, setMssg] = useState('')
    
    const submit = (e) => {
        e.preventDefault()
        //  alert('hello ' + uname)
        setMssg('hello '+ uname)

    };
    return( <div>
        <div class="container">
            <form onSubmit={submit}>
                <div class="mb-3">
                    <label for="" class="form-label">Name</label>
                    <input
                        type="text"
                        class="form-control"
                        name=""
                        id=""
                        aria-describedby="helpId"
                        placeholder=""
                        onChange={(e)=>setName(e.target.value)}
                        
                        
                        
                    />
                   
                </div>
               <button class="btn btn-info" type="submit">
                submit
               </button>
               <p className="bg-primary  text-center"> {mssg}</p>
               
     </form>
        </div>
        
    </div>)
     
};
export default Form
import { useState } from "react";
function ArryTble() {
    const [name,setName]= useState([])
    const [nam,setN] = useState('')
    const addName = (e) => {
        
        
       setName([...name,nam])
       e.preventDefault()
        
         
    };
    return (
        <form onSubmit={addName}>
            <input type="text" onChange={(e)=>setN(e.target.value)}/>
        
        <div
            class="table-responsive"
        >
            <table
                class="table table-primary"
            >
                <thead>
                    <tr>
                        <th scope="col">Name</th>
                        
                    </tr>
                </thead>
                <tbody>
                    {
                        name.map((i)=>(<tr><td>{i}</td></tr>))
                    }
                </tbody>
            </table>
        </div>
        <button type="submit">submit</button>
        </form>
        
      );
}




 
const Ex1 = () => {
  const [inputValue, setInputValue] = useState('');
  const [tableData, setTableData] = useState([]);
 
  const handleInputChange = (e) => {
    setInputValue(e.target.value);
  };
 
  const handleButtonClick = () => {
   
    const newTableData = [...tableData];
    newTableData.push(inputValue);
   
    setTableData(newTableData);
    setInputValue('');
  };
 
  return (
    <div>
      <input type="text" value={inputValue} onChange={handleInputChange} />
      <button onClick={handleButtonClick}>Add to Table</button>
 
      <table>
        <thead>
          <tr>
            <th>Values</th>
          </tr>
        </thead>
        <tbody>
          {tableData.map((value) => (
            <tr>
              <td>{value}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
};
 
// export default Ex1;


export default ArryTble;
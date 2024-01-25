const Student=({ name, age, std })=>{
    return (
            <tr>
                <td>{name}</td>
                <td>{age}</td>
                <td>{std}</td>   
            </tr>);
    

}

const classRoom=()=>{
    return <table className="table table-primary">
            <thead>
                <tr>
                    <th>Name</th>
                    <th>age</th>
                    <th>std</th>
                </tr>
            </thead>
            <tbody>
                
                   <Student name="Hani" age="25" std="12"/>
               
            </tbody>
    </table>
}
export default classRoom;
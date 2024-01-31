function Student() {
    let students = 
    [
        {id:Math.floor(Math.random()*999), name:'Hani' , Age:15},
        {id:Math.floor(Math.random()*999), name:'Mohan' , Age:45},
        {id:Math.floor(Math.random()*999), name:'Dony' , Age:15},
        {id:Math.floor(Math.random()*999), name:'Hari' , Age:75},
        {id:Math.floor(Math.random()*999), name:'Haalk' , Age:35},
        {id:Math.floor(Math.random()*999), name:'Habil' , Age:41}
    ]
    return ( 
        <table className="table table-striped">
            <thead className="table-dark">
                <tr>
                    <th>ID</th><th>Name</th><th>Age</th>
                </tr>
            </thead>
            <tbody>
                {
                    students.map(i=><tr><td>{i.id}</td><td>{i.name}</td><td>{i.Age}</td></tr>)
                }
                
            </tbody>
        </table>
     );
}

export default Student

function cities(props) {
    return ( 
        <table className="table table-striped">
            <thead className="table-dark" >
                
                    <tr>
                    <   th>Cities</th>
                    </tr>
                   
               
            </thead>
            <tbody>
               
                    {
                        props.city.map(i=><tr><td>{i}</td></tr>)
                    }
                
            </tbody>
        </table>

     );
}

export default cities;
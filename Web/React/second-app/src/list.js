
function List() {
    let lists =['sid','dan','tdm','r-series']
    const newLi = lists.map(i=><li>{i}</li>)
    return (

        <div className="container">
            <ul>
                {lists.map(i=><li>(i)</li>)}
                <hr/>
                {newLi}
            </ul>
            <table className="table table-striped w-25">
                <thead className="table-primary">
                    <tr>
                        <th>Names</th>
                    </tr>
                </thead>
                <tbody>
                    {lists.map(i=><tr><td>{i}</td></tr>)}
                </tbody>
            
        </table>
        </div>
        
      );
}

export default List;
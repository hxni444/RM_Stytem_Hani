function color() {
    let colors=['black','white','red','yellow']
    return (
        <div>
            <table>
                <thead>
                    <tr>
                        <th> COLOURS</th>
                    </tr>
                </thead>
                <tbody>
                    {
                        colors.map(i=><tr><td>{i}</td></tr>)
                    }
                </tbody>
            </table>
        </div>
      );
}

export default color;

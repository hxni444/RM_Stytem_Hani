function Cities (props) {
    return (
        <tbody>
            <tr>
                <td>Kerala have {props.city}</td>
            </tr>
        </tbody>
      );
}

function Kerala () {
    let city=['kozhikode','kochi','kollam','kunnagulam']
    city.sort()
    return (
        <table>
            <thead>
                <tr>
                    <th>Cities</th>
                </tr>
            </thead>
            {
                city.map(i=>(<Cities city={i}/>))
            }
        </table>
      );
}


export default Kerala
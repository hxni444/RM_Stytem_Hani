const Car=(props)=>{
    return <div>
            <h1>The Brand is {props.band}</h1>
            <h1>The color is {props.color}</h1>
    </div>

}
const Garage = (props)=>{
   
    return <di>
        <Car band='bently' color='black'></Car>
        <Car band={props.brand} color={props.color}></Car>
    </di>
}
export default Garage
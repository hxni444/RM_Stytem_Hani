const Exmple=() => {
    let x= 3
    let mssg=''
    if(x>0){
        mssg="good motning"
    }
    else 
    mssg='bad morning'
    return <div>
            <p>
                {mssg} everyone
            </p>
    </div>
}
export default Exmple
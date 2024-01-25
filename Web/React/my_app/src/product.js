const Product=(props) =>{
    return <div>
            <p>
                name:{props.item.name}
                Price:{props.item.price}
                Stock:{props.item.stock}
            </p>
    </div>


}
const shop=()=>{
    return <div>
        <Product item={{name:"iphone", price:455545 , stock:5 }}/>
    </div>
}
export default shop
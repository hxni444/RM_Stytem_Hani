import React from "react";
class Number extends React.Component {
    constructor() {
        super();
        this.state = {
            Num:0
          }
    }
    Increment=() => {
        this.setState({
            Num:this.state.Num+1
        })
         
    };
    Decre = () => {
        this.setState({
            Num:this.state.Num-1
        })
         
    };
 
    render() { 
        return (
            <>
           
            <h1>The Number is{this.state.Num}</h1>
            <button style={{fontSize:"2rem"}} onClick={this.Increment}>+</button>
            <button style={{fontSize:"2rem"}} onClick={this.Decre}>-</button>
            
            </>
          );
    }
}
 
export default Number
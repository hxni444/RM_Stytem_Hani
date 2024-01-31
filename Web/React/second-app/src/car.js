import React from "react";
class Car extends React.Component {
   
    render() { 
        return (
            <div>
                <h2>
                    I am a car with a {this.props.color} color
                </h2>
            </div>
        );
    }
}
 
class Garage extends React.Component {
   
    render() { 
        return (
            <>
            <Car color='red'></Car>
            </>
        );
    }
}
 

export default Garage ;
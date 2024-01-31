import React from "react";
class Student extends React.Component {
    constructor(){
        super()

   
    this.state = { 
        std:'5',
        Name:'Hani'
     } 
    }
    ChangeState = () => {
      this.setState({
        std:'10'
      });
         
    };

    render() { 
        return (
            <div>
                <h1>i am {this.state.Name} studedying in {this.state.std}</h1>
                <button onClick={this.ChangeState}>Click to change</button>
            </div>
            
        );
    };

}
 
export default Student;
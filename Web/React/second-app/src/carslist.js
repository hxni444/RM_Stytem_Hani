import React from 'react'

function Carslist(props) {
  return (
    <div>
      <li> i am a {props.brand}</li>
    </div>
  )
}
function gar() {
    let list = ['lambo','audi','bmw','bently']
    return (
        <div>
            {
                list.map(i=>(<Carslist brand={i} />))
            }
        </div>
      );
}

export default gar;

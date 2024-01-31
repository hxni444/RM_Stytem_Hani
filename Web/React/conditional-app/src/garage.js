import React from 'react'

export default function Garage(props) {
    const car =props.cars
  return (
    <div>
      <h1>porch have {car.length>0?(<p>{car.length} cars</p>):(<p>porch dont have any car</p>)}</h1>
    </div>
  )
}

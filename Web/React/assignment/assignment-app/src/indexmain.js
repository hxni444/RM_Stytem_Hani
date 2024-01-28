import Download  from './doenload icon.svg'
import  bulls from './bullseye.svg'
export default function Main(){
    return(
        <div>
          <main class="text-center wrapper">

<div class="container">
  <div class="d-sm-flex justify-content-between my-5">
    <div class=" text-sm-start pt-5">
      <h1 class="content">I AM A<br/> DEVELOPER</h1>
      {/* <button class="Resume_btn"><img src={Download} style={{"width: 2rem; margin-right: 1rem"}} alt=""/>Resume</button> */}
      <button className="Resume_btn">
        <img src={Download} style={{ width: '2rem', marginRight: '1rem' }} alt="" />
        Resume
        </button>

    </div>

   
  
    <img src={bulls} class="img-fluid  mt-4 px-5 " style={{width: "35rem"}}/>
    </div>

    </div>
    

</main>

        </div>
        
    )
}
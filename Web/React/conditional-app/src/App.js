import logo from './logo.svg';
import './App.css';
import Demo1 from './demo1'
import Garage from './garage';

function App() {
  let cr=['c-class','ktm']
  return (
    <div className="App">
      {/* <Demo1 islogged={true}/>
      <Demo1 islogged={false}/> */}
      <Garage cars={cr}/>
    </div>
  );
}

export default App;

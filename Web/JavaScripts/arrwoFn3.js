function fn(f1,f2){
    console.log(f1());
    console.log(f2());
}

fn(()=>'hello man',()=>'hi bros')
//callback
//setTimeout(()=>console.log('hello every one'),3000)

const gr= ()=>'hellllo'

 
console.log(gr());
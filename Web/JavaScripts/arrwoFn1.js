const greet = (name)=>'hello'+name;
console.log(greet('hani'))

let sum = (a,b,c) => a+b+c
console.log(sum(4,5,1))

let arrsum= (a) =>{
    reslut=0
    for(let k of a){
        reslut=reslut+k
    }
    return reslut
}
console.log(arrsum([4,5,2,5,4,8,1,4,6]));

function greets(name){
    return 'hello'+ name
}
console.log(greets('hanieeeeee'))
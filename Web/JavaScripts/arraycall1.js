let no=[12,5,1,54,6,5,1,64,6,1,21]

let x = no.filter((i)=> i>10)

no.forEach(i=> console.log(i))

console.log()
x= no.find(i=> i % 2 ==0)
console.log(x)


x = no.map(i=> i*i)
console.log(x)

let student = 
[
    {d:456,name:'jetly',job:'mechanic'},
    {d:454,name:'james',job:'electrician'},
    {d:325,name:'jhon',job:'IT tech'},
    {d:785,name:'job',job:'software rng'},
    {d:321,name:'jonny',job:'dpctor'},
    {d:965,name:'jober',job:'plumber'},

]

let newar= student.map(i=>i.d+i.name)
console.log(newar)


const nae = ['hani','loki','jponny']
newar = nae.map((i)=>{
    let m = i[0].toUpperCase()+i.slice(1,i.length()); 
     return m
    }
     );
console.log(newar)

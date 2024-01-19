let student = 
[
    {d:456,name:'jetly',job:'mechanic'},
    {d:454,name:'james',job:'electrician'},
    {d:325,name:'jhon',job:'IT tech'},
    {d:785,name:'job',job:'software rng'},
    {d:321,name:'jonny',job:'dpctor'},
    {d:965,name:'jober',job:'plumber'},

]
const findStd=(id) =>{
    for(let k of student)
    {
        if(k.d == id)
        return k

    }
    return null
}
console.log(findStd(785))

const allStd=() =>{
    for(let k of student)
    {
        
    console.log(`id:${k.d} anme:${k.name} job:${k.job}`)
    }
}
console.log(allStd())


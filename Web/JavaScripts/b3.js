let m1= 45
m2= 53
m3= 52
m4= 45
m5= 78

let grade= ''
let total = m1+m2+m3+m4+m5
if(m1>40&&m2>40&&m3>40&&m4>40&&m5>40)
{
    if(total>=450)
    grade = 'disticntion'
    else if(total>=300 && total<450)  
    grade='first class'
    else if(total>=250 && total<300)
    grade='second class'  
    else if(total<250)
    grade='you are failed' 
}
 

console.log(`total:${total} Average: ${m1+m2+m3+m4+m5/5} grade:${grade}`)



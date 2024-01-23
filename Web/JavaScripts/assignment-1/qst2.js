class Student{
    constructor(RollNo, StudName,   MarksInEng,MarksInMaths,MarksInScience)
    {
    this.RollNo=RollNo;
    this.StudName=StudName;
    this.MarksInEng=MarksInEng;
    this.MarksInMaths=MarksInMaths;
    this.MarksInScience=MarksInScience;
    }
    
    total(){
        let total=this.MarksInEng + this.MarksInMaths + this.MarksInScience
        let perc=total/3
        console.log(`Percentage:${perc}`)
        console.log(`RollNo: ${this.RollNo} Student Name: ${this.StudName} Total Marks: ${total}\nPerentage:${perc}`);
        
        
    }
}
let obj=new Student(10,"Jis",98,97,96);
obj.total();


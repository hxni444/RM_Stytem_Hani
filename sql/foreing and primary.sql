CREATE TABLE Dept
(
Dept_code int primary key,
deptm_name varchar(30) unique not null,
)

create table Employee
(
emp_id int , 
name varchar(30),
joindate date default getdate(),
salary int check(salary>0),
Deptcode int,
constraint Dept_Fk foreign key(Deptcode) references Dept(Dept_code) on delete cascade
) 
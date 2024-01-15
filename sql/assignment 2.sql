create database Assignment
create table Department (Dept_no varchar(30),Dept_name varchar(30), location varchar(30))
insert into Department values
('d1' ,'Research' ,'Dallas'),
('d2' ,'Accounting' ,'Seattle'),
('d3' ,'Marketing' ,'Dallas')

create table Employee (emp_no varchar(30), emp_fname varchar(30), emp_lname varchar(30), dept_no varchar(30))
insert into Employee values
('25348',' Matthew' ,'Smith',' d3'),
('10102',' Ann' ,'Jones',' d3'),
('18316',' John' ,'Barrimore',' d1'),
('29346',' James' ,'James',' d2')

create table Project (project_no varchar(30), project_name varchar(30), Budget int )
insert into Project values
('p1', 'Apollo', 120000),
('p2', 'Gemini', 95000),
('p3', 'Mercury', 185600)

create table Works_on (emp_no varchar(30), project_no varchar(30), Job varchar(30), enter_date date)
insert into Works_on values
('10102', 'p1' ,'Analyst', '1997.10.1'),
('10102', 'p3' ,'manager', '1999.1.1'),
('25348', 'p2' ,'Clerk', '1998.2.15'),
('18316', 'p2' ,null, '1998.6.1'),
('29346', 'p2' ,null , '1997.12.15'),
('2581', 'p3' ,'Analyst', '1998.10.15'),
('9031', 'p1' ,'Manager', '1998.4.15'),
('28559', 'p1' ,null, '1998.8.1'),
('28559', 'p2' ,'Clerk', '1992.2.1'),
('9031', 'p3' ,'Clerk', '1997.11.15'),
('29346', 'p1' ,'Clerk', '1998.1.4')


select * from Works_on --qstion 1
select emp_no from Employee --qst 2
select emp_no from Works_on where project_no='p2' and emp_no<10000 --qst 3
select emp_no from Works_on where year(enter_date)!=1998 --qst 4
select emp_no from Works_on where job in ('Analyst','Manager') and project_no ='p1' --qst 5
select enter_date from Works_on where project_no ='p2' and job is null --qst 6
select emp_no,emp_lname from Employee where emp_fname like '%tt%' -- qst 7
select emp_no,emp_fname from Employee where emp_lname like '_[ao]%es'



select * from Employee
select * from Dept
insert into Dept values
(001,'production'),
(002,'admin'),
(003,'secutiy'),
(004,'devops')

insert into Dept values (005,'developer')

insert into Employee values
(456,'mani',GETDATE(),45552,001),
(455,'mani',GETDATE(),53534,002),
(204,'mani',GETDATE(),40552,001),
(224,'mani',GETDATE(),27555,003),
(755,'mani',GETDATE(),52527,001),
(385,'mani',GETDATE(),72787,004),
(789,'mani',GETDATE(),87285,002),
(536,'mani',GETDATE(),72575,003),
(789,'mani',GETDATE(),28272,001)
(789,'mani',GETDATE(),28272,001)
update Employee set Deptcode =null where emp_id = 536


select * from Dept join Employee on Deptcode = Dept_code

select e.emp_id,e.name,e.joindate,d.Dept_code,d.deptm_name from Employee e join Dept d on e.Deptcode=d.Dept_code
select e.emp_id,e.name,e.joindate,d.Dept_code,d.deptm_name from Employee e left outer join Dept d on e.Deptcode=d.Dept_code
select e.emp_id,e.name,e.joindate,d.Dept_code,d.deptm_name from Employee e right outer join Dept d on e.Deptcode=d.Dept_code
select e.emp_id,e.name,e.joindate,d.Dept_code,d.deptm_name from Employee e full outer join Dept d on e.Deptcode=d.Dept_code


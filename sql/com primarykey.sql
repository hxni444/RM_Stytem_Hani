create table student(
[Sid] int,
[name] varchar(30) not null,
mobile varchar(20),
constraint ComKey primary key([Sid],mobile))

insert into student values (1,'hari',5222522)
insert into student values (2,'rohan',5222522)
insert into student values (3,'manu',1112221112),(4,'hani',8075754243)

--updae

update student set mobile=22552255 where [Sid]=1
delete from student
delete from student where Sid=2
update student set std=5

--alter
alter table student add sec char(1) 
alter table student drop column name
alter table student alter column std int

select * from student
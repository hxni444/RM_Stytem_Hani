create database assement
create table Subject (subjectId int,subtitle varchar(20))
create table Book (bookId int,title varchar(20),price int,volume int,author varchar(20),publishDate Date,subjectId int)

insert into Subject values 
(106,'maths'),
(101,'English'),
(102,'tamil'),
(103,'malayalam'),
(104,'urdu'),
(105,'arabic')


insert into Book values 
(111,'TAMIL',200,2,'ROHAN','2003.12.22',101),
(112,'MALAYALAM',500,5,'MANU','2003.11.6',102),
(113,'ARABIC',244,3,'JAMES','2003.10.12',101),
(114,'URDU',254,5,'MIKE','2003.9.22',101),
(115,'SCIENCE',757,5,'XAVI','2003.10.2',103),
(116,'MATHS',577,5,'LOPEZ','2003.2.9',101),
(117,'BIOLOGY',897,8,'JOHN','2003.1.14',101),
(118,'CHEMISTRY',258,9,'ROHAN','2003.6.25',103),
(119,'PHYSICS',225,2,'RIVA','2003.8.26',101),
(120,'MECHANICS',764,3,'ANURIDH','2003.9.12',104),
(121,'BASCI MECHANICAL',578,3,'MOHAN','2003.3.4',105),
(122,'C',652,6,'POXI','2003.2.23',102),
(123,'CPP',726,6,'MORATH','2003.1.12',102),
(124,'JAVA',552,7,'ROHAN','2003.5.30',101),
(125,'PYTHON',237,8,'HATHWAY','2003.4.22',105),
(126,'ENGLISH',237,8,'JAKE','2003.4.2',105)

select s.subjectId,s.subtitle,b.bookId,b.title,b.price,b.volume,b.author,b.publishDate,b.subjectId from Subject s join Book b on b.subjectId=s.subjectId --qst 3

select * from Book where  publishDate between   '2003-05-30' and  '2003-12-22'--qst 4

select author,count(*) as 'NO. of books' from Book group by author --qst 5

select title,count(*) as 'NO. of books' from Book group by title --qst 6

select * from Book where year(publishDate) = 2000 -- qst 7

update Book set price = 1000,volume =10  where bookId = 123 --qst 8
select * from Book

update Book set price = price + price*0.10 where title = 'ENGLISH' --qst 9
select * from Book

delete from Book where bookId = 114; --qst 10
select * from Book

select * from Book where price>500 and title = 'MATHS' --QST 11
select * from Book where price>500 and title=  (select subtitle from [Subject] where subtitle = 'maths') --QST 11

select s.subjectId,s.subtitle,b.bookId,b.title,b.price,b.volume,b.author,b.publishDate,b.subjectId from Subject s join Book b on b.subjectId=s.subjectId order by s.subtitle --qst 12

select * from Book where price = (select min(price) from Book) -- QST 13
select * from Book where price = (select max(price) from Book) -- QST 14

select count(*) AS 'COUNT' from Book where title= 'MATHS' --QST 15

select * from Book where title in ('english','maths','science') --qst 16










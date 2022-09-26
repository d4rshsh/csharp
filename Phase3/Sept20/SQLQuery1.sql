use library;


--PS1
create table Member
(
MemberId numeric(5) primary key,
Member_Name char(25),
Acc_Open_Date Date,
Max_Book_sAllowed numeric(2),
Penalty_Amount numeric(7,2));

create table Book
(
Book_No numeric(6) primary key,
Book_Name varchar(30),
Author char(30),
Cost numeric(7,2),
Category char(10)
);

create Table Issue
(
Lib_Issue_Id numeric(10), 
Book_No numeric(6) ,
MemberId numeric(5)  ,
Issue_Date Date,
Return_Date Date
);

-- PS 2 
EXEC sp_help 'dbo.Book';
EXEC sp_help 'dbo.Issue';
EXEC sp_help 'dbo.Member';

--PS3
alter table Issue
add Comments char(100); -- ADDING NEW COLUMN

--PS4
alter table Member
alter column Member_Name char(30); -- ALTERING EXISTING COLUMN

--PS5
alter table Issue
add Reference char(30);

--PS6
alter table Issue
drop column Reference; -- Deleting/Dropping column from table

--PS7
EXEC sp_rename 'Issue', 'Lib_Issue'; -- renaming table

--PS8 
insert into Member values(1,'Richa Sharma','2005-05-10',5,50),
                         (2,'Garima Sen',GETDATE(),3,null),
                         (3,'Seshan Sundar','2002-06-03',null,200),
                         (4,'Sonia Sivaprakash',GETDATE(),5,null),
                         (5,'Pratibha Sukumar',null,4,150);

--PS9
alter table Member
alter column Member_name char(20); --ALTER COLUMN

--PS10
insert into Member values(6,'Laksha',getdate(),110,100);
--Arithmetic overflow error converting int to data type numeric.
--(because it is 3 digit ,max books this column will allow only 2 digit numbers.

--PS11
select * into Member101 from Member where 1 = 2;

--PS12
insert into Book values(101,'Let us C','Denis Ritchie',450,'System'),
                       (102,'Oracle-complete Ref','Loni',550,'database'),
					   (103,' Mastering SQL','Loni',250,'database'),
					   (104,' PL SQL-Ref','Scott Urman',750,'database'),
					   (106,'Oracle Ref','Denis Ritchie',550,'database') ,
					   (107,'SQL ref','Scott Urman',250,'System');

--PS13

--PS14 and 15
select * into Book101 from Book;
--PS17
select * from Book101;
select * from Book;
select * from Member;
select * from Member101;
select * from Lib_Issue;
--PS 18
insert into Book values(105, 'National Geographic', 'Adis Scott', 1000, 'Science');

--PS20 // Modify the price of book with id 103 to Rs 300 and category to RDBMS

update Book
set cost=300 , category='RDBMS'
where Book_no=103 

--PS21 Rename the table Lib_Issue to Issue.
EXEC sp_rename 'Lib_Issue', 'Issue'

--PS22
insert into Issue values(7001,101,1,'2006-12-10',null),
(7002,102,2,'2006-12-25',null),
(7003,104,1,'2006-01-15',null),
(7004,101,1,'2006-07-04',null),
(7005,104,2,'2006-11-06',null),
(7006,101,3,'2006-02-18',null);

select * from Issue;

alter table Issue 
drop column Comments;

--PS24  dateadd 
update Issue
set Return_Date= dateadd(day,15,Issue_Date)
where Lib_Issue_Id=7004 

--PS25
update Member
set Penalty_Amount = 100
where member_Name = 'Garima Sen';
select * from Member;

--PS26     Remove all the records from Issue table where member_ID is 1 and Issue date in before 10-Dec-06. 
delete from Issue
where MemberId=1 and Issue_Date < '2006-12-10';

--PS27     Remove all the records from Book table with category other than RDBMS and Database.
select * from Book;
delete from Book
where Category!='RDBMS' and Category !='Database' ;

--PS28 
drop table Member101;
--PS29
drop table Book101;

--PS30
EXEC sp_help 'dbo.Book';
EXEC sp_help 'dbo.Issue';
EXEC sp_help 'dbo.Member';

--PS31 list all tables

SELECT name
FROM sys.tables

SELECT *
FROM Library.INFORMATION_SCHEMA.TABLES


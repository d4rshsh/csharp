use Library

create table Member_C(
Member_Id int Primary Key Not null,
Account_Open_Date Datetime,
Max_Allowed_Books numeric,
Penalty_Amount money
)

Alter table Member_C
Add constraint def_date_account
Default getdate() for Account_Open_Date;

Alter table Member_C
Add constraint allowed_max
check (Max_Allowed_Books <100)

Alter table Member_C
Add constraint allowed_penalty
check (Penalty_Amount <1000)

create table Book_C(
Book_No numeric primary key not null,
Book_Name varchar(25) not null,
Category varchar(30) check(Category='Science' or Category='Fiction' or Category='Database' or Category='RDBMS' OR Category='Others')
)

Create table Issue_C(
Lib_Issue_Id numeric primary key not null,
Member_Id numeric ,
Book_No numeric,
Issue_Date DateTime,
Return_Date DateTime 
)

Alter table Issue_c
Alter column Member_Id int

Alter table Issue_C
Add Constraint add_pk_fk
Foreign key (Member_Id) references Member_C(Member_Id)

Alter table Issue_C
Add Constraint add_pk_fk_book
Foreign key (Book_No) references Book_C(Book_No)

Alter table Issue_C
Add Constraint Chec_Date
check(Return_Date>Issue_Date)

Alter table Book_C
Add Price numeric(5,2) check(Price<2500)
go

Create view [User_Constraints] As
Select CONSTRAINT_TYPE,CONSTRAINT_NAME
FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS
WHERE TABLE_NAME='Issue_C';
go

select* from [User_Constraints]
go

Alter table Issue_C
nocheck Constraint Chec_Date


insert into Member_C values(1,'2012-04-13',45,250)
insert into Book_C values(123,'Ponniyin_Selvan','Fiction',250)
insert into Book_C values(101,'Ponniyin_Selvan','Fiction',250)
insert into Issue_C values(123,1,101,'2011-11-11','2011-11-11')

select* from Issue_C
select* from Book_C

Insert into Member_C values(7,'2005-12-10',5,50)
Insert into Member_C values(2,GETDATE(),3,NULL)
Insert into Member_C values(3,Null,4,79.80)
Insert into Member_C values(4,GETDATE(),null,56)
Insert into Member_C values(5,'2018-06-09',4,50)

Insert into Book_C values(105,'Let us C','Science',450)
Insert into Book_C values(102,'Oracle-complete Ref','Database',550)
Insert into Book_C values(103,'Mastering SQL','Database',250)
Insert into Book_C values(104,'PL SQL-Ref','Database',750)

Insert into Issue_C values(7001,1,101,'2006-12-10',null),(7002,2,102,'2006-12-25',null),(7003,1,104,'2006-01-15',null),(7004,1,101,'2006-06-04',null),
(7005,2,104,'2006-11-15',null),(7006,3,103,'2006-02-18',null)

go
create view review1 as
select distinct Lib_Issue_Id,Book_Name,I.Member_Id,Issue_Date from Member_C M inner join Issue_C I
on M.Member_Id=I.Member_Id INNER JOIN Book_C B on I.Book_No = B.Book_No
where Cost Between 500 and 750
go 


select* from review1

go
create or Alter view Pricegreaterthan500 
as
select Book_No,Book_Name,Category,Cost from Book_C
where Price >500
go
select* from Pricegreaterthan500
select* from Book_C

insert into Pricegreaterthan500(Book_No,Book_Name) values(108,'Electronics basics -1')

Update Pricegreaterthan500 set Category='Science' where Book_No = 102;
go

delete Issue_C where Book_No=104
delete Pricegreaterthan500 where Book_No = 104

create Index Bookn on Book_C(Book_Name)

create Index Index2 on Issue_C(Member_Id,Book_No)


-- unique index are like primary keys the datas should be unique
create Index index3 on Member_C(Member_Id)


--Member ID is already a primary key Therefore no need of creating a index for that

SELECT * 
FROM sys.indexes 
WHERE name='bookn' AND object_id = OBJECT_ID('Book_C')
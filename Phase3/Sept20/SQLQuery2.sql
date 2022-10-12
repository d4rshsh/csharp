-- 20 sept set 2
use library;
--PS1 List all the members that became the member in the year 2006.
select Member_Name
from Member
where Acc_Open_Date like '2006%';

--PS2 List all the books that are written by Author Loni and has price less then 600.  
select Book_Name
from Book
where Author='Loni' and Cost < 600;

--PS 3 List the Issue details for the books that are not returned yet.
select * from Issue where Return_Date is null;

--PS4 Update all the blank return_date with 31-Dec-06 excluding 7005 and 7006.
update Issue
set Return_Date = '2006-12-31'
where lib_issue_id !=7005 and lib_issue_id !=7006

--PS5 List all the Issue details that have books issued for more then 30 days.
select * from Issue 
where datediff(dd,Return_Date,Issue_Date) >30

--PS6 List all the books that have price in range of 500 to 750 and has category as Database.
select * from Book
where Cost between 500 and 750 and Category= 'database'

--PS7  List all the books that belong to any one of the following categories Science, Database, Fiction, Management.
select * from Book
where Category in ('Science' ,'database' ,'fiction' ,'management')


--PS8 List all the members in the descending order of Penalty due on them.
SELECT * FROM Member
ORDER BY Penalty_Amount desc

--PS9 List all the books in ascending order of category and descending order of price.
SELECT * FROM Book
ORDER BY Category,Cost desc

--PS10  List all the books that contain word SQL in the name of the book
SELECT * FROM Book
WHERE Book_Name LIKE '%SQL%'

--PS11 List all the members whose name starts with R or G and contains letter I in it.
SELECT * from Member
WHERE (Member_Name Like 'R%' or Member_Name Like 'G%') and Member_Name like '%I%'

--PS 12 List the entire book name in Init cap and author in upper case in the descending order of the book name. (wrong)
select UPPER(Author) as Author from Book
order by Book_Name desc

--PS13 Show the data in the following format:
select Book_No,'Is written by' as '--------------' ,Author from Book

--PS14 List the Issue Details for all the books issue by member 101 with Issue_date and Return Date in following format. ‘Monday,July, 10, 2006’. 
SELECT Lib_Issue_Id,Issue_Date, Return_Date, datediff(Day,Issue_Date,Return_Date) as NoOfDays
FROM Issue

--PS15,16 List the data in the book table with category data displayed as D for Database, S for Science, R for RDBMS and O for all the others.
SELECT * FROM Book

--PS17 Display the book name, Author name with spaces padded with *.
SELECT Book_Name,Author from Book

--PS18 List the Lib_Issue_Id, Issue_Date, Return_Date and No of days Book was issued.
select Lib_Issue_Id,Issue_Date,Return_Date,datediff(dd,Issue_Date,Return_Date) as 'No of days book was issued' from Issue

--PS19  Find the details of the member of the Library in the order of their joining the library.
SELECT * from Member
ORDER BY Acc_Open_Date 

--PS20  Display the count of total no of books issued to Member 101.
select COUNT(Book_No) from Issue
where MemberId=1

--PS21 Display the total penalty due for all the members.
Select Sum(Penalty_Amount) as total_penalty_due from Member

--PS22 Find the total cost of all the books that come under category Database.
Select Sum(Cost) as Total_Cost From Book
where Category = 'database'

--PS23 Find the cheapest book price in the library.
Select Min(Cost) from Book

--PS24 Find the date on which the very first book was issued in the library.
Select min(Issue_Date) from Issue

--PS25 Find the date on which most recent the book was issued.
Select max(Issue_Date) from Issue

--PS26 Find the average price of book in Database category.
Select AVG(Cost) From Book
WHERE Category = 'database' 
drop database ExerciseDb
create database ExerciseDb
use ExerciseDb

create table Student
(Sid int primary key,
SName nvarchar(50),
SEmail nvarchar(50),
SContact varchar(10))

insert into Student values (1,'Anand','anand@mail.com', 9876543210)
insert into Student values (2,'Ram','ram@mail.com', 9876543212)
insert into Student values (3,'Ajay','ajay@mail.com', 9876543250)
select * from Student

create table Fee
(Sid int,
SFee float,
Smonth int,
SYear int,
Primary Key(Sid, Smonth, SYear),
Foreign Key (Sid) References Student(Sid))
drop table Fee

create table PayConfirmation
(Sid int,
Name nvarchar(50),
Email nvarchar(50),
Fee float,
PaidOnDate date)

create Trigger trgFeePayConfirmation
on Fee
after insert
as 
declare @id int
declare @fee float
declare @month int
declare @year int
declare @email nvarchar(50)
declare @name nvarchar(50)

select @id = Sid from inserted 
select @name = s.SName from Student s where s.Sid = @id
select @email = s.SEmail from Student s where s.Sid = @id
select @fee = SFee from inserted
select @month = Smonth from inserted 
select @year SYear from inserted

insert into PayConfirmation(Sid, Name, Email, Fee, PaidOnDate) values 
(@id, @name, @email, @fee, convert(date,convert(nvarchar(50), @month)+'/1/'+ convert(nvarchar(50),@year)))
print 'Pay details added'

drop trigger trgFeePayConfirmation

insert into Fee values(1,1000.50,10,2022)
insert into Fee values(2,2000.50,04,2023)
insert into Fee values(3,1500.50,11,2022)
insert into Fee values(1,2500.50,09,2022)
select * from PayConfirmation

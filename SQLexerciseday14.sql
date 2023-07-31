
drop database ExerciseDb
create database ExerciseDb

use ExerciseDb
drop table Products
create table Products
(PId int primary key identity,
PName nvarchar(50) not null,
PPrice float,
PTax as PPrice*0.10 persisted,
PCompany nvarchar(50) check (PCompany in ('Samsung','Apple', 'Redmi','HTC', 'RealMe')),
PQty int default 1 check(PQty>=1))

insert into Products values
('P1', 50000.50, 'Samsung',10),
('P2', 55000.50, 'RealMe',20),
('P3', 110000.50, 'Apple',6),
('P4', 70000.50, 'Samsung',25),
('P5', 550000.50, 'HTC',30),
('P6', 30000.50, 'Redmi',15),
('P7', 20000.50, 'RealMe',40),
('P8', 25000.50, 'Redmi',30),
('P9', 80000.50, 'Apple',25),
('P10', 75000.50, 'Samsung',20)
----------------------------------
create proc Display_info 
as
begin
select PId, PName, (PPrice+PTax) as PPricewithtax , PCompany,PQty, (PQty*(PPrice+PTax)) as TotalPrice
from Products
end

execute Display_info
----------------------------
alter proc Get_Tax
@pcom nvarchar(50),
@ptax float output
with encryption
as 
begin
select @ptax = sum(PTax) from Products where PCompany = @pcom
end

declare @prodtax float;
execute Get_Tax 'Samsung', @prodtax out
print @prodtax





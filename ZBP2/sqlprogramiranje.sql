declare @barva nvarchar(25)='Black',
@velikost nvarchar(5)='L'
select * from SalesLT.Product
where Color=@barva and size=@velikost
go

declare @barva nvarchar(25)
set @barva='Red'
print @barva

declare @rezultat money
select @rezultat=max(totaldue) from SalesLT.SalesOrderHeader
print @rezultat

go
declare @barva nvarchar(25)
set @barva='Red'
if @barva is null
begin
	select * from SalesLT.Product
end
else
begin
	select *from SalesLT.Product
	where color=@barva
end
print @@rowcount
go

declare @cid int=0,@lname nvarchar(25)
while @cid <=5
begin
	select @lname=lastname from SalesLT.Customer
	where CustomerID=@cid
	print @lname
	set @cid+=1
end








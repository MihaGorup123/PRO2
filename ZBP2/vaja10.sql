declare @OrderID int
--naro�ila (SalesOrderID), ID produkta (ProductID), koli�ino (Quantity) in ceno za enoto
--(UnitPrice). Skripta naj najprej preveri ali obstaja ta specifi�en ID v glavah naro�il. �e obstaja,
--naj naro�ilo vstavi v tabelo podrobnosti, kjer naj bodo vrednosti NULL za nedolo�ene
--vrednosti stolpcev. �e ID ne obstaja v glavi naro�il, naj izpi�e �Naro�ilo ne obstaja�.
--Uporabite lahko EXSITS. Testirajte kodo na primeru 


declare @IDnarocila int =12
declare @IDprodukta int =45
declare @qty smallint=3
declare @up money=100

if exists (select SalesOrderID from SalesLT.SalesOrderHeader where SalesOrderID=@IDnarocila)
begin
	insert into SalesLT.SalesOrderDetail
		(SalesOrderID,ProductID,OrderQty,UnitPrice)
	values
		(@IDnarocila,@IDprodukta,@qty,@up)
	select * from SalesLT.SalesOrderDetail
end

else 
	begin 
	print 'Naro�ilo ne obstaja'
end
go


declare @marketavg money=2000
declare @marketmx money=5000
declare @AWavg money;
declare @AWmax money;
select @AWavg=AVG(listprice),@AWmax=max(ListPrice) from [SalesLT].[Product]
where ProductCategoryID in(select distinct ProductCategoryID from SalesLT.vGetAllCategories
where ParentProductCategoryName='Bikes')

while @AWavg<@marketavg
begin
update SalesLT.Product
set ListPrice=ListPrice*1.1
where ProductCategoryID in(select distinct ProductCategoryID from SalesLT.vGetAllCategories
where ParentProductCategoryName='Bikes')

select @AWavg=AVG(listprice),@AWmax=max(ListPrice) from [SalesLT].[Product]
where ProductCategoryID in(select distinct ProductCategoryID from SalesLT.vGetAllCategories
where ParentProductCategoryName='Bikes')

	if @AWmax > @marketmx
		break
	else 
		continue
end


print @AWavg
print @AWmax
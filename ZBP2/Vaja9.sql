insert into SalesLT.Product
(name,productnumber,standardcost,listprice,productcategoryid,)
values
('LED Light','LT-L124' ,2.56 ,12.99,37, GETDATE()
)


insert into SalesLT.ProductCategory
(ParentProductCategoryID,name)
values
(4,'Bells And Horns')

insert into SalesLT.Product
(name,productnumber,standardcost,listprice,ProductCategoryID,[SellStartDate])
values
('Bicycle bell','BB-rinng',2.47,4.99,4,getdate()),
('bicycle horn','BB-pARP',1.29,3.75,4,getdate())

update SalesLT.Product set ListPrice=listprice* (listprice/10) where ProductCategoryID like '4'

update SalesLT.Product set DiscontinuedDate =getdate() where ProductCategoryID ='37' and ProductNumber !='LT-L124'

delete from SalesLT.Product where ProductCategoryID=4

delete from SalesLT.ProductCategory where name='Bells And Horns'
select P.*,PC_CATEID,PS_SLID from PRODUCTS P
left join PRODUCT_CATEGORIES  on PC_PID= P.PRODUCTID
left join PRODUCT_SUPPLIERS on PS_PID =P.PRODUCTID;

go
select *  from Northwind.dbo.Products;
go
insert into TOWASHOP.dbo.PRODUCTS(PRODUCTID,PRODUCTNAME,QUANTITY_PER_UNIT,UNIT_PRICE,UNIT_ON_STOCK,UNIT_ON_ORDER)
values ('P1','Chai','10 boxes x 20 bags',18.00,39,0);
insert into TOWASHOP.dbo.PRODUCTS(PRODUCTID,PRODUCTNAME,QUANTITY_PER_UNIT,UNIT_PRICE,UNIT_ON_STOCK,UNIT_ON_ORDER)
values ('P2','Chang','24 - 12 oz bottles',19.00,17,40);
insert into TOWASHOP.dbo.PRODUCTS(PRODUCTID,PRODUCTNAME,QUANTITY_PER_UNIT,UNIT_PRICE,UNIT_ON_STOCK,UNIT_ON_ORDER)
values ('P3','Aniseed Syrup','12 - 550 ml bottles',10.00,13,70);
go

insert into TOWASHOP.dbo.PRODUCT_CATEGORIES Values('P1',1);
insert into TOWASHOP.dbo.PRODUCT_SUPPLIERS Values('P1','SL1');

insert into TOWASHOP.dbo.PRODUCT_CATEGORIES Values('P2',1);
insert into TOWASHOP.dbo.PRODUCT_SUPPLIERS Values('P2','SL1');

delete from TOWASHOP.dbo.PRODUCT_CATEGORIES  where PRODUCT_CATEGORIES.PC_PID='P1';

select * from CATEGORIES;
select * from SUPPLIERS;
select * from PRODUCT_CATEGORIES;
select * from PRODUCT_SUPPLIERS;


select * from SUPPLIERS;
select * from Northwind.dbo.Suppliers;

insert into SUPPLIERS (SUPPLIERID,SUPPLIER_NAME,CONTACT_NAME,CONTACT_PHONE,SL_ADDRESS,CITY,COUNTRY)
values ('SL1','Exotic Liquids','Charlotte Cooper','(171) 555-2222','49 Gilbert St.','London','UK');

delete from dbo.PRODUCTS where PRODUCTID = 'P1';
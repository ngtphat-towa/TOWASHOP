select * from dbo.CUSTOMER_ORDERS
	join ORDERS on CO_OID = ORDERID
	join CUSTOMERS on CO_CTID = CUSTOMERID;

execute dbo.spCustomerOrder_GetByValue 'Kevin';

execute dbo.spCustomer_GetByValue 'CT100'

execute dbo.spOrder_GetByValue '%%'

select * from dbo.SUPPLY_STOCKS;

select * from dbo.ORDERS
	left join ORDER_DETAILS on OD_OID = ORDERID;

select * from dbo.SUPPLIERS s
	left join PRODUCT_SUPPLIERS  on PS_SLID = s.SUPPLIERID
	left join PRODUCTS p On PS_PID = P.PRODUCTID;

execute dbo.spSupplier_GetByValue '%%';

select * from ORDERS O
	left join SUPPLY_STOCKS on ORDERID = SO_OID
	left join CUSTOMER_ORDERS on ORDERID  = CO_OID
		where SO_OID IS NOT NULl OR CO_OID IS NOT NULL
	
execute dbo.spOrder_GetByValue '%%';

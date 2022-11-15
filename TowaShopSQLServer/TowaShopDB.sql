
DROP DATABASE IF EXISTS TOWASHOP;
GO

CREATE DATABASE TOWASHOP;
GO

USE TOWASHOP;

GO



CREATE TABLE ROLEVIEWS(
	RID INT IDENTITY(1,1),
	ROLENAME NVARCHAR(15) NOT NULL,
	R_DESCRIPTION NVARCHAR(50) NULL DEFAULT NULL,
	CONSTRAINT PK_USER_ROLES
		PRIMARY KEY (RID)
);

GO


CREATE TABLE DBO.ACCOUNTS(
	USERID NVARCHAR(9),
	-- FORMAT UID1001 --
	USERNAME NVARCHAR(25) NOT NULL,
	PASSWORD_HASH NVARCHAR(32) NOT NULL,
	REGISTER_AT DATETIME NOT NULL DEFAULT GETDATE() ,
	LAST_LOGIN DATETIME NULL,
	CONTENT NVARCHAR(MAX) NULL DEFAULT NULL,
	CONSTRAINT PK_ACCOUNTS
		PRIMARY KEY (USERID),
	CONSTRAINT CK_UNIQUE_USERNAME
		UNIQUE(USERNAME)
);

GO

CREATE TABLE DBO.ACCOUNT_ROLEVIEWS(
	AR_UID NVARCHAR(9) NOT NULL,
	AR_RID INT NOT NULL,
	CONSTRAINT PK_ACCOUNT_ROLES 
		PRIMARY KEY (AR_UID,AR_RID),
	CONSTRAINT FK_ACCOUNT_ROLES
		FOREIGN KEY (AR_UID) REFERENCES ACCOUNTS(USERID) 
				ON DELETE CASCADE,
		FOREIGN KEY (AR_RID) REFERENCES ROLEVIEWS(RID)
                ON DELETE CASCADE
);
	
GO

CREATE TABLE DBO.EMPLOYEES( 
	EMPLOYEEID NVARCHAR(8), --EL0001
	CID NVARCHAR(11) NULL,
	FIRST_NAME NVARCHAR(15) NOT NULL,
	LAST_NAME NVARCHAR(15) NOT NULL,
	BIRTHDATE DATETIME NULL,
	SEX SMALLINT NULL DEFAULT '0',
	TITLE NVARCHAR(25) NULL,
	HIDE_DATE DATETIME NULL,
	"ADDRESS" NVARCHAR(50) NULL,
	CITY NVARCHAR(20) NULL,
	COUNTRY NVARCHAR (25) NULl,
	PHONE VARCHAR(20) NOT NULL,
	UPDATE_AT DATETIME NOT NULL DEFAULT GETDATE(),
	CONTENT NVARCHAR(MAX) NULL DEFAULT NULL,
	CONSTRAINT PK_EMPLOYEES
		PRIMARY KEY (EMPLOYEEID),
	CONSTRAINT CK_UNIQUE_CID
		UNIQUE(CID)
);

GO


CREATE TABLE EMPLOYEE_ACCOUNTS(
    EC_UID NVARCHAR(9) NOT NULL,
    EC_EID NVARCHAR(8) NOT NULL,
	
	CONSTRAINT PK_EMPLOYEE_ACCOUNTS
		PRIMARY KEY(EC_UID,EC_EID),
	 CONSTRAINT FK_EMPLOYEE_ACCOUNTS
        FOREIGN KEY (EC_UID) REFERENCES DBO.ACCOUNTS(USERID),
        FOREIGN KEY (EC_EID) REFERENCES DBO.EMPLOYEES (EMPLOYEEID)
				ON DELETE CASCADE 
);

GO

CREATE TABLE CATEGORIES(
    CATEGORYID INT IDENTITY(1,1),
    CATEGORYNAME NVARCHAR(15) UNIQUE,
    C_DESCRIPTION NVARCHAR(60) NULL DEFAULT  NULL,
	CONTENT NVARCHAR(MAX) NULL DEFAULT NULL,
    CONSTRAINT PK_CATEGOIRES
        PRIMARY KEY (CATEGORYID),
	CONSTRAINT CK_UNIQUE_NAME
		UNIQUE(CATEGORYNAME)
);

GO


CREATE TABLE SUPPLIERS(
	SUPPLIERID NVARCHAR(8), -- SL1000 ~ NONE
	SUPPLIER_NAME NVARCHAR(30) NOT NULL,
	CONTACT_NAME NVARCHAR(45) NULL,
	CONTACT_PHONE VARCHAR(20) NOT NULL,
	SL_ADDRESS NVARCHAR(50) NULL DEFAULT NULL,
	CITY NVARCHAR(20) NULL DEFAULT NULL,
	COUNTRY NVARCHAR(20) NULL DEFAULT NULL,
	CONTENT NVARCHAR(MAX) NULL DEFAULT NULL,
	CONSTRAINT PK_SUPPLIERS
		PRIMARY KEY (SUPPLIERID),
);

GO

CREATE TABLE CUSTOMERS(
	CUSTOMERID NVARCHAR(8), -- CT1000 ~ 
	CID NVARCHAR(11) NULL,
	FIRST_NAME NVARCHAR(15) NOT NULL,
	LAST_NAME NVARCHAR(15) NOT NULL,
	CONTACT_PHONE VARCHAR(20) NOT NULL,
	SL_ADDRESS NVARCHAR(50) NULL DEFAULT NULL,
	CITY NVARCHAR(20) NULL DEFAULT NULL,
	COUNTRY NVARCHAR(20) NULL DEFAULT NULL,
	CONTENT NVARCHAR(MAX) NULL DEFAULT NULL,
	CONSTRAINT PK_CUSTOMERS
		PRIMARY KEY (CUSTOMERID)
);

GO


CREATE TABLE PRODUCTS(
	PRODUCTID NVARCHAR(8),
    PRODUCTNAME NVARCHAR(40) NOT NULL,
	BARCODE NVARCHAR(32) NULL DEFAULT NULL,
    QUANTITY_PER_UNIT  NVARCHAR(20) NULL,
    UNIT_PRICE  FLOAT DEFAULT (0),
    SALES_PRICE FLOAT DEFAULT (0),
    UNIT_ON_STOCK SMALLINT DEFAULT(0),
    UNIT_ON_ORDER SMALLINT DEFAULT(0),
    VAT FLOAT DEFAULT (0),
	"STATUS" NVARCHAR(20) NULL,
	CONTENT NVARCHAR(MAX) NULL DEFAULT NULL,
	CONSTRAINT PK_PRODUCTS
		PRIMARY KEY (PRODUCTID),
	CONSTRAINT CK_PRODUCTS
		CHECK (UNIT_PRICE>=0),
		CHECK (SALES_PRICE>=0),
		CHECK(UNIT_ON_STOCK>=0),
		CHECK (UNIT_ON_STOCK>=0)
);

GO


CREATE TABLE PRODUCT_CATEGORIES(
	PC_ID INT IDENTITY(1,1),
	PC_PID NVARCHAR(8) UNIQUE,
	PC_CATEID INT DEFAULT(0)NULL,
	CONSTRAINT PK_PRODUCT_CATEGORIES
		PRIMARY KEY (PC_ID),
	CONSTRAINT FK_PRODUCT_CATEGORIES
		FOREIGN KEY (PC_PID) REFERENCES PRODUCTS(PRODUCTID) ON DELETE CASCADE,
		FOREIGN KEY(PC_CATEID) REFERENCES CATEGORIES(CATEGORYID) ON DELETE CASCADE
);

GO

CREATE TABLE PRODUCT_SUPPLIERS(
	PS_ID INT IDENTITY(1,1),
	PS_PID NVARCHAR(8) UNIQUE,
	PS_SLID NVARCHAR(8) NULL,
	CONSTRAINT PK_PRODUCT_SUPPLIERS
		PRIMARY KEY(PS_ID),
	CONSTRAINT FK_PRODUCT_SUPPLIERS
		FOREIGN KEY (PS_PID) REFERENCES PRODUCTS(PRODUCTID) ON DELETE CASCADE,
		FOREIGN KEY (PS_SLID) REFERENCES SUPPLIERS(SUPPLIERID) ON DELETE CASCADE
);

GO
drop table  if exists ORDERS ;

go
CREATE TABLE ORDERS(
	ORDERID INT IDENTITY(1000,1),
	CREATED_BY NVARCHAR(9) NULL DEFAULT NULL,
	CREATED_AT DATETIME NULL DEFAULT GETDATE(),
	UPDATED_AT DATETIME NULL DEFAULT NULL,
	"ORDER_TYPE" SMALLINT NOT NULL DEFAULT (0), -- 0 RETAIL ORDERS -1 - CUSTOMERS ORDER  2 - NEW STOCK PURCHARGE 
	PAYMENT_METHOD SMALLINT NOT NULL DEFAULT (0), -- 0 CASH -  1 CREDIT
	TOTAL FLOAT NOT NULL DEFAULT 0,
	GRAND_TOTAL FLOAT NULL DEFAULT (0),
	"STATUS" SMALLINT NULL DEFAULT (0), -- NEW -- Paid  -- Delivering
	COMMENTS NVARCHAR(MAX) NULL DEFAULT NULL,
	CONSTRAINT PK_ORDERS
		PRIMARY KEY (ORDERID),
	CONSTRAINT FK_ORDERS
		FOREIGN KEY(CREATED_BY) REFERENCES ACCOUNTS(USERID) ON DELETE SET NULL
);

GO

drop table  if exists ORDER_DETAILS ;

go

CREATE TABLE ORDER_DETAILS(
	OD_ID INT IDENTITY(1,1),
	OD_OID INT,
	OD_PID NVARCHAR(8),
	UNIT_PRICE FLOAT NOT NULL DEFAULT (0),
	QUANTITY SMALLINT NOT NULL DEFAULT (1),
	DISCOUNT FLOAT NOT NULL DEFAULT(0),
	CONSTRAINT PK_ORDER_DETAILS
		PRIMARY KEY (OD_ID),
	CONSTRAINT FK_ORDER_DETAILS
		FOREIGN KEY (OD_OID) REFERENCES DBO.ORDERS(ORDERID) ON DELETE CASCADE,
		FOREIGN KEY (OD_PID) REFERENCES DBO.PRODUCTS(PRODUCTID),
	CONSTRAINT CK_DISCOUNT 
		CHECK (DISCOUNT>=0 AND DISCOUNT<=1),
	CONSTRAINT CK_QUANTITY
		CHECK(QUANTITY>0),
	CONSTRAINT CK_UNIT_PRICE
		CHECK (UNIT_PRICE>=0)
);
GO


drop table  if exists CUSTOMER_ORDERS ;

go

CREATE TABLE CUSTOMER_ORDERS(
	CO_ID INT IDENTITY(1,1),
	CO_CTID NVARCHAR(8),
	CO_OID INT,
	CONSTRAINT PK_CUSTOMER_ORDERS 
		PRIMARY KEY (CO_ID),
	CONSTRAINT CK_CUSTOMER_ORDERS
		UNIQUE (CO_CTID,CO_OID),
	CONSTRAINT FK_CUSTOMER_ORDERS
		FOREIGN KEY (CO_CTID) REFERENCES DBO.CUSTOMERS(CUSTOMERID) ON DELETE SET NULL ,
		FOREIGN KEY (CO_OID) REFERENCES DBO.ORDERS(ORDERID)
);

go
drop table  if exists SUPPLY_STOCKS ;

go

CREATE TABLE SUPPLY_STOCKS(
	SO_ID INT IDENTITY(1,1),
	SO_SLID NVARCHAR(8),
	SO_OID INT,
	CONSTRAINT PK_ORDER_SUPPLIERS 
		PRIMARY KEY (SO_ID),
	CONSTRAINT CK_ORDER_SUPPLIERS
		UNIQUE (SO_SLID,SO_OID),
	CONSTRAINT FK_ORDER_SUPPLIERS
		FOREIGN KEY (SO_SLID) REFERENCES DBO.SUPPLIERS(SUPPLIERID) ON DELETE SET NULL,
		FOREIGN KEY (SO_OID) REFERENCES DBO.ORDERS(ORDERID)
);

go
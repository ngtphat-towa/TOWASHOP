-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
alter PROCEDURE dbo.spProduct_Insert
    @PRODUCTNAME NVARCHAR(40),
	@BARCODE NVARCHAR(32) = NULL,
    @QUANTITY_PER_UNIT  NVARCHAR(20) = NULL,
    @UNIT_PRICE  FLOAT = 0.0,
    @SALES_PRICE FLOAT = @UNIT_PRICE ,
    @UNIT_ON_STOCK SMALLINT =0 ,
    @UNIT_ON_ORDER SMALLINT = 0,
    @VAT FLOAT = 0,
	@STATUS NVARCHAR(20)  = NULL,
	@CONTENT NTEXT = NULL,
	@PC_CATEID INT = 0,
	@PS_SLID NVARCHAR(8) = null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

		SET NOCOUNT ON;
	-- DEFAULT VALUE
	DECLARE @NEWPID nvarchar(8) = 'P0';
	-- CHECK TABLE IS CONTAIN ROWS
	IF EXISTS (SELECT 1 FROM DBO.PRODUCTS)
	BEGIN
		-- TAKE THE LARGEST VALUE OF ID  AND PLUS ONE IN FORMAT
		DECLARE @CURRENTPID nvarchar(8) = (Select Max(PRODUCTID) from dbo.PRODUCTS P);
		DECLARE @NEWID INT = (SELECT Cast(SUBSTRING(@CURRENTPID,3,LEN(@CURRENTPID)) AS INT)+1) ;
		SELECT @NEWPID  =  'P'+CAST(@NEWID as nvarchar(6));
    END;
	INSERT INTO DBO.PRODUCTS (PRODUCTID,PRODUCTNAME,BARCODE,
							  QUANTITY_PER_UNIT,UNIT_PRICE,SALES_PRICE,
							  UNIT_ON_STOCK,UNIT_ON_ORDER,VAT,STATUS,CONTENT)
					VALUES(@NEWPID,@PRODUCTNAME,@BARCODE,
							  @QUANTITY_PER_UNIT,@UNIT_PRICE,@SALES_PRICE,
							  @UNIT_ON_STOCK,@UNIT_ON_ORDER,@VAT,@STATUS,@CONTENT);
	INSERT INTO DBO.PRODUCT_CATEGORIES VALUES (@NEWPID,@PC_CATEID);
	INSERT INTO DBO.PRODUCT_SUPPLIERS VALUES (@NEWPID,@PS_SLID);

END
GO

	
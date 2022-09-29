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
CREATE PROCEDURE dbo.spProduct_Update
	@PRODUCTID NVARCHAR(8),
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

    -- Insert statements for procedure here
	UPDATE DBO.PRODUCTS
		SET 
		    PRODUCTNAME =@PRODUCTNAME,
		    BARCODE =@BARCODE,
		    QUANTITY_PER_UNIT =QUANTITY_PER_UNIT,
		    UNIT_PRICE= @UNIT_PRICE  ,
		    SALES_PRICE = @SALES_PRICE,
			UNIT_ON_STOCK =@UNIT_ON_STOCK,
			UNIT_ON_ORDER= @UNIT_ON_ORDER,
			VAT=@VAT ,
			STATUS   = @STATUS,
			CONTENT=  @CONTENT 
		WHERE PRODUCTID = @PRODUCTID;
	UPDATE DBO.PRODUCT_CATEGORIES
		SET
			PC_CATEID= @PC_CATEID 
		WHERE 
			PC_PID = @PRODUCTID;
	UPDATE DBO.PRODUCT_SUPPLIERS
		SET
			PS_SLID= @PS_SLID 
		WHERE 
			PS_PID = @PRODUCTID;
	
END
GO

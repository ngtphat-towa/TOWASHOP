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
CREATE PROCEDURE dbo.spSupplier_GetByValue
	-- Add the parameters for the stored procedure here
	@SEARCHVALUE nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	DECLARE @VALUE NVARCHAR(52)= '%'+@SEARCHVALUE+'%';
    -- Insert statements for procedure here
	SELECT SL.* FROM DBO.SUPPLIERS SL
	JOIN DBO.PRODUCT_SUPPLIERS PS ON SL.SUPPLIERID = PS.PS_SLID
	JOIN DBO.PRODUCTS P ON P.PRODUCTID = PS_SLID
	WHERE	SL.SUPPLIER_NAME LIKE @VALUE OR
			SL.SUPPLIERID LIKE  @VALUE OR
			SL.CONTACT_PHONE LIKE @VALUE OR
			P.PRODUCTID LIKE @VALUE OR
			P.PRODUCTNAME LIKE @VALUE 
	ORDER BY SL.SUPPLIERID ;

END
GO

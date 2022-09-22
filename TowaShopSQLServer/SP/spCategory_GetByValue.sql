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
CREATE PROCEDURE dbo.spCategory_GetByValue
	-- Add the parameters for the stored procedure here
	@VALUE NVARCHAR(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT C.* FROM DBO.CATEGORIES C
		LEFT JOIN PRODUCT_CATEGORIES PC ON PC_CATEID = C.CATEGORYID
		LEFT JOIN PRODUCTS P ON PC_PID = P.PRODUCTID
	WHERE C.CATEGORYID LIKE @VALUE 
	   OR C.CATEGORYNAME LIKE @VALUE
	   OR C.C_DESCRIPTION LIKE @VALUE
	   OR P.PRODUCTID LIKE @VALUE
	   OR P.BARCODE LIKE @VALUE
	   OR P.PRODUCTNAME LIKE @VALUE;
END
GO

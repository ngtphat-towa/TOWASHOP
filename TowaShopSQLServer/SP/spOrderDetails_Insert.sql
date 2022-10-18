USE [TOWASHOP]
GO
/****** Object:  StoredProcedure [dbo].[spOrderDetails_Insert]    Script Date: 10/12/2022 2:25:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[spOrderDetails_Insert]
	@OD_OID INT,
	@OD_PID NVARCHAR(8),
	@UNIT_PRICE FLOAT = 0,
	@QUANTITY SMALLINT = 1,
	@DISCOUNT FLOAT = 0.0
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
	DECLARE @NEW_QUANTITY INT = 0;
	
    -- Insert statements for procedure here
	EXEC [TOWASHOP].dbo.spProduct_UpdateProductOrder @NEW_QUANTITY ,@QUANTITY ; 
	EXEC [TOWASHOP].dbo.spProduct_UpdateProductStock @NEW_QUANTITY ,@QUANTITY ; 

	INSERT INTO DBO.ORDER_DETAILS(OD_OID,OD_PID,UNIT_PRICE, QUANTITY, DISCOUNT)
		VALUES (@OD_OID,@OD_PID,@UNIT_PRICE, @QUANTITY, @DISCOUNT);
END

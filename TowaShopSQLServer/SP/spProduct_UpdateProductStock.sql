USE [TOWASHOP]
GO
/****** Object:  StoredProcedure [dbo].[spProduct_UpdateOrderStockByOrderDetail]    Script Date: 10/12/2022 2:18:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spProduct_UpdateProductStock]
	@OD_PID NVARCHAR(8),
	 @OLD_QUANTITY INT,
	 @NEW_QUANTITY INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
    -- Insert statements for procedure here
	UPDATE DBO.PRODUCTS
		SET	UNIT_ON_STOCK = UNIT_ON_STOCK + @OLD_QUANTITY  - @NEW_QUANTITY
		WHERE PRODUCTID = @OD_PID;
END

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
CREATE PROCEDURE dbo.spOrderDetails_Update
	@OD_ID INT,
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
	UPDATE DBO.ORDER_DETAILS 
		SET OD_PID = @OD_PID ,
			UNIT_PRICE  = @UNIT_PRICE,
			QUANTITY = @QUANTITY,
			DISCOUNT =@DISCOUNT
		WHERE OD_ID = @OD_ID;
END
GO

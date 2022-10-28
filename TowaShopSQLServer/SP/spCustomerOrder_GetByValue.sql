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
CREATE PROCEDURE dbo.spCustomerOrder_GetByValue
	@VALUE NVARCHAR(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SELECT CO_ID, CO_CTID, O.* FROM CUSTOMER_ORDERS  
		JOIN ORDERS O ON ORDERID = CO_OID
			WHERE CO_ID  = @VALUE 
			   OR CO_CTID = @VALUE
			   OR ORDERID = @VALUE
			   OR CREATED_BY = @VALUE
			   OR ORDER_TYPE = @VALUE
			   OR PAYMENT_METHOD =@VALUE
			   OR STATUS =@VALUE
			   OR COMMENTS = @VALUE;
END
GO

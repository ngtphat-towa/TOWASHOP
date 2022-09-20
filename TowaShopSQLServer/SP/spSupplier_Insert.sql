USE [TOWASHOP]
GO
/****** Object:  StoredProcedure [dbo].[spSupplier_Insert]    Script Date: 9/20/2022 11:26:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spSupplier_Insert]
	-- Add the parameters for the stored procedure here
	@SUPPLIER_NAME NVARCHAR(30),
	@CONTACT_NAME NVARCHAR(45) = NULL,
	@CONTACT_PHONE NVARCHAR(20),
	@SL_ADDRESS NVARCHAR(50)= NULL,
	@CITY NVARCHAR(20)= NULL,
	@COUNTRY NVARCHAR(20) = NULL
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	DECLARE @NEWSLID nvarchar(8);
	SELECT @NEWSLID =  ('SL'+CAST((SELECT Cast(SUBSTRING((Select Max(SUPPLIERID) from dbo.SUPPLIERS S),3,6) AS INT)+1) as varchar(6)));
    -- Insert statements for procedure here
	INSERT INTO DBO.SUPPLIERS (SUPPLIERID,SUPPLIER_NAME, CONTACT_NAME, CONTACT_PHONE, SL_ADDRESS, CITY, COUNTRY)
	VALUES (@NEWSLID,@SUPPLIER_NAME, @CONTACT_NAME,@CONTACT_PHONE, @SL_ADDRESS,@CITY,@COUNTRY);
END

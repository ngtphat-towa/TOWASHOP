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
USE TOWASHOP
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE dbo.spAccount_Login
	-- Add the parameters for the stored procedure here
	@USERNAME nvarchar(50),
	@PASSWORD_HASH nvarchar(50),
	@RID INT = 0 
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
    -- Insert statements for procedure here
	SELECT @RID = A.ACCOUNT_RID FROM DBO.ACCOUNTS A
	WHERE A.USERNAME = @USERNAME and A.PASSWORD_HASH = @PASSWORD_HASH;
	RETURN @RID;
END
GO

/* CASE
	
	0 INVALID PASSWORD
	1->3 : SUCESS
*/
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
CREATE PROCEDURE dbo.spAccount_GetByUsername
	-- Add the parameters for the stored procedure here
	@USERNAME nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	IF EXISTS(SELECT 1 FROM DBO.ACCOUNTS A WHERE A.USERNAME = @USERNAME)
		BEGIN
			-- UPDATE THE THE LOGIN TIME BY THE CURREN TIME
			UPDATE DBO.ACCOUNTS 
			SET 
				LAST_LOGIN = GETDATE()
			WHERE USERNAME = @USERNAME;
			
			-- TAKE WHOLE MODEL INCLUDING USER ROLES
			SELECT A.*,R.* FROM DBO.ACCOUNTS A
				LEFT JOIN DBO.ACCOUNT_ROLES  ON AR_UID = A.USERID
				LEFT JOIN DBO.USER_ROLES R ON R.RID = AR_RID
			WHERE A.USERNAME = @USERNAME ;
		END
END
GO

/* CASE
	
	0 INVALID PASSWORD
	1->3 : SUCESS
*/
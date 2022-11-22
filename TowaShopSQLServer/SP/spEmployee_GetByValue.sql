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
CREATE PROCEDURE dbo.spEmployee_GetByValue 
	-- Add the parameters for the stored procedure here
	@SEARCHVALUE nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT DISTINCT E.*, EC.EC_UID FROM DBO.EMPLOYEES E
	LEFT JOIN DBO.EMPLOYEE_ACCOUNTS EC ON E.EMPLOYEEID = EC_EID
	LEFT JOIN DBO.ACCOUNT_ROLEVIEWS AR ON AR_UID = EC.EC_UID
	WHERE E.CID LIKE @SEARCHVALUE 
	   OR EMPLOYEEID = @SEARCHVALUE
	   OR EC.EC_UID LIKE @SEARCHVALUE 
	   OR E.FIRST_NAME LIKE  @SEARCHVALUE 
	   OR E.LAST_NAME LIKE  @SEARCHVALUE 
	   OR E.PHONE LIKE @SEARCHVALUE 
	   OR E."ADDRESS" LIKE @SEARCHVALUE
	   OR E.CITY LIKE @SEARCHVALUE
	   OR E.COUNTRY LIKE @SEARCHVALUE
	   OR E.CONTENT LIKE @SEARCHVALUE
	   OR E.TITLE LIKE @SEARCHVALUE
	ORDER BY E.EMPLOYEEID DESC;
END
GO

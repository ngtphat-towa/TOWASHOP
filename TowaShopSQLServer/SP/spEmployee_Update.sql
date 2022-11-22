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
CREATE PROCEDURE DBO.spEmployee_Update
	-- Add the parameters for the stored procedure here
	@EMPLOYEEID NVARCHAR(8), --EL0001
	@CID NVARCHAR(11) NULL,
	@FIRST_NAME NVARCHAR(15) ,
	@LAST_NAME NVARCHAR(15) ,
	@BIRTHDATE DATETIME NULL,
	@SEX SMALLINT= 0,
	@TITLE NVARCHAR(25)=  NULL,
	@HIDE_DATE DATETIME ,
	@ADDRESS NVARCHAR(50) ,
	@CITY NVARCHAR(20) ,
	@COUNTRY NVARCHAR (25) ,
	@PHONE VARCHAR(20) ,
	@UPDATE_AT DATETIME ,
	@CONTENT NVARCHAR(255) = NULL 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE DBO.EMPLOYEES
	SET CID = @CID,
		FIRST_NAME = @FIRST_NAME,
		LAST_NAME = @LAST_NAME,
		BIRTHDATE = @BIRTHDATE,
		SEX = @SEX,
		TITLE= @TITLE,
		HIDE_DATE = @HIDE_DATE,
		"ADDRESS"= @ADDRESS,
		CITY = @CITY,
		COUNTRY = @COUNTRY,
		PHONE = @PHONE,
		UPDATE_AT = @UPDATE_AT,
		CONTENT = @CONTENT
	WHERE EMPLOYEEID = @EMPLOYEEID;
END
GO

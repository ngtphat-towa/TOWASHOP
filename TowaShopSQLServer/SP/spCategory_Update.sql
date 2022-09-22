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
CREATE PROCEDURE dbo.spCategory_Update
	-- Add the parameters for the stored procedure here
	@CID INT ,
	@CATEGORYNAME NVARCHAR(15) ,
	@C_DESCRIPTION NVARCHAR(60) =  NULL,
	@CONTENT NTEXT = NULL
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	UPDATE DBO.CATEGORIES
	SET 
		CATEGORYNAME = @CATEGORYNAME,
		C_DESCRIPTION = @C_DESCRIPTION,
		CONTENT = @CONTENT
	WHERE CATEGORYID = @CID;
END
GO

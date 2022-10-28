USE [TOWASHOP]
GO
/****** Object:  StoredProcedure [dbo].[spAccount_GetByUsername]    Script Date: 10/13/2022 2:29:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spAccount_GetByUID]
	-- Add the parameters for the stored procedure here
	@UID nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	IF EXISTS(SELECT 1 FROM DBO.ACCOUNTS A WHERE A.USERID = @UID)
		BEGIN
			
			
			-- TAKE WHOLE MODEL INCLUDING USER ROLES
			SELECT A.*,R.* FROM DBO.ACCOUNTS A
				LEFT JOIN DBO.ACCOUNT_ROLEVIEWS  ON AR_UID = A.USERID
				LEFT JOIN DBO.ROLEVIEWS R ON R.RID = AR_RID
			WHERE USERID = @UID ;
		END
END

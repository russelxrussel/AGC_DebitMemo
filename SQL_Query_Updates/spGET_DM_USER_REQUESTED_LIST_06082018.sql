USE [AGC]
GO
/****** Object:  StoredProcedure [TRANSACTION].[spGET_DM_USER_REQUESTED_LIST]    Script Date: 6/8/2018 11:32:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<RUSSEL VASQUEZ>
-- Create date: <06/6/2018>
-- Description:	<GET LIST OF REQUESTED DEBIT MEMO REQUEST>
-- =============================================
ALTER PROCEDURE [TRANSACTION].[spGET_DM_USER_REQUESTED_LIST]
@USERCODE nvarchar(15)
AS
BEGIN
	
	SELECT A.DMRNum, Convert(date,A.DateRequest,101) as Date_Request, B.BranchName, A.IsPosted, A.IsCompleted, A.Approver_Notes
	FROM 
	[TRANSACTION].[DM_Request_Header] A
	INNER JOIN Master.Branches B
	ON A.BranchCode = B.BranchCode
	WHERE 
	A.UserCode = @USERCODE
	ORDER BY a.DateRequest DESC
END


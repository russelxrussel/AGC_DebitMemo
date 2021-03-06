USE [AGC]
GO
/****** Object:  StoredProcedure [TRANSACTION].[spGET_DM_FOR_APPROVAL_REQUEST]    Script Date: 6/8/2018 9:50:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<RUSSEL VASQUEZ>
-- Create date: <03/27/2018>
-- Description:	<GET FOR APPROVAL LIST ITEM>
-- =============================================
ALTER PROCEDURE [TRANSACTION].[spGET_DM_FOR_APPROVAL_REQUEST]
AS
BEGIN
	
	SELECT A.DMRNum, cONVERT(date, A.DateRequest) as DateRequest, B.BranchName, C.supervisorName, A.Requester_Notes
	FROM [TRANSACTION].DM_Request_Header A
	LEFT JOIN Master.Branches B
	ON A.BranchCode = B.BranchCode
	LEFT JOIN Util.Supervisor_RF C
	ON A.SupervisorID = C.supervisorID
	WHERE A.IsCompleted = 0
	ORDER BY A.DateRequest DESC
	
END


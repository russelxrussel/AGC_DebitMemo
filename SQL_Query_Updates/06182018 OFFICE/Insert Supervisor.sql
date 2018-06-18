USE [AGC]
GO
/****** Object:  StoredProcedure [UTIL].[spINSERT_DM_SUPERVISOR]    Script Date: 6/18/2018 4:44:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<RUSSEL VASQUEZ>
-- Create date: <06/18/2018>
-- Description:	<INSERT NEW SUPERVISOR>
-- =============================================
ALTER PROCEDURE [UTIL].[spINSERT_DM_SUPERVISOR]
@SUPERVISOR_NAME nvarchar(150),
@USER_CODE nvarchar(50)
AS
BEGIN
	
	INSERT INTO UTIL.Supervisor_RF
	(supervisorName,usercode)
	VALUES
	(upper(@SUPERVISOR_NAME),@USER_CODE)

END


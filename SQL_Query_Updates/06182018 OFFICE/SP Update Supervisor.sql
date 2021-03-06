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
-- Description:	<UPDATE SUPERVISOR>
-- =============================================
ALTER PROCEDURE [UTIL].[spUPDATE_DM_SUPERVISOR]
@SUPERVISORID int,
@SUPERVISOR_NAME nvarchar(150),
@IS_ACTIVE bit,
@USER_CODE nvarchar(50)

AS
BEGIN
	
	UPDATE UTIL.Supervisor_RF
	SET supervisorName=UPPER(@SUPERVISOR_NAME),
	isActive=@IS_ACTIVE,usercode=@USER_CODE,
	du=getdate()
	WHERE
	supervisorID =@SUPERVISORID
END


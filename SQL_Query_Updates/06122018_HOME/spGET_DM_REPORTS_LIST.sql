USE [AGC]
GO
/****** Object:  StoredProcedure [UTIL].[spGET_SUPERVISOR_LIST]    Script Date: 06/13/2018 12:06:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<RUSSEL VASQUEZ>
-- Create date: <06/12.2018>
-- Description:	<GET REPORTS REFERENCE>
-- =============================================
CREATE PROCEDURE [UTIL].[spGET_DM_REPORTS_LIST]
AS
BEGIN
	
	SELECT * FROM
	[UTIL].[Reports_RF]
	
END


USE [AGC]
GO
/****** Object:  StoredProcedure [xSystem].[GET_SERVER_DATE_TIME]    Script Date: 06/12/2018 11:48:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<RUSSEL VASQUEZ>
-- Create date: <06/12/2018>
-- Description:	<GET SERVER DATE AND TIME>
-- =============================================
CREATE PROCEDURE [xSys].[GET_SERVER_DATE_TIME] 
AS
BEGIN
	SELECT GETDATE() as SERVER_DATE_TIME

END



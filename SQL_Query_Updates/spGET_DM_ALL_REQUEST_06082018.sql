USE [AGC]
GO
/****** Object:  StoredProcedure [TRANSACTION].[spGET_ALL_REQUEST_COUNT]    Script Date: 6/8/2018 11:14:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<RUSSEL VASQUEZ>
-- Create date: <06/06/2018>
-- Description:	<GET ALL REQUEST>
-- =============================================
CREATE PROCEDURE [TRANSACTION].[spGET_DM_ALL_REQUEST]
AS
BEGIN

	SELECT *
	FROM 
	[TRANSACTION].[DM_Request_Header]

END


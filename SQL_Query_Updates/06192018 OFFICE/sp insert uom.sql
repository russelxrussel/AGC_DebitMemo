USE [AGC]
GO
/****** Object:  StoredProcedure [UTIL].[spINSERT_DM_SUPERVISOR]    Script Date: 6/19/2018 3:38:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<RUSSEL VASQUEZ>
-- Create date: <06/19/2018>
-- Description:	<INSERT NEW Unit of Measurement>
-- =============================================
CREATE PROCEDURE [UTIL].[spINSERT_DM_UOM]
@UOM_CODE nvarchar(150),
@UOM_DESCRIPTION nvarchar(100),
@USER_CODE nvarchar(50)
AS
BEGIN
	
	INSERT INTO UTIL.UnitOfMeasurement_RF
	(uomCode, uomDescription, userCode)
	VALUES
	(upper(@UOM_CODE),UPPER(@UOM_DESCRIPTION),@USER_CODE)

END


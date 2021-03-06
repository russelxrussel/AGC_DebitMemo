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
-- Description:	<UPDATE Unit of Measurement>
-- =============================================
ALTER PROCEDURE [UTIL].[spUPDATE_DM_UOM]
@UOM_ID int,
@UOM_DESCRIPTION nvarchar(100),
@USER_CODE nvarchar(50)
AS
BEGIN
	
	UPDATE UTIL.UnitOfMeasurement_RF
	SET 
	uomDescription = upper(@UOM_DESCRIPTION),
	DU = getdate(),
	userCode = @USER_CODE
	WHERE
	uomID = @UOM_ID

END


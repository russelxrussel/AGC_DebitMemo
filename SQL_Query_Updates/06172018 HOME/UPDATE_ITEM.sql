USE [AGC]
GO
/****** Object:  StoredProcedure [TRANSACTION].[spUPDATE_DM_ITEM]    Script Date: 06/17/2018 7:34:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<RUSSEL VASQUEZ>
-- Create date: <06/17/2018>
-- Description:	<UPDATE ITEMS>
-- =============================================
ALTER PROCEDURE [TRANSACTION].[spUPDATE_DM_ITEM]
@ITEM_ID int,
@ITEM_DESCRIPTION nvarchar(150),
@UOM nvarchar(10),
@ITEM_GROUP nvarchar(3),
@USER_CODE nvarchar(50)
AS
BEGIN
	
	UPDATE Master.DM_Item_MF
	SET ItemDescription=@ITEM_DESCRIPTION,
	UOM=@UOM,ItemGroupCode=@ITEM_GROUP, DU=getdate(),
	UserCode=@USER_CODE
	WHERE
	ItemID = @ITEM_ID
	
END


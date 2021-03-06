USE [AGC]
GO
/****** Object:  StoredProcedure [TRANSACTION].[spUPDATE_DM_DEBIT_MEMO_HEADER_COMPLETE_STATUS]    Script Date: 6/8/2018 2:05:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* UPDATE POSTING
06/008/2018
Russel Vasquez
*/

CREATE PROC [TRANSACTION].[spUPDATE_DM_POST_APPROVED]
@DMRNUM nvarchar(15)
AS
BEGIN

BEGIN TRY
	BEGIN TRANSACTION
	
	-- SETTING COMPLETED THE DEBIT MEMO

	UPDATE [TRANSACTION].[DM_Request_Header]
	SET IsPosted = 1, 
	Remarks_Trail = Remarks_Trail + 'Posted : ' + Convert(nvarchar,getdate(),101),
	DU=getdate()
	WHERE DMRNum = @DMRNUM
		
	COMMIT TRANSACTION
END TRY

BEGIN CATCH

	ROLLBACK TRANSACTION -- Will not commit changes on all tables

END CATCH

END

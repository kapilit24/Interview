USE [Interview]
GO
/****** Object:  Table [dbo].[Patient]    Script Date: 5/10/2023 3:37:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patient](
	[Sending_Facility] [varchar](50) NULL,
	[Message_Type] [varchar](10) NULL,
	[Patient_ID] [varchar](50) NULL,
	[Load_DateTime] [datetime] NULL
) ON [PRIMARY]

GO
/****** Object:  StoredProcedure [dbo].[SP_BTS_SET_PATIENT_HL7]    Script Date: 5/10/2023 3:37:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*	=============================================
	Author		: Kapil
	Description	: This SP used by BizTalk to load Patient information from HL7 messagesd
	
	Revisions	: 
	WHO				WHEN			WHY / WHAT
	--------------------------------------------------------------------------------------------------------------
	Kapil			20230509		1.	Initial code
									
	--------------------------------------------------------------------------------------------------------------
*/

CREATE PROCEDURE [dbo].[SP_BTS_SET_PATIENT_HL7](
	@Sending_Facility	VARCHAR(50),
	@Message_Type		VARCHAR(10),
	@Patient_ID			VARCHAR(50))

AS
BEGIN

	SET NOCOUNT ON
    SET XACT_ABORT ON
	BEGIN TRY	/*	BEGIN TRY CATCH */
		BEGIN TRAN
				INSERT INTO [dbo].[Patient](Sending_Facility,Message_Type,Patient_ID,Load_DateTime)
				VALUES(@Sending_Facility,@Message_Type,@Patient_ID,GETDATE())
		COMMIT TRAN; 
	END TRY
BEGIN CATCH
    	 IF @@TRANCOUNT > 0 ROLLBACK TRAN;
		BEGIN	/*	Log Exception */
		
		declare @Error varchar(100)
					    SET @Error =	'Transaction rolled back' + 
							'Error #: '			+ CONVERT(VARCHAR, ERROR_NUMBER()) + '. ' + 
							'Error Message: '	+ ERROR_MESSAGE() + '. ' +
							'Error Severity: '	+ CAST(ERROR_SEVERITY() AS VARCHAR) + '. ' + 
							'Error Line: '		+ CAST(ERROR_LINE() AS VARCHAR) + '. ' + 
							'Error State: '		+ CAST(ERROR_STATE() AS VARCHAR) 
							
							   RAISERROR(@Error, 0, 1) WITH NOWAIT;						
												
			/*	Send Email Notification if needed */
		END
END CATCH
END
GO

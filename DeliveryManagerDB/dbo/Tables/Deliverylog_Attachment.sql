CREATE TABLE [dbo].[DeliveryLog_Attachment]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [DeliveryNumber] VARCHAR(20) NOT NULL, 
    [AttachmentId] INT NOT NULL, 
    [AttachmentType] INT NOT NULL
)

CREATE TABLE [dbo].[DeliveryLog_Attachment]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [DeliveryNumber] VARCHAR(20) NOT NULL, 
    [AttachmentId] INT NOT NULL, 
    [AttachmentTypeId] INT NOT NULL, 
    CONSTRAINT [FK_DeliveryLog_Attachment_ToDeliveryLog] FOREIGN KEY ([DeliveryNumber]) REFERENCES [DeliveryLog]([DeliveryNumber]), 
    CONSTRAINT [FK_DeliveryLog_Attachment_ToAttachmentId] FOREIGN KEY ([AttachmentId]) REFERENCES [Attachment]([Id]), 
    CONSTRAINT [FK_DeliveryLog_Attachment_ToAttachmentType] FOREIGN KEY ([AttachmentTypeId]) REFERENCES [AttachmentType]([Id])
)

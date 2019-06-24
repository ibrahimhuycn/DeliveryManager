CREATE TABLE [dbo].[DeliveryLog]
(
	[DeliveryNumber] VARCHAR(20) NOT NULL PRIMARY KEY, 
    [CustomerId] INT NOT NULL, 
    [CustomerPoNumber] VARCHAR(50) NOT NULL, 
    [GodownId] INT NOT NULL, 
    [IsPartialDelivery] BIT NOT NULL, 
    [Comment] VARCHAR(200) NOT NULL, 
    [IsEmailed] BIT NOT NULL, 
    CONSTRAINT [FK_DeliveryLog_ToCustomer] FOREIGN KEY ([CustomerId]) REFERENCES [Customer]([Id]), 
    CONSTRAINT [FK_DeliveryLog_ToGodown] FOREIGN KEY ([GodownId]) REFERENCES [Godown]([Id])
)

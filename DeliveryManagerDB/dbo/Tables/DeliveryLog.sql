CREATE TABLE [dbo].[DeliveryLog]
(
	[DeliveryNumber] VARCHAR(20) NOT NULL PRIMARY KEY, 
    [CustomerId] INT NOT NULL, 
    [CustomerPoNumber] VARCHAR(50) NOT NULL, 
    [GodownId] INT NOT NULL, 
    [DeliveredBy] INT NOT NULL, 
    [DeliveredDate] DATETIME NOT NULL, 
    [ReceivedBy] VARCHAR(50) NOT NULL, 
    [ReceivedDate] NCHAR(10) NOT NULL, 
    [IsPartialDelivery] BIT NOT NULL, 
    [Comment] VARCHAR(200) NOT NULL, 
    [IsEmailed] BIT NOT NULL
)

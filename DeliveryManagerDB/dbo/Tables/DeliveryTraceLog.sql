CREATE TABLE [dbo].[DeliveryTraceLog]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[DeliveryLogNUmber] VARCHAR(20) NOT NULL,
    [TraceTypeId] INT NOT NULL, 
    [EmployeeId] INT NOT NULL, 
    [LoggedTime] DATETIME NOT NULL
)
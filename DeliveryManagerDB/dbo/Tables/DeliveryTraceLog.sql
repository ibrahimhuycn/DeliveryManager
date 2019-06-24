CREATE TABLE [dbo].[DeliveryTraceLog]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[DeliveryNumber] VARCHAR(20) NOT NULL,
    [TraceTypeId] INT NOT NULL, 
    [EmployeeId] INT NOT NULL, 
    [LoggedTime] DATETIME NOT NULL, 
    CONSTRAINT [FK_DeliveryTraceLog_ToDeliveryLog] FOREIGN KEY ([DeliveryNumber]) REFERENCES [DeliveryLog]([DeliveryNumber]), 
    CONSTRAINT [FK_DeliveryTraceLog_ToTraceType] FOREIGN KEY ([TraceTypeId]) REFERENCES [TraceType]([Id]), 
    CONSTRAINT [FK_DeliveryTraceLog_ToEmployee] FOREIGN KEY ([EmployeeId]) REFERENCES [Employee]([Id])
)
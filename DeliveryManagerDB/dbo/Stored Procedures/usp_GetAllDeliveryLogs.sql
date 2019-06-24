CREATE PROCEDURE [dbo].[usp_GetAllDeliveryLogs]
AS
BEGIN
	SELECT * 
	FROM dbo.DeliveryLog dl
	INNER JOIN dbo.Customer cu ON dl.CustomerId = cu.Id
	INNER JOIN dbo.Godown gd ON dl.GodownId = gd.Id
	/*Incomplete stored procedure.*/
END

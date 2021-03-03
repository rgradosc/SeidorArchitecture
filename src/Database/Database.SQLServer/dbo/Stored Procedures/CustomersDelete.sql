CREATE PROCEDURE [dbo].[CustomersDelete]
	@DNI VARCHAR(9)
AS
BEGIN
	delete
	from dbo.[Customers]
	where DNI = @DNI;
END
GO

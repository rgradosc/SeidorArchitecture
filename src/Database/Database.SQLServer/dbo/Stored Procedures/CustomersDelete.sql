CREATE PROCEDURE [dbo].[CustomersDelete]
	@DNI VARCHAR(9)
AS
	set nocount on;

	delete
	from dbo.[Customers]
	where DNI = @DNI;
RETURN 0

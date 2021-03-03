CREATE PROCEDURE [dbo].[CustomersGetByDNI]
	@DNI VARCHAR(9)
AS
	set nocount on;

	select [DNI], [Cliente], [FechaNacimiento], [Saldo], [Puntos]
	from [dbo].[Customers]
	where DNI = @DNI;
RETURN 0

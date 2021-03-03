CREATE PROCEDURE [dbo].[CustomersGetByDNI]
	@DNI VARCHAR(9)
AS
BEGIN
	set nocount on;

	select [DNI], [Cliente], [FechaNacimiento], [Saldo], [Puntos]
	from [dbo].[Customers]
	where DNI = @DNI;
END
GO

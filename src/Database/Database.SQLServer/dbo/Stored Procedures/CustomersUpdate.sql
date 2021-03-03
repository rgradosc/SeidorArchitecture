CREATE PROCEDURE [dbo].[CustomersUpdate]
	@DNI VARCHAR(9),
	@Cliente VARCHAR(120),
	@FechaNacimiento datetime,
	@Saldo money,
	@Puntos int
AS
	set nocount on;
	update dbo.[Customers]
	set Cliente = @Cliente,
	FechaNacimiento = @FechaNacimiento,
	Saldo = @Saldo,
	@Puntos = @Puntos
	where DNI = @DNI;
RETURN 0

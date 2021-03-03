CREATE PROCEDURE [dbo].[CustomersUpdate]
	@DNI VARCHAR(9),
	@Saldo money,
	@Puntos int
AS
BEGIN
	update dbo.[Customers]
	set 
	Saldo = @Saldo,
	Puntos = @Puntos
	where DNI = @DNI;
END
GO

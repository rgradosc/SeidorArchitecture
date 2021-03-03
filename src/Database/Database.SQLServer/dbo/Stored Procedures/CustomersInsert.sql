CREATE PROCEDURE [dbo].[CustomersInsert]
	@DNI VARCHAR(9),
	@Cliente VARCHAR(120),
	@FechaNacimiento datetime,
	@Saldo money,
	@Puntos int
AS
	set nocount on;

	insert into dbo.[Customers](DNI, Cliente, FechaNacimiento, Saldo, Puntos)
	values (@DNI, @Cliente, @FechaNacimiento, @Saldo, @Puntos);

RETURN 0

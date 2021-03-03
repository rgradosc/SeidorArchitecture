CREATE PROCEDURE [dbo].[CustomersInsert]
	@DNI VARCHAR(9),
	@Cliente VARCHAR(120),
	@FechaNacimiento datetime,
	@Saldo money,
	@Puntos int
AS
BEGIN
	insert into dbo.[Customers](DNI, Cliente, FechaNacimiento, Saldo, Puntos)
	values (@DNI, @Cliente, @FechaNacimiento, @Saldo, @Puntos);
END 
GO

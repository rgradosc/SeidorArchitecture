CREATE PROCEDURE [dbo].[CustomersList]
	
AS
BEGIN
	set nocount on;
	
	select [DNI], [Cliente], [FechaNacimiento], [Saldo], [Puntos] 
	from dbo.Customers
END
GO

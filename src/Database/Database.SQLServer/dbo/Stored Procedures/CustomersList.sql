CREATE PROCEDURE [dbo].[CustomersList]
	
AS
	set nocount on;
	
	select [DNI], [Cliente], [FechaNacimiento], [Saldo], [Puntos] 
	from dbo.Customers
RETURN 0

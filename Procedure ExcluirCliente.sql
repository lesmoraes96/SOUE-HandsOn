CREATE PROCEDURE dbo.ExcluirCliente
	@CPF varchar(15)
AS
	delete from clientes where cpf = @cpf
CREATE PROCEDURE dbo.buscaTodos
AS
	Select cpf, nome, endereco, telefone
	from clientes
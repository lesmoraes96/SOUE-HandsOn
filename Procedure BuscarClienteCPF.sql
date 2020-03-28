CREATE PROCEDURE dbo.buscaCliCPF
	@CPF varchar(15)
AS
	Select cpf, nome, endereco, telefone
	from clientes
	where CPF=@CPF
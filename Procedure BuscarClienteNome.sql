CREATE PROCEDURE dbo.buscaCliNome
	@nome varchar(50)
AS
	select cpf, nome, endereco, telefone
	from clientes
	where nome like @nome +'%'
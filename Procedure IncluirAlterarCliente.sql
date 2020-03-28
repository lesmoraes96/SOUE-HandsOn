CREATE PROCEDURE dbo.inserir_alterar_Cliente
	@CPF varchar(15),
	@nome varchar(50),
	@endereco varchar (100),
	@telefone varchar(15),
	@flag int
AS
	if (@flag = 1)
	begin
		insert into Clientes(cpf,nome,endereco,telefone)
		values(@CPF,@nome,@endereco,@telefone)
	end
	else begin
		update clientes 
		set nome = @nome, endereco = @endereco, telefone = @telefone
		where cpf = @cpf
	end
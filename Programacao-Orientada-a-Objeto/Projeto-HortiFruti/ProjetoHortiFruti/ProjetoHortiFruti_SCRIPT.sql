CREATE DATABASE ProjetoHortiFruti;

USE ProjetoHortiFruti;

DROP TABLE IF EXISTS Venda_item;
DROP TABLE IF EXISTS Venda;
DROP TABLE IF EXISTS Produto;
DROP TABLE IF EXISTS Categoria;
DROP TABLE IF EXISTS Fornecedor;
DROP TABLE IF EXISTS Cliente;
DROP TABLE IF EXISTS Usuario;

CREATE TABLE Usuario
(
	usuario_id INT IDENTITY PRIMARY KEY,
	nome VARCHAR(250) NOT NULL,
	cpf VARCHAR(20) NOT NULL,
	telefone VARCHAR(20) NOT NULL,
	email VARCHAR(250) NOT NULL,
	cargo VARCHAR(100) NOT NULL,
	setor VARCHAR(100) NOT NULL,
	senha VARCHAR(250) NOT NULL
);

SELECT * FROM Usuario;

CREATE TABLE Cliente
(
	cliente_id INT IDENTITY PRIMARY KEY,
	nome VARCHAR(250) NOT NULL,
	cpf VARCHAR(20) NOT NULL,
	telefone VARCHAR(20) NOT NULL,
	email VARCHAR(250) NOT NULL,
	endereco VARCHAR(250) NOT NULL,
	bairro VARCHAR(150) NOT NULL,
	cidade VARCHAR(150) NOT NULL
);

SELECT * FROM Cliente;

CREATE TABLE Fornecedor
(
	fornecedor_id INT IDENTITY PRIMARY KEY,
	razao_social VARCHAR(250) NOT NULL,
	nome_fantasia VARCHAR(250) NOT NULL,
	cnpj VARCHAR(25) NOT NULL,
	telefone VARCHAR(20) NOT NULL,
	email VARCHAR(250) NOT NULL,
	endereco VARCHAR(250) NOT NULL,
	cidade VARCHAR(150) NOT NULL
);

SELECT * FROM Fornecedor;

CREATE TABLE Categoria
(
	categoria_id INT IDENTITY PRIMARY KEY,
	nome VARCHAR(150) NOT NULL,
	descricao VARCHAR(250) NOT NULL,
	setor VARCHAR(100) NOT NULL,
	tipo_armazenamento VARCHAR(100) NOT NULL,
	temperatura_ideal VARCHAR(50) NOT NULL,
	perecivel VARCHAR(10) NOT NULL,
	observacao VARCHAR(250) NOT NULL
);

SELECT * FROM Categoria;

CREATE TABLE Produto
(
	produto_id INT IDENTITY PRIMARY KEY,
	descricao VARCHAR(250) NOT NULL,
	categoria VARCHAR(150) NOT NULL,
	unidade_medida VARCHAR(20) NOT NULL,
	preco DECIMAL(10, 2) NOT NULL,
	estoque INT NOT NULL,
	origem VARCHAR(150) NOT NULL,
	codigo_barras VARCHAR(50) NOT NULL
);

SELECT * FROM Produto;

CREATE TABLE Venda
(
	venda_id INT IDENTITY PRIMARY KEY,
	data_hora DATETIME NOT NULL,
	cliente_id INT NOT NULL,
	usuario_id INT NOT NULL,
	status CHAR(1) NOT NULL DEFAULT 'P',
	FOREIGN KEY (cliente_id) REFERENCES Cliente (cliente_id) ON DELETE CASCADE,
	FOREIGN KEY (usuario_id) REFERENCES Usuario (usuario_id) ON DELETE CASCADE
);

CREATE TABLE Venda_item
(
	venda_item_id INT IDENTITY PRIMARY KEY,
	venda_id INT NOT NULL,
	produto_id INT NOT NULL,
	quantidade INT NOT NULL,
	valor_unitario DECIMAL(10, 2) NOT NULL,
	FOREIGN KEY (venda_id) REFERENCES Venda (venda_id) ON DELETE CASCADE,
	FOREIGN KEY (produto_id) REFERENCES Produto (produto_id) ON DELETE CASCADE
);

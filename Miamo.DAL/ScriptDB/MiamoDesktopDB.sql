CREATE DATABASE MiamoDesktopDB

Use MiamoDesktopDB

CREATE TABLE Fornecedores
  (
    IdFornecedor INT NOT NULL,
    Nome VARCHAR(50),
    CNPJ INT,
    Email VARCHAR(50),
    Telefone1 VARCHAR(20),
    Telefone2 VARCHAR(20),
    IdEnderecoFornecedor INT UNIQUE,
    Cep VARCHAR(9),
    Logradouro VARCHAR(100),
    Numero INT,
    Complemento VARCHAR(30),
    Bairro VARCHAR(50),
    Cidade VARCHAR(50),
    UF VARCHAR(2),
    PRIMARY KEY(IdFornecedor)
  )
 SELECT * FROM Fornecedores 

IF (NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'EstoqueTotal'))
BEGIN
  CREATE TABLE EstoqueTotal
  (
    IdEstoque INT NOT NULL,
    Quantidade INT,
    IdProduto INT NOT NULL,
    IdUsuario INT NOT NULL,
    IdEntrada INT NOT NULL,
    IdSaida INT NOT NULL,
    PRIMARY KEY(IdEstoque)
  )
  SELECT * FROM EstoqueTotal

END;


IF (NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Produto'))
BEGIN
  CREATE TABLE Produto
  (
    IdProduto INT NOT NULL,
    NomeProduto VARCHAR(50),
    DescricaoProduto VARCHAR(200),
    TamanhoProduto VARCHAR(4),
    CorProduto VARCHAR(20),
    PrecoProduto DECIMAL(10, 2),
    Total INT,
    IdCategoria INT NOT NULL,
    IdFornecedor INT NOT NULL,
    PRIMARY KEY(IdProduto)
  )
  SELECT * FROM Produto
END;

IF (NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Usuario'))
BEGIN
  CREATE TABLE Usuario
  (
    IdUsuario INT IDENTITY NOT NULL,
    NomeUsuario VARCHAR(50),
    SenhaUsuario VARCHAR(50),    
    EmailUsuario VARCHAR(20),
    FKTpUsuario INT NOT NULL,
    PRIMARY KEY(IdUsuario)
  )

  INSERT INTO Usuario VALUES('Romilson', '111111','romilson@email.com','1');
  INSERT INTO Usuario VALUES('Outros', '222222','outros@email.com','2');

  SELECT * FROM Usuario
END;
IF (NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'TpUsuario'))
BEGIN
  CREATE TABLE TpUsuario
  (
    IdTpUsuario INT NOT NULL UNIQUE,
    DescricaoTpUsuario VARCHAR(20),
    PRIMARY KEY(IdTpUsuario)
  )

  INSERT INTO TpUsuario VALUES(1,'Administrador');
  INSERT INTO TpUsuario VALUES(2, 'Outros');

  SELECT * FROM TpUsuario

END;

IF (NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Categoria'))
BEGIN
  CREATE TABLE Categoria
  (
    IdCategoria INT NOT NULL,
    NomeCategoria VARCHAR(50),
    PRIMARY KEY(IdCategoria)
  )
  SELECT * FROM Categoria

END;
IF (NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Cliente'))
BEGIN
  CREATE TABLE Cliente
  (
    IdCliente INT NOT NULL,
    Nome VARCHAR(50),
    CPF VARCHAR(14),
    Email VARCHAR(50),
    Telefone VARCHAR(16),
    DataNascimento DATE,
    PRIMARY KEY(IdCliente)
  )
  SELECT * FROM Cliente

END;
IF (NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'EnderecoCliente'))
BEGIN
  CREATE TABLE EnderecoCliente
  (
    IdEnderecoCliente INT NOT NULL,
    Nome VARCHAR(50),
    Cep VARCHAR(9),
    Logradouro VARCHAR(100),
    Numero INT,
    Complemento VARCHAR(30),
    Bairro VARCHAR(50),
    Cidade VARCHAR(50),
    UF VARCHAR(2),
    PontoReferencia VARCHAR(100),
    IdCliente INT NOT NULL,
    PRIMARY KEY(IdEnderecoCliente)
  )
  SELECT * FROM EnderecoCliente

END;
IF (NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Entrada'))
BEGIN
  CREATE TABLE Entrada
  (
    IdEntrada INT NOT NULL,
    Quantidade INT,
    Data DATE,
    IdFornecedor INT NOT NULL,
    IdUsuario INT,
    IdProduto INT NOT NULL,
    PRIMARY KEY(IdEntrada)
  )
  SELECT * FROM Entrada
END;
IF (NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Saida'))
BEGIN
  CREATE TABLE Saida
  (
    IdSaida INT NOT NULL,
    Quantidade INT,
    Data DATE,
    IdProduto INT NOT NULL,
    PRIMARY KEY(IdSaida)
  )
  SELECT * FROM Saida

END;
-- Create FKs
ALTER TABLE TpUsuario
    ADD    FOREIGN KEY (IdUsuario)
    REFERENCES Usuario(IdUsuario)
;
ALTER TABLE EnderecoCliente
    ADD    FOREIGN KEY (IdCliente)
    REFERENCES Cliente(IdCliente)
;
ALTER TABLE Entrada
    ADD    FOREIGN KEY (IdProduto)
    REFERENCES Produto(IdProduto)
;
ALTER TABLE Saida
    ADD    FOREIGN KEY (IdProduto)
    REFERENCES Produto(IdProduto)
;
ALTER TABLE EstoqueTotal
    ADD    FOREIGN KEY (IdProduto)
    REFERENCES Produto(IdProduto)
;
ALTER TABLE EstoqueTotal
    ADD    FOREIGN KEY (IdEntrada)
    REFERENCES Entrada(IdEntrada)
;
ALTER TABLE EstoqueTotal
    ADD    FOREIGN KEY (IdSaida)
    REFERENCES saida(IdSaida) 
;
ALTER TABLE Entrada
    ADD    FOREIGN KEY (IdFornecedor)
    REFERENCES Fornecedores(IdFornecedor)
;
ALTER TABLE Usuario
    ADD    FOREIGN KEY (IdTpUsuario)
    REFERENCES TpUsuario(IdTpUsuario) 
;
ALTER TABLE Produto
    ADD    FOREIGN KEY (IdCategoria)
    REFERENCES Categoria(id_Categoria)
;
ALTER TABLE Entrada
    ADD    FOREIGN KEY (IdUsuario)
    REFERENCES Usuario(id_usuario)
;
ALTER TABLE Produto
    ADD    FOREIGN KEY (IdFornecedor)
    REFERENCES Fornecedores(IdFornecedor)
;

ALTER TABLE dbo.Usuario DROP COLUMN TipoUsuario;
GO

-- drop table Usuario

-- drop database MiamoDesktopDB
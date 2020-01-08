CREATE DATABASE dbCadastroUsuario; 

USE dbCadastroUsuario; 

CREATE TABLE Cadastro 
  ( 
     nome      VARCHAR(50), 
     sobrenome VARCHAR(50), 
     email     VARCHAR(50) PRIMARY KEY 
  ); 

SELECT * 
FROM   Cadastro; 

INSERT INTO Cadastro 
VALUES      ('Teste', 
             'Teste', 
             'teste@teste.com'); 

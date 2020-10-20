CREATE DATABASE BDSistemaFull
GO

USE BDSistemaFull
GO

CREATE TABLE Pessoas (
	CdPessoa int PRIMARY KEY IDENTITY,
	NmPessoa varchar(50) NOT NULL,
	NrCPF varchar(14) NOT NULL,
	DtNascimento date NOT NULL,
	DsEstadoCivil char(1) NOT NULL,
	DsSexo char(1) NOT NULL,
	DsEmail varchar(100) NOT NULL,
	NrTelefone varchar(20) NOT NULL,
	BtRecebeSMS bit NOT NULL,
	BtRecebeEmail bit NOT NULL
)
GO
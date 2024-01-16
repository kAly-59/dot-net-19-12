﻿CREATE DATABASE Exercice01Etudiant;
GO

USE Exercice01Etudiant;
GO

CREATE TABLE etudiant (
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	prenom VARCHAR(50) NOT NULL,
	nom VARCHAR(50) NOT NULL,
	numero_classe INT NOT NULL,
	date_diplome DATETIME2
);
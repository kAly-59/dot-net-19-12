﻿CREATE DATABASE ECommerce;
GO

CREATE TABLE client (
	id INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	prenom VARCHAR(50) NOT NULL,
	nom VARCHAR(50) NOT NULL,
	adresse VARCHAR(200) NOT NULL,
	code_postal VARCHAR(5) NOT NULL,
	ville VARCHAR(100) NOT NULL,
	telephone VARCHAR(10) NOT NULL
);
GO

CREATE TABLE commande (
	id INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	total DECIMAL NOT NULL,
	date_commande DATETIME2 NOT NULL,
	client_id INT NOT NULL,
	CONSTRAINT FK_client_commande_client_id FOREIGN KEY(client_id) REFERENCES client(id)
);
GO
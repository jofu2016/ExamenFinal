CREATE DATABASE DB_CRCICLISMO
GO

USE DB_CRCICLISMO
GO 

CREATE TABLE TB_BICIS(
ID INT IDENTITY (1001,1)PRIMARY KEY,
MARCA VARCHAR(20),
CANTIDAD INT,
PRECIO NUMERIC)
GO

INSERT INTO TB_BICIS VALUES
('Merida', 20, 59999),
('MTB cycling', 15, 110000),
('SuperBike', 7, 150000)

SELECT * FROM TB_BICIS
GO
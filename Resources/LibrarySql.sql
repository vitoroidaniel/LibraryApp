USE MASTER 

GO

DROP DATABASE IF EXISTS Biblioteca

GO

CREATE DATABASE Biblioteca

GO

USE Biblioteca 

GO

CREATE TYPE string FROM VARCHAR(50)

GO

CREATE TABLE Carte(
	Id INT PRIMARY KEY,
	ISBN VARCHAR(100) NOT NULL,
	Titlu VARCHAR(75) NOT NULL,
	Autor string NOT NULL,
	Domeniu VARCHAR(30) NOT NULL,
	Editura VARCHAR(70) NOT NULL,
	Anul_Editarii INT CHECK (Anul_Editarii > 1900)
 )

GO

CREATE TABLE Cititor(
	Id INT PRIMARY KEY,
	Nume_Prenume VARCHAR(60) NOT NULL,
	Adresa VARCHAR(60) NOT NULL,
	Telefon VARCHAR(60) NOT NULL
 )

GO

CREATE TABLE Imprumut(
	Id_cititor  INT FOREIGN KEY REFERENCES Cititor(Id),
	Id_carte INT  FOREIGN KEY REFERENCES Carte(Id),
	Data_imprumut DATE,
	Data_returnarii  DATE
)

GO

-- FUNCTIONS FOR AUTOGENERATE ID'S
CREATE FUNCTION dbo.GENER_Carte()
RETURNS TINYINT
AS
BEGIN
    DECLARE @Id TINYINT;

    IF NOT EXISTS (SELECT 1 FROM Carte)
    BEGIN
        SET @Id = 1;
    END
    ELSE
    BEGIN
        SET @Id = (SELECT MAX(Id) FROM Carte) + 1;
    END
	
	RETURN @Id;
END;

GO

CREATE FUNCTION dbo.GENER_Cititor()
RETURNS TINYINT
AS
BEGIN
    DECLARE @Id TINYINT;

    IF NOT EXISTS (SELECT 1 FROM Cititor)
    BEGIN
        SET @Id = 1;
    END
    ELSE
    BEGIN
        SET @Id = (SELECT MAX(Id) FROM Cititor) + 1;
    END
	
	RETURN @Id;
END;

GO

-- INSERT STORED PROCEDURES
DROP PROCEDURE IF EXISTS INSERT_Carte

GO

CREATE PROCEDURE INSERT_Carte
    @ISBN VARCHAR(100),
	@Titlu VARCHAR(75),
	@Autor string,
	@Domeniu VARCHAR(30),
	@Editura VARCHAR(70),
	@Anul_Editarii INT
AS
BEGIN
    DECLARE @NewId INT;

    -- Auto-generate ID using the function
    SET @NewId = dbo.GENER_Carte();

    -- Insert data
    INSERT INTO Carte(Id, ISBN, Titlu, Autor, Domeniu, Editura, Anul_Editarii)
    VALUES (@NewId, @ISBN, @Titlu, @Autor, @Domeniu, @Editura, @Anul_Editarii);

END;

GO

DROP PROCEDURE IF EXISTS INSERT_Cititor

GO

CREATE PROCEDURE INSERT_Cititor
    @Nume_Prenume VARCHAR(50),
	@Adresa VARCHAR(60),
	@Telefon VARCHAR(60)
AS
BEGIN
    DECLARE @NewId INT;

    -- Auto-generate ID using the function
    SET @NewId = dbo.GENER_Cititor();

    -- Insert data
    INSERT INTO Cititor(Id, Nume_Prenume, Adresa, Telefon)
    VALUES (@NewId, @Nume_Prenume, @Adresa, @Telefon);

END;

GO

DROP PROCEDURE IF EXISTS INSERT_Imprumut

GO

CREATE PROCEDURE INSERT_Imprumut
	@Id_cititor INT,
	@Id_carte INT,
	@Data_imprumut DATE,
	@Data_returnarii DATE
AS
BEGIN
	INSERT INTO Imprumut (Id_cititor, Id_carte, Data_imprumut, Data_returnarii)
	VALUES (@Id_cititor, @Id_carte, @Data_imprumut, @Data_returnarii)

END;

GO

-- PROCEDURES FOR INSERT AND DELETE
-- Update procedure for Carte table
DROP PROCEDURE IF EXISTS UPDATE_Carte;
GO

CREATE PROCEDURE UPDATE_Carte
    @Id INT,
    @ISBN VARCHAR(100),
    @Titlu VARCHAR(75),
    @Autor string,
    @Domeniu VARCHAR(30),
    @Editura VARCHAR(70),
    @Anul_Editarii INT
AS
BEGIN
    UPDATE Carte
    SET ISBN = @ISBN,
        Titlu = @Titlu,
        Autor = @Autor,
        Domeniu = @Domeniu,
        Editura = @Editura,
        Anul_Editarii = @Anul_Editarii
    WHERE Id = @Id;
END;
GO

-- Delete procedure for Carte table
DROP PROCEDURE IF EXISTS DELETE_Carte;
GO

CREATE PROCEDURE DELETE_Carte
    @Id INT
AS
BEGIN
    DELETE FROM Carte
    WHERE Id = @Id;
END;
GO

-- Update procedure for Cititor table
DROP PROCEDURE IF EXISTS UPDATE_Cititor;
GO

CREATE PROCEDURE UPDATE_Cititor
    @Id INT,
    @Nume_Prenume VARCHAR(50),
    @Adresa VARCHAR(60),
    @Telefon VARCHAR(60)
AS
BEGIN
    UPDATE Cititor
    SET Nume_Prenume = @Nume_Prenume,
        Adresa = @Adresa,
        Telefon = @Telefon
    WHERE Id = @Id;
END;
GO

-- Delete procedure for Cititor table
DROP PROCEDURE IF EXISTS DELETE_Cititor;
GO

CREATE PROCEDURE DELETE_Cititor
    @Id INT
AS
BEGIN
    DELETE FROM Cititor
    WHERE Id = @Id;
END;
GO

-- Update procedure for Imprumut table
DROP PROCEDURE IF EXISTS UPDATE_Imprumut;
GO

CREATE PROCEDURE UPDATE_Imprumut
    @Id_cititor INT,
    @Id_carte INT,
    @Data_imprumut DATE,
    @Data_returnarii DATE
AS
BEGIN
    UPDATE Imprumut
    SET Data_imprumut = @Data_imprumut,
        Data_returnarii = @Data_returnarii
    WHERE Id_cititor = @Id_cititor AND Id_carte = @Id_carte;
END;
GO

-- Delete procedure for Imprumut table
DROP PROCEDURE IF EXISTS DELETE_Imprumut;
GO

CREATE PROCEDURE DELETE_Imprumut
    @Id_cititor INT,
    @Id_carte INT
AS
BEGIN
    DELETE FROM Imprumut
    WHERE Id_cititor = @Id_cititor AND Id_carte = @Id_carte;
END;
GO

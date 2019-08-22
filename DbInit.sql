CREATE DATABASE fsharppoc;

USE fsharppoc;

CREATE TABLE [User] (
    UserId bigint PRIMARY KEY IDENTITY(1, 1),
    FirstName nvarchar(100) NOT NULL,
    LastName nvarchar(250) NOT NULL,
    PhoneNumber nvarchar(50) NULL,
    StreetName nvarchar(max) NOT NULL,
    StreetNumber int NOT NULL,
    City nvarchar(150) NULL,
    Country nvarchar(150) NOT NULL
);

INSERT INTO [User] (FirstName, LastName, PhoneNumber, StreetName, StreetNumber, City, Country) VALUES
('Adrien', 'John', '+352456789876', 'Nom d''une rue', 17, NULL, 'Luxembourg')
, ('Thibault', 'Legrand', NULL, 'Nom d''une autre rue', 19, 'Luxembourg', 'Luxembourg' )

SELECT * FROM [User]
CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL  IDENTITY, 
    [Imie] NVARCHAR(50) NULL, 
    [Nazwisko] NVARCHAR(50) NULL, 
    [Nazwa Firmy] NVARCHAR(50) NULL, 
    [Miasto] NVARCHAR(50) NULL, 
    [Ulica] NVARCHAR(50) NULL, 
    [Kod Pocztowy] NUMERIC NULL, 
    [Telefon] NUMERIC NULL, 
    [Email] NVARCHAR(50) NULL, 
    [NIP] NUMERIC NULL, 
    CONSTRAINT [PK_Table] PRIMARY KEY ([Id])
)

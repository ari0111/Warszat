CREATE TABLE [dbo].[Table]
(
	[KlientId] INT NULL  IDENTITY, 
    [Nazwa Firmy] NVARCHAR(50) NULL, 
    [NIP] NVARCHAR(50) NULL, 
    [Ulica] NVARCHAR(50) NULL, 
    [Miasto] NVARCHAR(50) NULL, 
    [Kod Pocztowy] NVARCHAR(50) NULL, 
    [Telefon] NVARCHAR(50) NULL, 
    [Email] NVARCHAR(50) NULL, 
    [Imie] NVARCHAR(50) NULL, 
    [Nazwisko] NVARCHAR(50) NULL, 
    CONSTRAINT [PK_Table] PRIMARY KEY ([KlientId])
)

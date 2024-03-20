CREATE TABLE [dbo].[Clienti] (
    [id_client]    INT         IDENTITY (1, 1) NOT NULL,
    [parola]       NCHAR (50)  NOT NULL,
    [nume]         NCHAR (50)  NOT NULL,
    [prenume]      NCHAR (50)  NOT NULL,
    [adresa]       NCHAR (100) NOT NULL,
    [email]        NCHAR (100) NOT NULL,
    [kcal_zilnice] INT         DEFAULT ((2000)) NOT NULL,
    PRIMARY KEY CLUSTERED ([id_client] ASC)
	
);


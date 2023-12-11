CREATE TABLE [dbo].[Verlof] (
    [VerlofID] INT            NOT NULL,
    [WerknemerID] INT NOT NULL,
    [RedenVerlof] VARCHAR(50)  NOT NULL,
    [Beschrijving] VARCHAR(MAX) NULL, 
    [StartDatum] DATE NULL, 
    [EindDatum] DATE NOT NULL, 
    [Status] INT NOT NULL, 
    CONSTRAINT [PK_Verlof] PRIMARY KEY CLUSTERED ([VerlofID])
);


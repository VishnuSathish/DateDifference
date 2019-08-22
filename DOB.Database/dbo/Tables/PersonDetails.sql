CREATE TABLE [dbo].[PersonDetails] (
    [Id]         INT          IDENTITY (1, 1) NOT NULL,
    [PersonName] VARCHAR (30) NULL,
    [PersonDob]  DATE         NULL,
    [PersonAge]  INT          NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


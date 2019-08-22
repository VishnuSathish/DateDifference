CREATE TABLE [dbo].[Pet] (
    [Id]       INT          NULL,
    [PetId]    INT          IDENTITY (1, 1) NOT NULL,
    [PetBreed] VARCHAR (30) NULL,
    PRIMARY KEY CLUSTERED ([PetId] ASC),
    FOREIGN KEY ([Id]) REFERENCES [dbo].[PersonDetails] ([Id])
);


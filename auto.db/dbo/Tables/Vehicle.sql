CREATE TABLE [dbo].[Vehicle] (
    [Id]     INT IDENTITY (1, 1) NOT NULL,
    [MakeId] INT NOT NULL,
    [Mpg]    INT CONSTRAINT [DF_Vehicle_Mpg] DEFAULT ((0)) NOT NULL,
    [UserId] INT NOT NULL,
    CONSTRAINT [PK_Vehicle] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Vehicle_Make] FOREIGN KEY ([MakeId]) REFERENCES [dbo].[Make] ([Id])
);


CREATE TABLE [dbo].[Boards] (
    [id]        INT            IDENTITY (1, 1) NOT NULL,
    [Subject]   NCHAR (250)    NOT NULL,
    [Contents]  NVARCHAR (MAX) NULL,
    [RegDate]   DATETIME       CONSTRAINT [DF_Boards_RegDate] DEFAULT (getdate()) NULL,
    [ReadCount] INT            NULL,
    [Writer]    NVARCHAR (25)  NOT NULL,
    CONSTRAINT [PK_Boards] PRIMARY KEY CLUSTERED ([id] ASC)
);


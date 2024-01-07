CREATE TABLE [dbo].[Client] (
    [ID]            INT            IDENTITY (1, 1) NOT NULL,
    [NumeClient]    NVARCHAR (MAX) NULL,
    [Email]         NVARCHAR (100) NOT NULL,
    [Telefon]       NVARCHAR (MAX) NOT NULL,
    [PrenumeClient] NVARCHAR (MAX) DEFAULT (N'') NULL,
    CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED ([ID] ASC)
);


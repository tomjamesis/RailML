CREATE TABLE [dbo].[TOcpWithIDAndName]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[AdditionalName]	BIGINT			NOT NULL,
	[Any]				VARCHAR(MAX)		NOT NULL,
	[TOcpWithIDAndNameId]	NVARCHAR(255)	NOT NULL,
	[Code]				NVARCHAR(MAX)	NOT NULL,
	[Type]				NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TOcpWithIDAndNameId] PRIMARY KEY CLUSTERED ([TOcpWithIDAndNameId] ASC),
	CONSTRAINT [FK_TOcpWithIDAndName_TAdditionalOcpName] FOREIGN KEY ([AdditionalName]) REFERENCES [dbo].[TAdditionalOcpName] ([TAdditionalOcpNameId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);

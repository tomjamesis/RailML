CREATE TABLE [dbo].[TElementWithIDAndName]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[AdditionalName]		BIGINT			NOT NULL,
	[Any]					VARCHAR(MAX)		NOT NULL,
	[TElementWithIDAndNameId]	NVARCHAR(255)	NOT NULL,
	[Code]					NVARCHAR(MAX)	NOT NULL,
	[Name]					NVARCHAR(MAX)	NOT NULL,
	[Description]			NVARCHAR(MAX)	NOT NULL,
	[Lang]					NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TElementWithIDAndNameId] PRIMARY KEY CLUSTERED ([TElementWithIDAndNameId] ASC),
	CONSTRAINT [FK_TElementWithIDAndName_TAdditionalName] FOREIGN KEY ([AdditionalName]) REFERENCES [dbo].[TAdditionalName] ([TAdditionalNameId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);

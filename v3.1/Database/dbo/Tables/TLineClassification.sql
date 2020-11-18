CREATE TABLE [dbo].[TLineClassification]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TLineClassificationId]	BIGINT			NOT NULL,
	[Name]					NVARCHAR(MAX)	NOT NULL,
	[PayLoad]				DECIMAL(18, 6)	NOT NULL,

	CONSTRAINT [PK_TLineClassificationId] PRIMARY KEY CLUSTERED ([TLineClassificationId] ASC)
);

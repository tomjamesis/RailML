CREATE TABLE [dbo].[TCrossedElement]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TCrossedElementId]	SMALLINT			NOT NULL,
	[Type]				NVARCHAR(MAX)	NOT NULL,
	[PosValue]			DECIMAL(18, 6)	NOT NULL,
	[PosValueSpecified]	BIT				NOT NULL,

	CONSTRAINT [PK_TCrossedElementId] PRIMARY KEY CLUSTERED ([TCrossedElementId] ASC)
);

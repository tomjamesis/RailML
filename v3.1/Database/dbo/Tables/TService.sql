CREATE TABLE [dbo].[TService]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TServiceId]		BIGINT			NOT NULL,
	[Name]				NVARCHAR(MAX)	NOT NULL,
	[TapTsiType7161Code]NVARCHAR(MAX)	NOT NULL,
	[Count]			NVARCHAR(MAX)	NOT NULL,
	[Description]		NVARCHAR(MAX)	NOT NULL,
	[ValueValue]		DECIMAL(18, 6)	NOT NULL,
	[ValueValueSpecified]	BIT				NOT NULL,
	[Type]				NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TServiceId] PRIMARY KEY CLUSTERED ([TServiceId] ASC)
);

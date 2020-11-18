CREATE TABLE [dbo].[TTopologyReference]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TTopologyReferenceId]	BIGINT			NOT NULL,
	[Register]				NVARCHAR(MAX)	NOT NULL,
	[Entry]				NVARCHAR(MAX)	NOT NULL,
	[StartDateValue]		DATETIME			NOT NULL,
	[StartDateValueSpecified]	BIT				NOT NULL,
	[EndDateValue]			DATETIME			NOT NULL,
	[EndDateValueSpecified]BIT				NOT NULL,

	CONSTRAINT [PK_TTopologyReferenceId] PRIMARY KEY CLUSTERED ([TTopologyReferenceId] ASC)
);

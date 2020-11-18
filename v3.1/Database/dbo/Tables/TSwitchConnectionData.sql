CREATE TABLE [dbo].[TSwitchConnectionData]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TSwitchConnectionDataId]	SMALLINT			NOT NULL,
	[Course]					NVARCHAR(MAX)	NOT NULL,
	[RadiusValue]				DECIMAL(18, 6)	NOT NULL,
	[RadiusValueSpecified]		BIT				NOT NULL,
	[MaxSpeedValue]			DECIMAL(18, 6)	NOT NULL,
	[MaxSpeedValueSpecified]	BIT				NOT NULL,
	[BranchDistValue]			DECIMAL(18, 6)	NOT NULL,
	[BranchDistValueSpecified]	BIT				NOT NULL,
	[Orientation]				NVARCHAR(MAX)	NOT NULL,
	[Passable]					BIT				NOT NULL,

	CONSTRAINT [PK_TSwitchConnectionDataId] PRIMARY KEY CLUSTERED ([TSwitchConnectionDataId] ASC)
);

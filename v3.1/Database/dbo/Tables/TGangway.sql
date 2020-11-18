CREATE TABLE [dbo].[TGangway]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TGangwayId]				BIGINT			NOT NULL,
	[FrontEnd]					BIT				NOT NULL,
	[RearEnd]					BIT				NOT NULL,
	[Position]					NVARCHAR(MAX)	NOT NULL,
	[DesignType]				NVARCHAR(MAX)	NOT NULL,
	[FloorLevelValue]			DECIMAL(18, 6)	NOT NULL,
	[FloorLevelValueSpecified]	BIT				NOT NULL,
	[GangwayHeightValue]		DECIMAL(18, 6)	NOT NULL,
	[GangwayHeightValueSpecified]	BIT				NOT NULL,
	[GangwayWidthValue]		DECIMAL(18, 6)	NOT NULL,
	[GangwayWidthValueSpecified]BIT				NOT NULL,

	CONSTRAINT [PK_TGangwayId] PRIMARY KEY CLUSTERED ([TGangwayId] ASC)
);

CREATE TABLE [dbo].[TSectionTT]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TSectionTTId]						BIGINT			NOT NULL,
	[Any]								VARCHAR(MAX)		NOT NULL,
	[Section]							NVARCHAR(MAX)	NOT NULL,
	[LineRef]							NVARCHAR(MAX)	NOT NULL,
	[TrackInfo]						NVARCHAR(MAX)	NOT NULL,
	[Description]						NVARCHAR(MAX)	NOT NULL,
	[Remarks]							NVARCHAR(MAX)	NOT NULL,
	[PercentageSupplementValue]		DECIMAL(18, 6)	NOT NULL,
	[PercentageSupplementValueSpecified]	BIT				NOT NULL,
	[DistanceValue]					DECIMAL(18, 6)	NOT NULL,
	[DistanceValueSpecified]			BIT				NOT NULL,

	CONSTRAINT [PK_TSectionTTId] PRIMARY KEY CLUSTERED ([TSectionTTId] ASC)
);

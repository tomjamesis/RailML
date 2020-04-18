CREATE TABLE [dbo].[ETrackEnd]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[ETrackEndId]			SMALLINT		NOT NULL,
	[AbsPosInValue]		DECIMAL(18, 6)	NOT NULL,
	[AbsPosInValueSpecified]	BIT			NOT NULL,

	CONSTRAINT [PK_ETrackEndId] PRIMARY KEY CLUSTERED ([ETrackEndId] ASC)
);

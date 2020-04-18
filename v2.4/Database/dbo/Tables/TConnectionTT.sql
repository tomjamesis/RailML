CREATE TABLE [dbo].[TConnectionTT]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TConnectionTTId]			BIGINT			NOT NULL,
	[Any]						VARCHAR(MAX)		NOT NULL,
	[TrainRef]					NVARCHAR(MAX)	NOT NULL,
	[MinConnTime]				NVARCHAR(MAX)	NOT NULL,
	[MaxConnTime]				NVARCHAR(MAX)	NOT NULL,
	[ConnOperation]			NVARCHAR(MAX)	NOT NULL,
	[ConnType]					NVARCHAR(MAX)	NOT NULL,
	[OcpRef]					NVARCHAR(MAX)	NOT NULL,
	[TrainPartRef]				NVARCHAR(MAX)	NOT NULL,
	[OperatingPeriodRef]		NVARCHAR(MAX)	NOT NULL,
	[NotGuaranteedValue]		BIT				NOT NULL,
	[NotGuaranteedValueSpecified]	BIT				NOT NULL,
	[NonConnectionValue]		BIT				NOT NULL,
	[NonConnectionValueSpecified]	BIT				NOT NULL,
	[SamePlatformValue]		BIT				NOT NULL,
	[SamePlatformValueSpecified]BIT				NOT NULL,

	CONSTRAINT [PK_TConnectionTTId] PRIMARY KEY CLUSTERED ([TConnectionTTId] ASC)
);

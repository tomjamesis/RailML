CREATE TABLE [dbo].[TSignalBraking]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TSignalBrakingId]	SMALLINT			NOT NULL,
	[TrackConditionRef]	NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TSignalBrakingId] PRIMARY KEY CLUSTERED ([TSignalBrakingId] ASC)
);
